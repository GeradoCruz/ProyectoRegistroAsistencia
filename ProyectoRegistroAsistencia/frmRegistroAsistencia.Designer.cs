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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroAsistencia));
            pnlSombra = new Panel();
            pnlBorde = new Panel();
            pnlFormulario = new Panel();
            lblTitulo = new Label();
            pcbRegistro = new PictureBox();
            lblClaveTrabajador = new Label();
            txtClaveTrabajador = new TextBox();
            btnRegistrar = new Button();
            lblAdministrador = new Label();
            pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRegistro).BeginInit();
            SuspendLayout();
            // 
            // pnlSombra
            // 
            pnlSombra.Anchor = AnchorStyles.None;
            pnlSombra.BackColor = Color.FromArgb(180, 184, 190);
            pnlSombra.Location = new Point(14, 19);
            pnlSombra.Name = "pnlSombra";
            pnlSombra.Size = new Size(394, 424);
            pnlSombra.TabIndex = 0;
            // 
            // pnlBorde
            // 
            pnlBorde.Anchor = AnchorStyles.None;
            pnlBorde.BackColor = Color.FromArgb(221, 225, 231);
            pnlBorde.Location = new Point(8, 13);
            pnlBorde.Name = "pnlBorde";
            pnlBorde.Size = new Size(394, 424);
            pnlBorde.TabIndex = 1;
            // 
            // pnlFormulario
            // 
            pnlFormulario.Anchor = AnchorStyles.None;
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.Controls.Add(lblTitulo);
            pnlFormulario.Controls.Add(pcbRegistro);
            pnlFormulario.Controls.Add(lblClaveTrabajador);
            pnlFormulario.Controls.Add(txtClaveTrabajador);
            pnlFormulario.Controls.Add(btnRegistrar);
            pnlFormulario.Controls.Add(lblAdministrador);
            pnlFormulario.Location = new Point(10, 15);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(390, 420);
            pnlFormulario.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(60, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(266, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Asistencia";
            // 
            // pcbRegistro
            // 
            pcbRegistro.Image = (Image)resources.GetObject("pcbRegistro.Image");
            pcbRegistro.Location = new Point(122, 56);
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
            lblClaveTrabajador.Location = new Point(39, 216);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(159, 21);
            lblClaveTrabajador.TabIndex = 2;
            lblClaveTrabajador.Text = "Clave de trabajador";
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            txtClaveTrabajador.Location = new Point(39, 249);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(318, 29);
            txtClaveTrabajador.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(43, 76, 140);
            btnRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(39, 302);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(318, 40);
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
            lblAdministrador.Location = new Point(25, 367);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(350, 20);
            lblAdministrador.TabIndex = 5;
            lblAdministrador.Text = "Presione F5 para ingresar al panel de administrador";
            // 
            // frmRegistroAsistencia
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(411, 450);
            Controls.Add(pnlFormulario);
            Controls.Add(pnlSombra);
            Controls.Add(pnlBorde);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRegistroAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffAsistence";
            WindowState = FormWindowState.Maximized;
            KeyDown += frmRegistroAsistencia_KeyDown;
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRegistro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSombra;
        private Panel pnlBorde;
        private Panel pnlFormulario;
        private Label lblTitulo;
        private PictureBox pcbRegistro;
        private Label lblClaveTrabajador;
        private TextBox txtClaveTrabajador;
        private Button btnRegistrar;
        private Label lblAdministrador;
    }
}
