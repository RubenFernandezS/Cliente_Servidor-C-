namespace EstudiantesServer
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            pnlMenu = new Panel();
            pnlLine = new Panel();
            btnServer = new Button();
            btnStudent = new Button();
            btnTeacher = new Button();
            btnMenu = new Button();
            pnlContent = new Panel();
            pnlPrincipal = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DimGray;
            pnlMenu.Controls.Add(pnlLine);
            pnlMenu.Controls.Add(btnServer);
            pnlMenu.Controls.Add(btnStudent);
            pnlMenu.Controls.Add(btnTeacher);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 653);
            pnlMenu.TabIndex = 0;
            // 
            // pnlLine
            // 
            pnlLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLine.BackColor = SystemColors.AppWorkspace;
            pnlLine.Location = new Point(0, 38);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(229, 4);
            pnlLine.TabIndex = 5;
            // 
            // btnServer
            // 
            btnServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnServer.BackColor = SystemColors.ControlDarkDark;
            btnServer.FlatAppearance.BorderSize = 0;
            btnServer.FlatStyle = FlatStyle.Flat;
            btnServer.ForeColor = Color.WhiteSmoke;
            btnServer.Image = (Image)resources.GetObject("btnServer.Image");
            btnServer.ImageAlign = ContentAlignment.MiddleLeft;
            btnServer.Location = new Point(0, 48);
            btnServer.Name = "btnServer";
            btnServer.Padding = new Padding(5, 0, 0, 0);
            btnServer.Size = new Size(230, 32);
            btnServer.TabIndex = 4;
            btnServer.Text = "Servidor";
            btnServer.UseVisualStyleBackColor = false;
            btnServer.Click += btnServer_Click;
            // 
            // btnStudent
            // 
            btnStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStudent.BackColor = SystemColors.ControlDarkDark;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.ForeColor = Color.WhiteSmoke;
            btnStudent.Image = (Image)resources.GetObject("btnStudent.Image");
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(0, 124);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(5, 0, 0, 0);
            btnStudent.Size = new Size(230, 32);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Gestión de Estudiantes";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTeacher.BackColor = SystemColors.ControlDarkDark;
            btnTeacher.FlatAppearance.BorderSize = 0;
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.ForeColor = Color.WhiteSmoke;
            btnTeacher.Image = (Image)resources.GetObject("btnTeacher.Image");
            btnTeacher.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeacher.Location = new Point(0, 86);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Padding = new Padding(5, 0, 0, 0);
            btnTeacher.Size = new Size(230, 32);
            btnTeacher.TabIndex = 2;
            btnTeacher.Text = "Gestión de Profesores";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMenu.BackColor = SystemColors.ControlDarkDark;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.WhiteSmoke;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(5, 0, 0, 0);
            btnMenu.Size = new Size(230, 32);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.ButtonHighlight;
            pnlContent.BackgroundImageLayout = ImageLayout.Zoom;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(230, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(952, 653);
            pnlContent.TabIndex = 1;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.Gray;
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(230, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(952, 653);
            pnlPrincipal.TabIndex = 0;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(pnlPrincipal);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servidor";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlContent;
        private Button btnMenu;
        private Button btnStudent;
        private Button btnTeacher;
        private Button btnServer;
        private Panel pnlPrincipal;
        private Panel pnlLine;
    }
}