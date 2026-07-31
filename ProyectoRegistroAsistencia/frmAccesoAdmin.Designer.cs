namespace ProyectoRegistroAsistencia
{
    partial class frmAccesoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesoAdmin));
            lblTitulo = new Label();
            lblUsuario = new Label();
            pcbUsuario = new PictureBox();
            txtUsuario = new TextBox();
            lblPassword = new Label();
            pcbPassword = new PictureBox();
            txtPassword = new TextBox();
            btnInicioSesion = new Button();
            lblCancelar = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPassword).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(25, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(330, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Acceso Administrativo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(108, 117, 125);
            lblUsuario.Location = new Point(25, 80);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(73, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pcbUsuario
            // 
            pcbUsuario.BackColor = Color.White;
            pcbUsuario.Image = (Image)resources.GetObject("pcbUsuario.Image");
            pcbUsuario.Location = new Point(25, 105);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(35, 28);
            pcbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuario.TabIndex = 2;
            pcbUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(59, 105);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(296, 29);
            txtUsuario.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(108, 117, 125);
            lblPassword.Location = new Point(25, 156);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pcbPassword
            // 
            pcbPassword.BackColor = Color.White;
            pcbPassword.Image = (Image)resources.GetObject("pcbPassword.Image");
            pcbPassword.Location = new Point(25, 180);
            pcbPassword.Name = "pcbPassword";
            pcbPassword.Size = new Size(35, 28);
            pcbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPassword.TabIndex = 5;
            pcbPassword.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(59, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(296, 29);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.FromArgb(43, 76, 140);
            btnInicioSesion.ForeColor = Color.White;
            btnInicioSesion.Location = new Point(22, 236);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(333, 40);
            btnInicioSesion.TabIndex = 7;
            btnInicioSesion.Text = "Iniciar Sesión";
            btnInicioSesion.UseVisualStyleBackColor = false;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // lblCancelar
            // 
            lblCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCancelar.ForeColor = Color.FromArgb(108, 117, 125);
            lblCancelar.Location = new Point(25, 303);
            lblCancelar.Name = "lblCancelar";
            lblCancelar.Size = new Size(330, 20);
            lblCancelar.TabIndex = 8;
            lblCancelar.Text = "Presione Esc para cancelar y volver";
            lblCancelar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAccesoAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(390, 357);
            Controls.Add(lblCancelar);
            Controls.Add(btnInicioSesion);
            Controls.Add(pcbPassword);
            Controls.Add(pcbUsuario);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAccesoAdmin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Asistence";
            KeyDown += frmAccesoAdmin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private PictureBox pcbUsuario;
        private TextBox txtUsuario;
        private Label lblPassword;
        private PictureBox pcbPassword;
        private TextBox txtPassword;
        private Button btnInicioSesion;
        private Label lblCancelar;
    }
}
