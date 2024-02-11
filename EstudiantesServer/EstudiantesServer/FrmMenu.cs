using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EstudiantesServer
{
    public partial class FrmMenu : Form
    {
        FrmServer frmServer;
        FrmGestionTeacher frmTeacher;
        FrmGestionStudent frmStudent;
        private bool _menu = true;

        public FrmMenu()
        {
            InitializeComponent();
            frmServer = new FrmServer();
            frmTeacher = new FrmGestionTeacher();
            frmStudent = new FrmGestionStudent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (_menu)
            {
                pnlMenu.Width = 50;
                _menu = false;

                btnMenu.Width = 50;
                btnServer.Width = 50;
                btnTeacher.Width = 50;
                btnStudent.Width = 50;

                btnMenu.Text = string.Empty;
                btnServer.Text = string.Empty;
                btnTeacher.Text = string.Empty;
                btnStudent.Text = string.Empty;

                btnMenu.ImageAlign = ContentAlignment.MiddleCenter;
                btnServer.ImageAlign = ContentAlignment.MiddleCenter;
                btnTeacher.ImageAlign = ContentAlignment.MiddleCenter;
                btnStudent.ImageAlign = ContentAlignment.MiddleCenter;

                btnMenu.Padding = new Padding(0, 0, 0, 0);
                btnServer.Padding = new Padding(0, 0, 0, 0);
                btnTeacher.Padding = new Padding(0, 0, 0, 0);
                btnStudent.Padding = new Padding(0, 0, 0, 0);

            }
            else
            {
                pnlMenu.Width = 288;
                _menu = true;

                btnMenu.Text = "Menu";
                btnServer.Text = "Servidor";
                btnTeacher.Text = "Gestión de Profesores";
                btnStudent.Text = "Gestión de Estudiantes";

                btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
                btnServer.ImageAlign = ContentAlignment.MiddleLeft;
                btnTeacher.ImageAlign = ContentAlignment.MiddleLeft;
                btnStudent.ImageAlign = ContentAlignment.MiddleLeft;

                btnMenu.Padding = new Padding(9, 0, 0, 0);
                btnServer.Padding = new Padding(9, 0, 0, 0);
                btnTeacher.Padding = new Padding(9, 0, 0, 0);
                btnStudent.Padding = new Padding(9, 0, 0, 0);
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //pnlContent.Controls.Clear();

            frmServer.Dock = DockStyle.Fill;
            frmServer.TopLevel = false;

            pnlPrincipal.Controls.Add(frmServer);

            frmServer.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Show();
            pnlContent.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pnlContent.Show();
            pnlContent.Controls.Clear();

            frmTeacher.Dock = DockStyle.Fill;
            frmTeacher.TopLevel = false;

            pnlContent.Controls.Add(frmTeacher);

            pnlPrincipal.Hide();
            frmTeacher.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlContent.Show();
            pnlContent.Controls.Clear();

            frmStudent.Dock = DockStyle.Fill;
            frmStudent.TopLevel = false;

            pnlContent.Controls.Add(frmStudent);
            pnlPrincipal.Hide();
            frmStudent.Show();
        }
    }
}
