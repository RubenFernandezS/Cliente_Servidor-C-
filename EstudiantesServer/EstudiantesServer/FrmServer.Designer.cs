namespace EstudiantesServer
{
    partial class FrmServer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            grpConectados = new GroupBox();
            lstConectados = new ListBox();
            grpBitacora = new GroupBox();
            txtBitacora = new TextBox();
            grpCantClient = new GroupBox();
            lblNumberClient = new Label();
            label1 = new Label();
            lblEstado = new Label();
            btnConnect = new Button();
            btnDisconnect = new Button();
            lblHora = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            grpConectados.SuspendLayout();
            grpBitacora.SuspendLayout();
            grpCantClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grpConectados
            // 
            grpConectados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpConectados.Controls.Add(lstConectados);
            grpConectados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpConectados.Location = new Point(18, 174);
            grpConectados.Name = "grpConectados";
            grpConectados.Size = new Size(421, 360);
            grpConectados.TabIndex = 1;
            grpConectados.TabStop = false;
            grpConectados.Text = "Clientes Conectados";
            // 
            // lstConectados
            // 
            lstConectados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstConectados.FormattingEnabled = true;
            lstConectados.ItemHeight = 28;
            lstConectados.Location = new Point(18, 43);
            lstConectados.Name = "lstConectados";
            lstConectados.Size = new Size(386, 284);
            lstConectados.TabIndex = 0;
            // 
            // grpBitacora
            // 
            grpBitacora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBitacora.Controls.Add(txtBitacora);
            grpBitacora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpBitacora.Location = new Point(461, 174);
            grpBitacora.Name = "grpBitacora";
            grpBitacora.Size = new Size(479, 360);
            grpBitacora.TabIndex = 2;
            grpBitacora.TabStop = false;
            grpBitacora.Text = "Bitácora";
            // 
            // txtBitacora
            // 
            txtBitacora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBitacora.Location = new Point(22, 43);
            txtBitacora.Multiline = true;
            txtBitacora.Name = "txtBitacora";
            txtBitacora.Size = new Size(440, 298);
            txtBitacora.TabIndex = 0;
            // 
            // grpCantClient
            // 
            grpCantClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpCantClient.Controls.Add(lblNumberClient);
            grpCantClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpCantClient.Location = new Point(18, 540);
            grpCantClient.Name = "grpCantClient";
            grpCantClient.Size = new Size(922, 101);
            grpCantClient.TabIndex = 3;
            grpCantClient.TabStop = false;
            grpCantClient.Text = "Cantidad de Clientes Conectados";
            // 
            // lblNumberClient
            // 
            lblNumberClient.AutoSize = true;
            lblNumberClient.Location = new Point(18, 41);
            lblNumberClient.Name = "lblNumberClient";
            lblNumberClient.Size = new Size(23, 28);
            lblNumberClient.TabIndex = 0;
            lblNumberClient.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 4;
            label1.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.White;
            lblEstado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.Red;
            lblEstado.Location = new Point(115, 23);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(164, 31);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Desconectado";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(0, 192, 0);
            btnConnect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Image = (Image)resources.GetObject("btnConnect.Image");
            btnConnect.ImageAlign = ContentAlignment.MiddleLeft;
            btnConnect.Location = new Point(18, 76);
            btnConnect.Name = "btnConnect";
            btnConnect.Padding = new Padding(9, 0, 0, 0);
            btnConnect.Size = new Size(189, 45);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += button1_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.Red;
            btnDisconnect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisconnect.Image = (Image)resources.GetObject("btnDisconnect.Image");
            btnDisconnect.ImageAlign = ContentAlignment.MiddleLeft;
            btnDisconnect.Location = new Point(213, 76);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Padding = new Padding(9, 0, 0, 0);
            btnDisconnect.Size = new Size(189, 45);
            btnDisconnect.TabIndex = 7;
            btnDisconnect.Text = "Desconectar";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(591, 12);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(81, 38);
            lblHora.TabIndex = 8;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(591, 50);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(92, 38);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "Fecha";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.fondo;
            pictureBox1.Location = new Point(794, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(btnDisconnect);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 147);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblHora);
            panel2.Controls.Add(lblFecha);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(grpConectados);
            panel2.Controls.Add(grpBitacora);
            panel2.Controls.Add(grpCantClient);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 653);
            panel2.TabIndex = 0;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 653);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmServer";
            Text = "FrmMenu";
            grpConectados.ResumeLayout(false);
            grpBitacora.ResumeLayout(false);
            grpBitacora.PerformLayout();
            grpCantClient.ResumeLayout(false);
            grpCantClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpConectados;
        private GroupBox grpBitacora;
        private GroupBox grpCantClient;
        private Label label1;
        private Label lblEstado;
        private Button btnConnect;
        private Button btnDisconnect;
        private ListBox lstConectados;
        private TextBox txtBitacora;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private Label lblNumberClient;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Panel panel2;
    }
}