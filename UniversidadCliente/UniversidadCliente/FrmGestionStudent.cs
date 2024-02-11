using Estudiantes.Entidades;

namespace UniversidadCliente
{
    public partial class FrmGestionStudent : Form
    {
        private string userName = "";
        private Teacher teacher;
        private List<Student> students;

        public FrmGestionStudent()
        {
            InitializeComponent();
            teacher = new Teacher();
            students = new List<Student>();
        }

        public void Get_UserNameTeacher(string userName)
        {
            this.userName = userName;
        }

        private void FrmGestionStudent_Load(object sender, EventArgs e)
        {
            teacher = RequestClient.GetTeacher(userName);
            lblProfesor.Text = teacher.Name;
            students = teacher.Students;

            LoadDataGridView();

            List<Student> allStudents = RequestClient.GetAllsStudents();

            if (allStudents.Count > 0)
            {
                cbxStudents.DataSource = allStudents;
                cbxStudents.DisplayMember = "Name";
                cbxStudents.ValueMember = "Id";
            }
        }

        private void FrmGestionStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            RequestClient.Disconnect(userName);
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = (Student)cbxStudents.SelectedItem;

            var data = new List<int>();
            data.Add(teacher.Id);
            data.Add(student.Id);

            if (teacher.Students.Find(s => s.Id == student.Id) == null)
            {
                if (RequestClient.AddStudent(data))
                {
                    students.Add(student);
                    LoadDataGridView();
                    MessageBox.Show("Estudiante Agregado con Éxito.", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("El Estudiante ya está Agregado.", "Agregar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            RequestClient.Disconnect(userName);
            Application.Exit();
        }

        private void LoadDataGridView()
        {
            dgvStudents.Rows.Clear();

            if (students != null && students.Count > 0)
            {
                foreach (Student student in students)
                {
                    dgvStudents.Rows.Add(student.Id, student.Name, student.Gender, student.BirthDate.ToShortDateString());
                }
            }
        }
    }
}
