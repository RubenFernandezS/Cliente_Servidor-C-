namespace EstudiantesServer
{
    partial class FrmGestionTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionTeacher));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            pnlContent = new Panel();
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
            dgwTeacher = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewButtonColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwTeacher).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 38);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(330, 0);
            label5.Name = "label5";
            label5.Size = new Size(260, 38);
            label5.TabIndex = 10;
            label5.Text = "Datos del Profesor";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = SystemColors.ControlLight;
            pnlContent.Controls.Add(txtPass2);
            pnlContent.Controls.Add(label6);
            pnlContent.Controls.Add(txtPass);
            pnlContent.Controls.Add(label4);
            pnlContent.Controls.Add(txtUser);
            pnlContent.Controls.Add(txtID);
            pnlContent.Controls.Add(btnAdd);
            pnlContent.Controls.Add(label3);
            pnlContent.Controls.Add(label2);
            pnlContent.Controls.Add(txtName);
            pnlContent.Controls.Add(dgwTeacher);
            pnlContent.Controls.Add(label1);
            pnlContent.Location = new Point(0, 33);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(952, 620);
            pnlContent.TabIndex = 2;
            // 
            // txtPass2
            // 
            txtPass2.AccessibleDescription = "";
            txtPass2.Anchor = AnchorStyles.Top;
            txtPass2.BorderStyle = BorderStyle.None;
            txtPass2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass2.Location = new Point(563, 142);
            txtPass2.Name = "txtPass2";
            txtPass2.PasswordChar = '*';
            txtPass2.PlaceholderText = "Contraseña";
            txtPass2.RightToLeft = RightToLeft.No;
            txtPass2.ShortcutsEnabled = false;
            txtPass2.Size = new Size(204, 20);
            txtPass2.TabIndex = 16;
            txtPass2.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(422, 142);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 15;
            label6.Text = "Repetir Contraseña";
            label6.UseMnemonic = false;
            // 
            // txtPass
            // 
            txtPass.AccessibleDescription = "";
            txtPass.Anchor = AnchorStyles.Top;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(563, 91);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Contraseña";
            txtPass.RightToLeft = RightToLeft.No;
            txtPass.ShortcutsEnabled = false;
            txtPass.Size = new Size(204, 20);
            txtPass.TabIndex = 14;
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(474, 91);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 13;
            label4.Text = "Contraseña";
            label4.UseMnemonic = false;
            // 
            // txtUser
            // 
            txtUser.AccessibleDescription = "";
            txtUser.Anchor = AnchorStyles.Top;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(563, 35);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(204, 20);
            txtUser.TabIndex = 12;
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(248, 91);
            txtID.Mask = "0-0000-0000";
            txtID.Name = "txtID";
            txtID.Size = new Size(204, 20);
            txtID.TabIndex = 11;
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
            btnAdd.Location = new Point(389, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(9, 0, 9, 0);
            btnAdd.Size = new Size(171, 39);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(178, 90);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Cédula";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(498, 35);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // txtName
            // 
            txtName.AccessibleDescription = "";
            txtName.Anchor = AnchorStyles.Top;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(248, 35);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre del Profesor";
            txtName.Size = new Size(204, 20);
            txtName.TabIndex = 2;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // dgwTeacher
            // 
            dgwTeacher.AllowUserToAddRows = false;
            dgwTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTeacher.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column6 });
            dgwTeacher.Location = new Point(13, 249);
            dgwTeacher.MultiSelect = false;
            dgwTeacher.Name = "dgwTeacher";
            dgwTeacher.RowHeadersWidth = 51;
            dgwTeacher.RowTemplate.Height = 29;
            dgwTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwTeacher.Size = new Size(928, 357);
            dgwTeacher.TabIndex = 0;
            dgwTeacher.CellClick += dgwTeacher_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Usuario";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Lime;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LimeGreen;
            Column5.DefaultCellStyle = dataGridViewCellStyle1;
            Column5.FlatStyle = FlatStyle.Popup;
            Column5.HeaderText = "";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.False;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Text = "Editar";
            Column5.Width = 125;
            // 
            // Column6
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.OrangeRed;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.FlatStyle = FlatStyle.Popup;
            Column6.HeaderText = "";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Resizable = DataGridViewTriState.False;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.Width = 125;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(178, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // FrmGestionTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(952, 653);
            Controls.Add(panel1);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionTeacher";
            Text = "Gestion de Profesores";
            Load += FrmGestionTeacher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlContent;
        private MaskedTextBox txtID;
        private Label label5;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private DataGridView dgwTeacher;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPass2;
        private Label label6;
        private TextBox txtPass;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column6;
    }
}