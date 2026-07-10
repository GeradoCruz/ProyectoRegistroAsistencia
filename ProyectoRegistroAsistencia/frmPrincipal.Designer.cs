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
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
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
            pnlContenido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenido.BackColor = Color.FromArgb(240, 242, 245);
            pnlContenido.Location = new Point(221, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(902, 788);
            pnlContenido.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1124, 749);
            Controls.Add(pnlContenido);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmPrincipal";
            Text = "Administración";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
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
    }
}