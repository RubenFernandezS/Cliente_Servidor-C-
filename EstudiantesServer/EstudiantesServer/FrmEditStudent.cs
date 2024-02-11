using Estudiantes.Entidades;
using EstudiantesServer.Datos;

namespace EstudiantesServer
{
    public partial class FrmEditStudent : Form
    {
        private int _index;
        private Methods _methods;
        private List<Student> _students;
        private Student _student;

        public IContract contract { get; set; }

        public FrmEditStudent()
        {
            InitializeComponent();
            _methods = new Methods();
            _students = new List<Student>();
            _student = new Student();
        }

        public void GetIndexStudent(int index)
        {
            this._index = index;
        }

        private void FrmEditStudent_Load(object sender, EventArgs e)
        {
            _students = _methods.GetStudents();
            _student = _students[_index];

            lblTitle.Text += _student.Name;
            txtName.Text = _student.Name;
            txtID.Text = _student.Id.ToString();
            cbxGender.SelectedIndex = _student.Gender == "Masculino" ? 0 : 1;
            dtpDate.Value = _student.BirthDate;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    GetStudentNew();
                    _methods.EditStudent(_student);

                    contract.Execute("Edit");
                    MessageBox.Show("Estudiante Editado con Éxito", "Editar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Editar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GetStudentNew()
        {
            _student.Name = txtName.Text;
            _student.Gender = cbxGender.SelectedIndex == 0 ? "Masculino" : "Femenino";
            _student.BirthDate = dtpDate.Value;
        }

        #region Validations
        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Error: Ingrese el nombre.", "Editar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxGender.SelectedIndex != 0 || cbxGender.SelectedIndex != 1)
            {
                MessageBox.Show("Error: No selecciono el género.", "Editar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

    }
}
