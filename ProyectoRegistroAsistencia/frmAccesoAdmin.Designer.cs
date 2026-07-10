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
            lblAcceso = new Label();
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
            // lblAcceso
            // 
            lblAcceso.AutoSize = true;
            lblAcceso.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcceso.ForeColor = Color.FromArgb(108, 117, 125);
            lblAcceso.Location = new Point(102, 32);
            lblAcceso.Name = "lblAcceso";
            lblAcceso.Size = new Size(271, 32);
            lblAcceso.TabIndex = 0;
            lblAcceso.Text = "Acceso Administrativo";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(108, 117, 125);
            lblUsuario.Location = new Point(83, 116);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(73, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // pcbUsuario
            // 
            pcbUsuario.BackColor = Color.White;
            pcbUsuario.Image = (Image)resources.GetObject("pcbUsuario.Image");
            pcbUsuario.Location = new Point(83, 154);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(35, 28);
            pcbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuario.TabIndex = 2;
            pcbUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.ForeColor = Color.FromArgb(108, 117, 125);
            txtUsuario.Location = new Point(117, 154);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(296, 29);
            txtUsuario.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(108, 117, 125);
            lblPassword.Location = new Point(83, 216);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // pcbPassword
            // 
            pcbPassword.BackColor = Color.White;
            pcbPassword.Image = (Image)resources.GetObject("pcbPassword.Image");
            pcbPassword.Location = new Point(83, 258);
            pcbPassword.Name = "pcbPassword";
            pcbPassword.Size = new Size(35, 28);
            pcbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPassword.TabIndex = 5;
            pcbPassword.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.FromArgb(108, 117, 125);
            txtPassword.Location = new Point(117, 258);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(296, 29);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.FromArgb(43, 76, 140);
            btnInicioSesion.ForeColor = Color.White;
            btnInicioSesion.Location = new Point(80, 318);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(333, 40);
            btnInicioSesion.TabIndex = 7;
            btnInicioSesion.Text = "Iniciar Sesión";
            btnInicioSesion.UseVisualStyleBackColor = false;
            // 
            // lblCancelar
            // 
            lblCancelar.AutoSize = true;
            lblCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCancelar.ForeColor = Color.FromArgb(108, 117, 125);
            lblCancelar.Location = new Point(116, 390);
            lblCancelar.Name = "lblCancelar";
            lblCancelar.Size = new Size(238, 20);
            lblCancelar.TabIndex = 8;
            lblCancelar.Text = "Presione Esc para cancelar y volver";
            // 
            // frmAccesoAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(468, 473);
            Controls.Add(lblCancelar);
            Controls.Add(btnInicioSesion);
            Controls.Add(pcbPassword);
            Controls.Add(pcbUsuario);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblAcceso);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAccesoAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Staff Asistence";
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcceso;
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