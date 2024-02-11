namespace EstudiantesServer
{
    partial class FrmEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditStudent));
            txtID = new MaskedTextBox();
            lblTitle = new Label();
            btnSave = new Button();
            dtpDate = new DateTimePicker();
            label4 = new Label();
            cbxGender = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(191, 158);
            txtID.Mask = "0-0000-0000";
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(215, 20);
            txtID.TabIndex = 21;
            txtID.TextAlign = HorizontalAlignment.Center;
            txtID.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(129, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(141, 38);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Datos de ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(175, 328);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(9, 0, 9, 0);
            btnSave.Size = new Size(171, 39);
            btnSave.TabIndex = 19;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top;
            dtpDate.CustomFormat = "yyyy/MM/dd";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(278, 256);
            dtpDate.MaxDate = new DateTime(2024, 1, 6, 0, 0, 0, 0);
            dtpDate.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(128, 27);
            dtpDate.TabIndex = 18;
            dtpDate.Value = new DateTime(2024, 1, 6, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(123, 261);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 17;
            label4.Text = "Fecha de Nacimiento";
            // 
            // cbxGender
            // 
            cbxGender.Anchor = AnchorStyles.Top;
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbxGender.Location = new Point(191, 203);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(215, 28);
            cbxGender.TabIndex = 16;
            cbxGender.Text = "Seleccione un Género";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(130, 158);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 15;
            label3.Text = "Cédula";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(128, 203);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 14;
            label2.Text = "Género";
            // 
            // txtName
            // 
            txtName.AccessibleDescription = "";
            txtName.Anchor = AnchorStyles.Top;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(191, 102);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre del Estudiante";
            txtName.Size = new Size(215, 20);
            txtName.TabIndex = 13;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(121, 102);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbxGender);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(txtID);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 434);
            panel1.TabIndex = 22;
            // 
            // FrmEditStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 434);
            Controls.Add(panel1);
            Name = "FrmEditStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Estudiante";
            Load += FrmEditStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox txtID;
        private Label lblTitle;
        private Button btnSave;
        private DateTimePicker dtpDate;
        private Label label4;
        private ComboBox cbxGender;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Panel panel1;
    }
}