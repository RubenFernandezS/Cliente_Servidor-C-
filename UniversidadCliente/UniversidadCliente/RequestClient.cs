using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Estudiantes.Entidades;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UniversidadCliente
{
    

    public class RequestClient
    {
        private static IPAddress _ipServer;
        private static TcpClient _tcpClient;
        private static IPEndPoint _serverEndPoint;
        private static StreamWriter _writer;
        private static StreamReader _reader;

        public static string Connect(DataBase dataBase)
        {
            string msj;
            try
            {
                _ipServer = IPAddress.Parse("127.0.0.1");
                _serverEndPoint = new IPEndPoint(_ipServer, 16830);
                _tcpClient = new TcpClient();
                _tcpClient.Connect(_serverEndPoint);

                var messageConnect = new MessageSocket<DataBase> { Method = "ConnectClient", Entity = dataBase };

                _writer = new StreamWriter(_tcpClient.GetStream());
                _writer.WriteLine(JsonConvert.SerializeObject(messageConnect));
                _writer.Flush();

                _reader = new StreamReader(_tcpClient.GetStream());
                var message = _reader.ReadLine();

                msj = JsonConvert.DeserializeObject<string>(message);
            }
            catch (Exception ex)
            {
                return "No se puede conectar con el servidor";
            }
            return msj;
        }

        public static void Disconnect(string username)
        {
            try
            {
                var messageDisconnect = new MessageSocket<string> { Method = "DisconnectClient", Entity = username };

                _writer.WriteLine(JsonConvert.SerializeObject(messageDisconnect));
                _writer.Flush();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }    
            _tcpClient.Close();
        }

        public static bool AddStudent(List<int> data)
        {
            try
            {
                var message = new MessageSocket<List<int>> { Method = "AddStudent", Entity = data };

                _writer.WriteLine(JsonConvert.SerializeObject(message));
                _writer.Flush();

                var msj = _reader.ReadLine();
                string response = JsonConvert.DeserializeObject<string>(msj);

                return response == "successful";
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
                return false;
            }
        }

        public static List<Student> GetAllsStudents()
        {
            var students = new List<Student>();
            try
            {
                
                MessageSocket<string> messageGetStudends = new MessageSocket<string> { Method = "GetAllsStudents", Entity = "" };
                _writer.WriteLine(JsonConvert.SerializeObject(messageGetStudends));
                _writer.Flush();

                var message = _reader.ReadLine();
                students = JsonConvert.DeserializeObject<List<Student>>(message);
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return students;

        }

        public static Teacher GetTeacher(string username)
        {
            try
            {
                var teacher = new Teacher();
                MessageSocket<string> messageGetTeacher = new MessageSocket<string> { Method = "GetTeacher", Entity = username };
                _writer.WriteLine(JsonConvert.SerializeObject(messageGetTeacher));
                _writer.Flush();

                _reader = new StreamReader(_tcpClient.GetStream());
                var message = _reader.ReadLine();

                teacher = JsonConvert.DeserializeObject<Teacher>(message);
                return teacher;

            } catch (Exception ex)
            {
                return null;
            }  
        }

    }
}
