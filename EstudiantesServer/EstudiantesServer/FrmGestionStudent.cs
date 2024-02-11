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
    public partial class FrmGestionStudent : Form, IContract
    {
        private Methods _methods;

        public FrmGestionStudent()
        {
            InitializeComponent();
            _methods = new Methods();
        }

        private void FrmGestionStudent_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string gender = cbxGender.SelectedIndex == 0 ? "Masculino" : cbxGender.SelectedIndex == 1 ? "Femenino" : "";

                Student newStudent = new Student();
                newStudent.Id = int.Parse(txtID.Text);
                newStudent.Name = txtName.Text;
                newStudent.Gender = gender;
                newStudent.BirthDate = dtpDate.Value;

                string message = _methods.AddStudent(newStudent);
                if (message == "Estudiante Agregado Exitosamente")
                {
                    LoadDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(message, "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearForm()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            cbxGender.SelectedIndex = -1;
            dtpDate.Value = new DateTime(1990, 1, 1);
        }

        private void LoadDataGridView()
        {
            List<Student> students = _methods.GetStudents();
            dgwStudent.Rows.Clear();

            if (students != null && students.Count > 0)
            {
                foreach (Student student in students)
                {
                    dgwStudent.Rows.Add(student.Id, student.Name, student.Gender, student.BirthDate.ToShortDateString(), "Editar", "Eliminar");
                }
            }
        }

        private void dgwStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Student> students = _methods.GetStudents();

            int positionY = dgwStudent.CurrentCell.ColumnIndex;
            int positionX = dgwStudent.CurrentCell.RowIndex;
            if (students.Count > 0 && positionX < students.Count)
            {
                if (positionY == 4)
                {
                    FrmEditStudent frm = new FrmEditStudent();
                    frm.GetIndexStudent(positionX);
                    frm.contract = this;
                    frm.Show();
                }
                if (positionY == 5)
                {
                    try
                    {
                        if (_methods.DeleteStudent(positionX))
                        {
                            LoadDataGridView();
                            MessageBox.Show("Estudiante Eliminado con Éxito.", "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error: No se pudo eliminar el estudiante.", "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message, "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }

        }

        private void FrmGestionStudent_Activated(object sender, EventArgs e)
        {
            LoadDataGridView();
        }


        #region Validations
        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Error: Ingrese el nombre.", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Error: Ingrese la cédula.", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtID.Text.Length < 9)
            {
                MessageBox.Show("Error: Id debe tener 9 caracteres.", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_methods.StudentExists(int.Parse(txtID.Text)))
            {
                MessageBox.Show("Error: Id ya está registrado.", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Error: No selecciono el género.", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        public void Execute(string message)
        {
            if (message == "Edit")
            {
                LoadDataGridView();
            }
        }
    }
}
