namespace ProyectoRegistroAsistencia
{
    partial class frmRegistroAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroAsistencia));
            pnlFormulario = new Panel();
            groupBox1 = new GroupBox();
            pcbCamara = new PictureBox();
            lblTitulo = new Label();
            pcbRegistro = new PictureBox();
            lblClaveTrabajador = new Label();
            txtClaveTrabajador = new TextBox();
            btnRegistrar = new Button();
            lblAdministrador = new Label();
            tmrCamara = new System.Windows.Forms.Timer(components);
            pnlFormulario.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCamara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbRegistro).BeginInit();
            SuspendLayout();
            // 
            // pnlFormulario
            // 
            pnlFormulario.Anchor = AnchorStyles.None;
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.Controls.Add(groupBox1);
            pnlFormulario.Controls.Add(lblTitulo);
            pnlFormulario.Controls.Add(pcbRegistro);
            pnlFormulario.Controls.Add(lblClaveTrabajador);
            pnlFormulario.Controls.Add(txtClaveTrabajador);
            pnlFormulario.Controls.Add(btnRegistrar);
            pnlFormulario.Controls.Add(lblAdministrador);
            pnlFormulario.Location = new Point(21, 15);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(641, 430);
            pnlFormulario.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pcbCamara);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(108, 117, 125);
            groupBox1.Location = new Point(335, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 386);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Camara Activo";
            // 
            // pcbCamara
            // 
            pcbCamara.BackColor = Color.White;
            pcbCamara.BorderStyle = BorderStyle.FixedSingle;
            pcbCamara.Location = new Point(6, 28);
            pcbCamara.Name = "pcbCamara";
            pcbCamara.Size = new Size(281, 352);
            pcbCamara.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCamara.TabIndex = 8;
            pcbCamara.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(36, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(266, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Asistencia";
            // 
            // pcbRegistro
            // 
            pcbRegistro.Image = (Image)resources.GetObject("pcbRegistro.Image");
            pcbRegistro.Location = new Point(95, 85);
            pcbRegistro.Name = "pcbRegistro";
            pcbRegistro.Size = new Size(136, 139);
            pcbRegistro.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbRegistro.TabIndex = 1;
            pcbRegistro.TabStop = false;
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(34, 239);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(159, 21);
            lblClaveTrabajador.TabIndex = 2;
            lblClaveTrabajador.Text = "Clave de trabajador";
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            txtClaveTrabajador.Location = new Point(34, 272);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(270, 29);
            txtClaveTrabajador.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(43, 76, 140);
            btnRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(34, 316);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(270, 40);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdministrador.ForeColor = Color.FromArgb(108, 117, 125);
            lblAdministrador.Location = new Point(40, 371);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(257, 40);
            lblAdministrador.TabIndex = 5;
            lblAdministrador.Text = "Presione F5 para ingresar al panel de \r\nadministrador";
            lblAdministrador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrCamara
            // 
            tmrCamara.Enabled = true;
            tmrCamara.Interval = 40;
            tmrCamara.Tick += tmrCamara_Tick;
            // 
            // frmRegistroAsistencia
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(683, 460);
            Controls.Add(pnlFormulario);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRegistroAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffAsistence";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmRegistroAsistencia_FormClosing;
            KeyDown += frmRegistroAsistencia_KeyDown;
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbCamara).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbRegistro).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlFormulario;
        private Label lblTitulo;
        private PictureBox pcbRegistro;
        private Label lblClaveTrabajador;
        private TextBox txtClaveTrabajador;
        private Button btnRegistrar;
        private Label lblAdministrador;
        private System.Windows.Forms.Timer tmrCamara;
        private GroupBox groupBox1;
        private PictureBox pcbCamara;
    }
}
