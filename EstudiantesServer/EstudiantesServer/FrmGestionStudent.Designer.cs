namespace EstudiantesServer
{
    partial class FrmGestionStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionStudent));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlContent = new Panel();
            txtID = new MaskedTextBox();
            btnAdd = new Button();
            dtpDate = new DateTimePicker();
            label4 = new Label();
            cbxGender = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            dgwStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewButtonColumn();
            label1 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwStudent).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = SystemColors.ControlLight;
            pnlContent.Controls.Add(txtID);
            pnlContent.Controls.Add(btnAdd);
            pnlContent.Controls.Add(dtpDate);
            pnlContent.Controls.Add(label4);
            pnlContent.Controls.Add(cbxGender);
            pnlContent.Controls.Add(label3);
            pnlContent.Controls.Add(label2);
            pnlContent.Controls.Add(txtName);
            pnlContent.Controls.Add(dgwStudent);
            pnlContent.Controls.Add(label1);
            pnlContent.Location = new Point(0, 35);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(952, 624);
            pnlContent.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(196, 98);
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
            btnAdd.Location = new Point(391, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(9, 0, 9, 0);
            btnAdd.Size = new Size(171, 39);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top;
            dtpDate.CustomFormat = "yyyy/MM/dd";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(616, 98);
            dtpDate.MaxDate = new DateTime(2024, 1, 6, 0, 0, 0, 0);
            dtpDate.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(204, 27);
            dtpDate.TabIndex = 8;
            dtpDate.Value = new DateTime(2024, 1, 6, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(443, 98);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Nacimiento";
            // 
            // cbxGender
            // 
            cbxGender.Anchor = AnchorStyles.Top;
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbxGender.Location = new Point(616, 42);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(204, 28);
            cbxGender.TabIndex = 6;
            cbxGender.Text = "Seleccione un Género";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(126, 98);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Cédula";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(535, 42);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Género";
            // 
            // txtName
            // 
            txtName.AccessibleDescription = "";
            txtName.Anchor = AnchorStyles.Top;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(196, 42);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre del Estudiante";
            txtName.Size = new Size(204, 20);
            txtName.TabIndex = 2;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // dgwStudent
            // 
            dgwStudent.AllowUserToAddRows = false;
            dgwStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgwStudent.Location = new Point(13, 231);
            dgwStudent.MultiSelect = false;
            dgwStudent.Name = "dgwStudent";
            dgwStudent.RowHeadersWidth = 51;
            dgwStudent.RowTemplate.Height = 29;
            dgwStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwStudent.Size = new Size(928, 375);
            dgwStudent.TabIndex = 0;
            dgwStudent.CellClick += dgwStudent_CellClick;
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
            Column3.HeaderText = "Género";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Fecha de Nacimiento";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
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
            label1.Location = new Point(126, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.DimGray;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(335, 0);
            label5.Name = "label5";
            label5.Size = new Size(287, 38);
            label5.TabIndex = 10;
            label5.Text = "Datos del Estudiante";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 38);
            panel1.TabIndex = 1;
            // 
            // FrmGestionStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 653);
            Controls.Add(panel1);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionStudent";
            Text = "FrmGestionStudent";
            Activated += FrmGestionStudent_Activated;
            Load += FrmGestionStudent_Load;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private Label label1;
        private Panel panel1;
        private DataGridView dgwStudent;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpDate;
        private Label label4;
        private ComboBox cbxGender;
        private Button btnAdd;
        private Label label5;
        private MaskedTextBox txtID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column6;
    }
}