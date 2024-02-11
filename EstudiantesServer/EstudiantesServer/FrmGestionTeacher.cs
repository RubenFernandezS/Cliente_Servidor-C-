using Estudiantes.Entidades;
using EstudiantesServer.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudiantesServer
{
    public partial class FrmGestionTeacher : Form, IContract
    {
        private Methods _methods;
        public FrmGestionTeacher()
        {
            InitializeComponent();
            _methods = new Methods();
        }

        private void FrmGestionTeacher_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Teacher teacher = new Teacher();
                teacher.Name = txtName.Text;
                teacher.Id = int.Parse(txtID.Text);
                teacher.User = txtUser.Text;
                teacher.Pass = txtPass.Text;

                string message = _methods.AddTeacher(teacher);
                if (message == "Profesor Agregado Exitosamente")
                {
                    LoadDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(message, "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ClearForm()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtPass2.Text = string.Empty;            
        }

        private void LoadDataGridView()
        {
            List<Teacher> teachers = _methods.GetTeachers();
            dgwTeacher.Rows.Clear();

            if (teachers != null && teachers.Count > 0)
            {
                foreach (Teacher teacher in teachers)
                {
                    dgwTeacher.Rows.Add(teacher.Id, teacher.Name, teacher.User, "Editar", "Eliminar");
                }
            }
        }

        #region Validations
        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Error: Ingrese el nombre.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Error: Ingrese la cédula.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtID.Text.Length < 9)
            {
                MessageBox.Show("Error: Id debe tener 9 caracteres.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_methods.TeacherExists(int.Parse(txtID.Text)))
            {
                MessageBox.Show("Error: Id ya está registrado.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_methods.TeacherUsernameExists(txtUser.Text))
            {
                MessageBox.Show("Error: Ese nombre de usuario no está disponible.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtUser.Text == string.Empty)
            {
                MessageBox.Show("Error: No ingreso el usuario.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPass.Text == string.Empty)
            {
                MessageBox.Show("Error: No ingreso la contraseña.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPass2.Text == string.Empty)
            {
                MessageBox.Show("Error: No ingreso la segunda vez la contraseña.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Error: Las contraseña no coincide.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        private void dgwTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Teacher> teachers = _methods.GetTeachers();

            int positionY = dgwTeacher.CurrentCell.ColumnIndex;
            int positionX = dgwTeacher.CurrentCell.RowIndex;
            if (teachers.Count > 0 && positionX < teachers.Count)
            {
                if (positionY == 3)
                {
                    FrmEditTeacher frm = new FrmEditTeacher();
                    frm.GetIndexTeacher(positionX);
                    frm.contract = this;
                    frm.Show();
                }
                if (positionY == 4)
                {
                    try
                    {
                        if (_methods.DeleteTeacher(positionX))
                        {
                            LoadDataGridView();
                            MessageBox.Show("Profesor Eliminado con Éxito.", "Eliminar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error: No se pudo eliminar el Profesor.", "Eliminar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message, "Eliminar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void Execute(string message)
        {
            if (message == "Edit")
            {
                LoadDataGridView();
            }
        }
    }
}
