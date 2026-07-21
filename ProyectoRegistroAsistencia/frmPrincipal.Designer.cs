namespace ProyectoRegistroAsistencia
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pnlSidebar = new Panel();
            btnCerrarSesion = new Button();
            btnReportes = new Button();
            btnIncidencias = new Button();
            btnPuestos = new Button();
            btnDepartamentos = new Button();
            btnHorarios = new Button();
            btnEmpleados = new Button();
            btnAsistencias = new Button();
            lblSistema = new Label();
            pcbLogo = new PictureBox();
            pnlContenido = new Panel();
            pnlHeader = new Panel();
            pcbDisminuir = new PictureBox();
            pcbAumentar = new PictureBox();
            lblAyuda = new Label();
            pcbAyuda = new PictureBox();
            lblUsuario = new Label();
            pcbUsuario = new PictureBox();
            pcbModulo = new PictureBox();
            lblModuloPrefijo = new Label();
            lblModuloValor = new Label();
            lblBienvenida = new Label();
            pnlHeaderBorde = new Panel();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbDisminuir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAumentar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbModulo).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSidebar.BackColor = Color.FromArgb(43, 76, 140);
            pnlSidebar.Controls.Add(btnCerrarSesion);
            pnlSidebar.Controls.Add(btnReportes);
            pnlSidebar.Controls.Add(btnIncidencias);
            pnlSidebar.Controls.Add(btnPuestos);
            pnlSidebar.Controls.Add(btnDepartamentos);
            pnlSidebar.Controls.Add(btnHorarios);
            pnlSidebar.Controls.Add(btnEmpleados);
            pnlSidebar.Controls.Add(btnAsistencias);
            pnlSidebar.Controls.Add(lblSistema);
            pnlSidebar.Controls.Add(pcbLogo);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 750);
            pnlSidebar.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(108, 117, 125);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(12, 634);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(185, 40);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(74, 126, 193);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(12, 575);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(185, 40);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnIncidencias
            // 
            btnIncidencias.BackColor = Color.FromArgb(74, 126, 193);
            btnIncidencias.ForeColor = Color.White;
            btnIncidencias.Image = (Image)resources.GetObject("btnIncidencias.Image");
            btnIncidencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncidencias.Location = new Point(12, 517);
            btnIncidencias.Name = "btnIncidencias";
            btnIncidencias.Size = new Size(185, 40);
            btnIncidencias.TabIndex = 5;
            btnIncidencias.Text = "Incidencias";
            btnIncidencias.UseVisualStyleBackColor = false;
            btnIncidencias.Click += btnIncidencias_Click;
            // 
            // btnPuestos
            // 
            btnPuestos.BackColor = Color.FromArgb(74, 126, 193);
            btnPuestos.ForeColor = Color.White;
            btnPuestos.Image = (Image)resources.GetObject("btnPuestos.Image");
            btnPuestos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPuestos.Location = new Point(12, 456);
            btnPuestos.Name = "btnPuestos";
            btnPuestos.Size = new Size(185, 40);
            btnPuestos.TabIndex = 4;
            btnPuestos.Text = "Puestos";
            btnPuestos.UseVisualStyleBackColor = false;
            btnPuestos.Click += btnPuestos_Click;
            // 
            // btnDepartamentos
            // 
            btnDepartamentos.BackColor = Color.FromArgb(74, 126, 193);
            btnDepartamentos.ForeColor = Color.White;
            btnDepartamentos.Image = (Image)resources.GetObject("btnDepartamentos.Image");
            btnDepartamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartamentos.Location = new Point(12, 397);
            btnDepartamentos.Name = "btnDepartamentos";
            btnDepartamentos.Size = new Size(185, 40);
            btnDepartamentos.TabIndex = 3;
            btnDepartamentos.Text = "Departamentos";
            btnDepartamentos.UseVisualStyleBackColor = false;
            btnDepartamentos.Click += btnDepartamentos_Click;
            // 
            // btnHorarios
            // 
            btnHorarios.BackColor = Color.FromArgb(74, 126, 193);
            btnHorarios.ForeColor = Color.White;
            btnHorarios.Image = (Image)resources.GetObject("btnHorarios.Image");
            btnHorarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnHorarios.Location = new Point(12, 335);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Size = new Size(185, 40);
            btnHorarios.TabIndex = 2;
            btnHorarios.Text = "Horarios";
            btnHorarios.UseVisualStyleBackColor = false;
            btnHorarios.Click += btnHorarios_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(74, 126, 193);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(12, 275);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(185, 40);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnAsistencias
            // 
            btnAsistencias.BackColor = Color.FromArgb(43, 76, 140);
            btnAsistencias.ForeColor = Color.White;
            btnAsistencias.Image = (Image)resources.GetObject("btnAsistencias.Image");
            btnAsistencias.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistencias.Location = new Point(12, 215);
            btnAsistencias.Name = "btnAsistencias";
            btnAsistencias.Size = new Size(185, 40);
            btnAsistencias.TabIndex = 8;
            btnAsistencias.Text = "Asistencias";
            btnAsistencias.UseVisualStyleBackColor = false;
            btnAsistencias.Click += btnAsistencias_Click;
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistema.ForeColor = Color.White;
            lblSistema.Location = new Point(39, 176);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(129, 23);
            lblSistema.TabIndex = 1;
            lblSistema.Text = "Staff Asistence";
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(21, 14);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(172, 140);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // pnlContenido
            // 
            pnlContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenido.BackColor = Color.FromArgb(240, 242, 245);
            pnlContenido.Location = new Point(221, 52);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1084, 698);
            pnlContenido.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pcbDisminuir);
            pnlHeader.Controls.Add(pcbAumentar);
            pnlHeader.Controls.Add(lblAyuda);
            pnlHeader.Controls.Add(pcbAyuda);
            pnlHeader.Controls.Add(lblUsuario);
            pnlHeader.Controls.Add(pcbUsuario);
            pnlHeader.Controls.Add(pcbModulo);
            pnlHeader.Controls.Add(lblModuloPrefijo);
            pnlHeader.Controls.Add(lblModuloValor);
            pnlHeader.Controls.Add(lblBienvenida);
            pnlHeader.Controls.Add(pnlHeaderBorde);
            pnlHeader.Location = new Point(221, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1084, 53);
            pnlHeader.TabIndex = 2;
            // 
            // pcbDisminuir
            // 
            pcbDisminuir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbDisminuir.Cursor = Cursors.Hand;
            pcbDisminuir.Image = (Image)resources.GetObject("pcbDisminuir.Image");
            pcbDisminuir.Location = new Point(1046, 8);
            pcbDisminuir.Name = "pcbDisminuir";
            pcbDisminuir.Size = new Size(30, 30);
            pcbDisminuir.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDisminuir.TabIndex = 9;
            pcbDisminuir.TabStop = false;
            pcbDisminuir.MouseDown += pcbAyuda_MouseDown;
            pcbDisminuir.MouseUp += pcbAyuda_MouseUp;
            // 
            // pcbAumentar
            // 
            pcbAumentar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbAumentar.Cursor = Cursors.Hand;
            pcbAumentar.Image = (Image)resources.GetObject("pcbAumentar.Image");
            pcbAumentar.Location = new Point(1010, 8);
            pcbAumentar.Name = "pcbAumentar";
            pcbAumentar.Size = new Size(30, 30);
            pcbAumentar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAumentar.TabIndex = 8;
            pcbAumentar.TabStop = false;
            pcbAumentar.MouseDown += pcbAyuda_MouseDown;
            pcbAumentar.MouseUp += pcbAyuda_MouseUp;
            // 
            // lblAyuda
            // 
            lblAyuda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAyuda.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAyuda.ForeColor = Color.FromArgb(108, 117, 125);
            lblAyuda.Location = new Point(910, 15);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(57, 20);
            lblAyuda.TabIndex = 5;
            lblAyuda.Text = "Ayuda";
            lblAyuda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pcbAyuda
            // 
            pcbAyuda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbAyuda.Cursor = Cursors.Hand;
            pcbAyuda.Image = (Image)resources.GetObject("pcbAyuda.Image");
            pcbAyuda.Location = new Point(969, 8);
            pcbAyuda.Name = "pcbAyuda";
            pcbAyuda.Size = new Size(30, 30);
            pcbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAyuda.TabIndex = 7;
            pcbAyuda.TabStop = false;
            pcbAyuda.MouseDown += pcbAyuda_MouseDown;
            pcbAyuda.MouseUp += pcbAyuda_MouseUp;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(43, 76, 140);
            lblUsuario.Location = new Point(859, 16);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(39, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "-----";
            // 
            // pcbUsuario
            // 
            pcbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbUsuario.Image = (Image)resources.GetObject("pcbUsuario.Image");
            pcbUsuario.Location = new Point(641, 8);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(30, 30);
            pcbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuario.TabIndex = 1;
            pcbUsuario.TabStop = false;
            // 
            // pcbModulo
            // 
            pcbModulo.Image = (Image)resources.GetObject("pcbModulo.Image");
            pcbModulo.Location = new Point(20, 8);
            pcbModulo.Name = "pcbModulo";
            pcbModulo.Size = new Size(30, 30);
            pcbModulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbModulo.TabIndex = 0;
            pcbModulo.TabStop = false;
            //
            // lblModuloPrefijo
            //
            lblModuloPrefijo.AutoSize = true;
            lblModuloPrefijo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModuloPrefijo.ForeColor = Color.FromArgb(108, 117, 125);
            lblModuloPrefijo.Location = new Point(52, 16);
            lblModuloPrefijo.Name = "lblModuloPrefijo";
            lblModuloPrefijo.Size = new Size(64, 20);
            lblModuloPrefijo.TabIndex = 1;
            lblModuloPrefijo.Text = "Módulo:";
            //
            // lblModuloValor
            //
            lblModuloValor.AutoSize = true;
            lblModuloValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModuloValor.ForeColor = Color.FromArgb(43, 76, 140);
            lblModuloValor.Location = new Point(122, 16);
            lblModuloValor.Name = "lblModuloValor";
            lblModuloValor.Size = new Size(33, 20);
            lblModuloValor.TabIndex = 2;
            lblModuloValor.Text = "----";
            //
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBienvenida.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(108, 117, 125);
            lblBienvenida.Location = new Point(673, 16);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(185, 20);
            lblBienvenida.TabIndex = 4;
            lblBienvenida.Text = "Bienvenido administrador:";
            lblBienvenida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlHeaderBorde
            // 
            pnlHeaderBorde.BackColor = Color.FromArgb(221, 225, 231);
            pnlHeaderBorde.Dock = DockStyle.Bottom;
            pnlHeaderBorde.Location = new Point(0, 52);
            pnlHeaderBorde.Name = "pnlHeaderBorde";
            pnlHeaderBorde.Size = new Size(1084, 1);
            pnlHeaderBorde.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1306, 749);
            Controls.Add(pnlHeader);
            Controls.Add(pnlContenido);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmPrincipal";
            Text = "Administración";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbDisminuir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAumentar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbModulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblSistema;
        private PictureBox pcbLogo;
        private Button btnEmpleados;
        private Button btnAsistencias;
        private Button btnReportes;
        private Button btnIncidencias;
        private Button btnPuestos;
        private Button btnDepartamentos;
        private Button btnHorarios;
        private Button btnCerrarSesion;
        private Panel pnlContenido;
        private Panel pnlHeader;
        private Panel pnlHeaderBorde;
        private Label lblModuloPrefijo;
        private Label lblModuloValor;
        private Label lblBienvenida;
        private Label lblUsuario;
        private PictureBox pcbModulo;
        private PictureBox pcbUsuario;
        private Label lblAyuda;
        private PictureBox pcbAyuda;
        private PictureBox pcbAumentar;
        private PictureBox pcbDisminuir;
    }
}