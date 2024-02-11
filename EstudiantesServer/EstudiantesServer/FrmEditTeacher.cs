using Estudiantes.Entidades;
using EstudiantesServer.Datos;

namespace EstudiantesServer
{
    public partial class FrmEditTeacher : Form
    {
        private int _index;
        private Methods _methods;
        private List<Teacher> _teachers;
        private Teacher _teacher;

        public IContract contract { get; set; }

        public FrmEditTeacher()
        {
            InitializeComponent();
            _methods = new Methods();
            _teachers = new List<Teacher>();
            _teacher = new Teacher();
        }

        public void GetIndexTeacher(int index)
        {
            this._index = index;
        }

        private void FrmEditTeacher_Load(object sender, EventArgs e)
        {
            _teachers = _methods.GetTeachers();
            _teacher = _teachers[_index];

            lblTitle.Text += _teacher.Name;
            txtName.Text = _teacher.Name;
            txtID.Text = _teacher.Id.ToString();
            txtUser.Text = _teacher.User;
            txtPass.Text = _teacher.Pass;
            txtPass2.Text = _teacher.Pass;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    GetTeacherNew();
                    _methods.EditTeacher(_teacher);

                    contract.Execute("Edit");
                    MessageBox.Show("Profesor Editado con Éxito", "Editar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Editar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetTeacherNew()
        {
            _teacher.Name = txtName.Text;
            _teacher.User = txtUser.Text;
            _teacher.Pass = txtPass.Text;
        }

        #region Validations
        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Error: Ingrese el nombre.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtUser.Text == string.Empty)
            {
                MessageBox.Show("Error: No ingreso el usuario.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_methods.TeacherUsernameExists(txtUser.Text))
            {
                List<Teacher> lst = new List<Teacher>(_methods.GetTeachers());
                lst.Remove(_teacher);
                
                if (lst.Count(t => t.User == txtUser.Text) > 0)
                {
                    MessageBox.Show("Error: Ese nombre de usuario no está disponible.", "Agregar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }                
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
    }
}
