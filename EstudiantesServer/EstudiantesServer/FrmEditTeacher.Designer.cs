namespace EstudiantesServer
{
    partial class FrmEditTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditTeacher));
            panel1 = new Panel();
            lblTitle = new Label();
            txtPass2 = new TextBox();
            label6 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            txtUser = new TextBox();
            txtID = new MaskedTextBox();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(txtPass2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 454);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblTitle.Location = new Point(128, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(141, 38);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "Datos de ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPass2
            // 
            txtPass2.AccessibleDescription = "";
            txtPass2.Anchor = AnchorStyles.Top;
            txtPass2.BorderStyle = BorderStyle.None;
            txtPass2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass2.Location = new Point(194, 320);
            txtPass2.Name = "txtPass2";
            txtPass2.PasswordChar = '*';
            txtPass2.PlaceholderText = "Contraseña";
            txtPass2.RightToLeft = RightToLeft.No;
            txtPass2.ShortcutsEnabled = false;
            txtPass2.Size = new Size(204, 20);
            txtPass2.TabIndex = 28;
            txtPass2.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(53, 320);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 27;
            label6.Text = "Repetir Contraseña";
            label6.UseMnemonic = false;
            // 
            // txtPass
            // 
            txtPass.AccessibleDescription = "";
            txtPass.Anchor = AnchorStyles.Top;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(194, 269);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Contraseña";
            txtPass.RightToLeft = RightToLeft.No;
            txtPass.ShortcutsEnabled = false;
            txtPass.Size = new Size(204, 20);
            txtPass.TabIndex = 26;
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(105, 269);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 25;
            label4.Text = "Contraseña";
            label4.UseMnemonic = false;
            // 
            // txtUser
            // 
            txtUser.AccessibleDescription = "";
            txtUser.Anchor = AnchorStyles.Top;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(194, 213);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(204, 20);
            txtUser.TabIndex = 24;
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(194, 156);
            txtID.Mask = "0-0000-0000";
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(204, 20);
            txtID.TabIndex = 23;
            txtID.TextAlign = HorizontalAlignment.Center;
            txtID.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(161, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(9, 0, 9, 0);
            btnAdd.Size = new Size(171, 39);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Guardar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(124, 155);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 20;
            label3.Text = "Cédula";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(129, 213);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 19;
            label2.Text = "Usuario";
            // 
            // txtName
            // 
            txtName.AccessibleDescription = "";
            txtName.Anchor = AnchorStyles.Top;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(194, 100);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre del Profesor";
            txtName.Size = new Size(204, 20);
            txtName.TabIndex = 18;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(124, 100);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // FrmEditTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 454);
            Controls.Add(panel1);
            Name = "FrmEditTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Profesor";
            Load += FrmEditTeacher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private TextBox txtPass2;
        private Label label6;
        private TextBox txtPass;
        private Label label4;
        private TextBox txtUser;
        private MaskedTextBox txtID;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}