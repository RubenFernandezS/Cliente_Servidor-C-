using Estudiantes.Entidades;
using EstudiantesServer.Datos;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;



namespace EstudiantesServer
{
    public partial class FrmServer : Form
    {
        private TcpListener _listenerClient;
        private Thread _threadListenerClient;

        private Methods _method;

        private bool _connected;

        private delegate void WriteBitacora(string text);
        private delegate void UpdateClient(string text, bool add);
        private delegate void EditNumberClient();
        private WriteBitacora _updateBitacora;
        private UpdateClient _updateClient;
        private EditNumberClient _editNumberClient;

        private List<string> _listUser = new List<string>();


        public FrmServer()
        {
            InitializeComponent();
            _updateBitacora = new WriteBitacora(WriteInLog);
            _updateClient = new UpdateClient(UpdateClients);
            _editNumberClient = new EditNumberClient(EditNumberClients);

            lblEstado.ForeColor = Color.Red;
            btnDisconnect.Enabled = false;
            btnDisconnect.BackColor = Color.White;
            btnConnect.BackColor = Color.Lime;

            _method = new Methods();
        }

        private void WriteInLog(string actionUser)
        {
            txtBitacora.AppendText(DateTime.Now.ToString() + " --> " + actionUser);
            txtBitacora.AppendText(Environment.NewLine);
        }

        private void UpdateClients(string user, bool add)
        {
            if (add)
            {
                lstConectados.Items.Add(user);
            }
            else
            {
                lstConectados.Items.Remove(user);
            }
        }

        private void EditNumberClients()
        {
            lblNumberClient.Text = _listUser.Count().ToString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            _listenerClient = new TcpListener(ip, 16830);
            _connected = true;

            _threadListenerClient = new Thread(new ThreadStart(ListenerClient));
            _threadListenerClient.Start();
            _threadListenerClient.IsBackground = true;

            lblEstado.Text = "Servidor en Línea";
            lblEstado.ForeColor = Color.Green;
            btnConnect.Enabled = false;
            btnConnect.BackColor = Color.White;
            btnDisconnect.Enabled = true;
            btnDisconnect.BackColor = Color.Red;



            txtBitacora.Invoke(_updateBitacora, new object[] { "Servidor Iniciado." });
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _connected = false;
            _listenerClient.Stop();
            _threadListenerClient.Interrupt();

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnDisconnect.BackColor = Color.White;

            btnConnect.BackColor = Color.Lime;


            txtBitacora.Invoke(_updateBitacora, new object[] { "Servidor Detenido." });
            txtBitacora.AppendText(Environment.NewLine);

            lblEstado.ForeColor = Color.Red;
            lblEstado.Text = "Desconectado";
        }

        private void ListenerClient()
        {
            try
            {
                _listenerClient.Start();
                while (_connected)
                {
                    TcpClient tcpClient = _listenerClient.AcceptTcpClient();

                    Thread threadNewClient = new Thread(new ParameterizedThreadStart(ComunicationClient));
                    threadNewClient.Start(tcpClient);

                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ComunicationClient(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            StreamReader reader = new StreamReader(tcpClient.GetStream());
            StreamWriter writer = new StreamWriter(tcpClient.GetStream());

            while (_connected)
            {
                try
                {
                    var msj = reader.ReadLine();
                    MessageSocket<object> messageSocket = JsonConvert.DeserializeObject<MessageSocket<object>>(msj);
                    SelectMethod(messageSocket.Method, msj, ref writer);
                }
                catch (Exception ex)
                {
                    break;
                }
            }
            tcpClient.Close();
        }
        private void SelectMethod(string method, string message, ref StreamWriter writer)
        {
            switch (method)
            {
                case "ConnectClient":
                    MessageSocket<DataBase> msjConnect = JsonConvert.DeserializeObject<MessageSocket<DataBase>>(message);
                    ConnectClient(msjConnect.Entity, ref writer);
                    break;

                case "DisconnectClient":
                    MessageSocket<string> msjDiscconect = JsonConvert.DeserializeObject<MessageSocket<string>>(message);
                    DisconnectClient(msjDiscconect.Entity);
                    break;

                case "GetTeacher":
                    MessageSocket<string> msjGetTeacher = JsonConvert.DeserializeObject<MessageSocket<string>>(message);
                    GetTeacher(msjGetTeacher.Entity, ref writer);
                    break;
                case "GetAllsStudents":
                    //MessageSocket<string> msjGetStudents = JsonConvert.DeserializeObject<MessageSocket<string>>(message);
                    GetAllsStudents(ref writer);
                    break;
                case "AddStudent":
                    MessageSocket<List<int>> msjAddStudent = JsonConvert.DeserializeObject<MessageSocket<List<int>>>(message);
                    AddStudent(msjAddStudent.Entity, ref writer);
                    break;
            }
        }

        private void AddStudent( List<int> data, ref StreamWriter writer)
        {
            try
            {
                //Teacher teacher = _method.GetTeachers().FirstOrDefault(teacher => teacher.Id == data[0]);
                //Student student = _method.GetStudents().FirstOrDefault(student => student.Id == data[1]);
                if (_method.AddStudentToTeacher(data[0], data[1]))
                {
                    writer.WriteLine(JsonConvert.SerializeObject("successful"));
                    writer.Flush();
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void GetAllsStudents(ref StreamWriter writer)
        {
            try
            {
                List<Student> students = new List<Student>();
                students = _method.GetStudents();
                writer.WriteLine(JsonConvert.SerializeObject(students));
                writer.Flush();

            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void GetTeacher(string username, ref StreamWriter writer)
        {
            try
            {
                Teacher teacher = _method.GetTeachers().FirstOrDefault(p => p.User == username);
                writer.WriteLine(JsonConvert.SerializeObject(teacher));
                writer.Flush();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }


        private void ConnectClient(DataBase dataBase, ref StreamWriter writer)
        {
            string user = dataBase.Username;
            string password = dataBase.Password;
            //Teacher teacher = new Teacher { Id = 1, User = "Ruben", Name = "Ruben", Pass = "123" };
            Teacher teacher = _method.GetTeachers().FirstOrDefault(p => p.User == user);

            if (!_method.TeacherExists(teacher.Id))
            {
                writer.WriteLine(JsonConvert.SerializeObject("El usuario no existe"));
                writer.Flush();

                txtBitacora.Invoke(_updateBitacora, new object[] { "Cliente " + user + " rechazado (no está registrado." });
                return;
            }
            else
            {
                if (password != teacher.Pass)
                {
                    writer.WriteLine(JsonConvert.SerializeObject("La contraseña no coincide con el usuario"));
                    writer.Flush();

                    txtBitacora.Invoke(_updateBitacora, new object[] { "Cliente " + user + " ingreso una contraseña incorrecta." });
                    return;
                }
                else
                {
                    if (_listUser.Contains(user))
                    {
                        writer.WriteLine(JsonConvert.SerializeObject("Usuario ya está conectado")); // Serializa lo que se le va a enviar al cliente
                        writer.Flush();

                        txtBitacora.Invoke(_updateBitacora, new object[] { "Cliente " + user + " Rechazado (intento volver a conectarse pero ya está conectado)" });
                        return;
                    }
                    else
                    {
                        _listUser.Add(user);

                        txtBitacora.Invoke(_updateBitacora, new object[] { user + " se conectó." });
                        lstConectados.Invoke(_updateClient, new object[] { user, true });

                        lblNumberClient.Invoke(_editNumberClient);

                        writer.WriteLine(JsonConvert.SerializeObject("Conectado"));
                        writer.Flush();
                    }
                }
            }

        }

        private void DisconnectClient(string username)
        {
            txtBitacora.Invoke(_updateBitacora, new object[] { username + " se desconectó." });
            lstConectados.Invoke(_updateClient, new object[] { username, false });

            _listUser.Remove(username); // Cuando se desconecta un cliente se elimina de la lista


            // Invoca el delegado que modifica el número de clientes
            lblNumberClient.Invoke(_editNumberClient);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
