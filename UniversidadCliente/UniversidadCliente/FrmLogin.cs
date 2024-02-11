using Estudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversidadCliente
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(txtUsername.Text.Equals(string.Empty)))
            {
                if (!(txtPass.Text.Equals(string.Empty)))
                {
                    DataBase dataBase = new DataBase();
                    dataBase.Username = txtUsername.Text;
                    dataBase.Password = txtPass.Text;

                    string mensaje = RequestClient.Connect(dataBase);

                    switch (mensaje)
                    {
                        case "El usuario no existe":
                            MessageBox.Show("El usuario ingresado no está registrado", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;

                        case "La contraseña no coincide con el usuario":
                            MessageBox.Show("La contraseña no coincide con la del usuario", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;

                        case "Conectado":
                            string userName = txtUsername.Text;
                            FrmGestionStudent frm = new FrmGestionStudent();
                            frm.Get_UserNameTeacher(userName);
                            frm.Show();
                            this.Hide();

                            break;

                        case "Usuario ya está conectado":
                            MessageBox.Show("El usuario ingresado ya está conectado.", "Inicio sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;

                        case "No se puedo conectar con el servidor":
                            MessageBox.Show("No se pudo conectar con el servidor.", "Inicio sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default:
                            MessageBox.Show("Error al comunicarse con el servidor.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar la contraseña del profesor", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de usuario del profesor", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
