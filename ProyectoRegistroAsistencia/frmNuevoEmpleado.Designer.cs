namespace ProyectoRegistroAsistencia
{
    partial class frmNuevoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoEmpleado));
            grpDatosGenerales = new GroupBox();
            lblPuesto = new Label();
            lblDepartamento = new Label();
            cmbPuesto = new ComboBox();
            cmbDepartamento = new ComboBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            rdbMujer = new RadioButton();
            rdbHombre = new RadioButton();
            txtNombre = new TextBox();
            txtClaveTrabajador = new TextBox();
            lblApellidoMaterno = new Label();
            lblApellidoPaterno = new Label();
            lblGenero = new Label();
            lblNombre = new Label();
            lblClaveTrabajador = new Label();
            lblTitulo = new Label();
            grpGenero = new GroupBox();
            txtCodigoPostal = new TextBox();
            txtMunicipio = new TextBox();
            txtLocalidad = new TextBox();
            txtNumCalle = new TextBox();
            lblMunicipio = new Label();
            lblLocalidad = new Label();
            lblCP = new Label();
            lblNumCalle = new Label();
            grpDatosDeContacto = new GroupBox();
            txtCorreoInstitucional = new TextBox();
            txtTelefono = new TextBox();
            lblCorreoInstitucional = new Label();
            lblTelefono = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            grpDatosGenerales.SuspendLayout();
            grpGenero.SuspendLayout();
            grpDatosDeContacto.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosGenerales
            // 
            grpDatosGenerales.Controls.Add(lblPuesto);
            grpDatosGenerales.Controls.Add(lblDepartamento);
            grpDatosGenerales.Controls.Add(cmbPuesto);
            grpDatosGenerales.Controls.Add(cmbDepartamento);
            grpDatosGenerales.Controls.Add(txtApellidoMaterno);
            grpDatosGenerales.Controls.Add(txtApellidoPaterno);
            grpDatosGenerales.Controls.Add(rdbMujer);
            grpDatosGenerales.Controls.Add(rdbHombre);
            grpDatosGenerales.Controls.Add(txtNombre);
            grpDatosGenerales.Controls.Add(txtClaveTrabajador);
            grpDatosGenerales.Controls.Add(lblApellidoMaterno);
            grpDatosGenerales.Controls.Add(lblApellidoPaterno);
            grpDatosGenerales.Controls.Add(lblGenero);
            grpDatosGenerales.Controls.Add(lblNombre);
            grpDatosGenerales.Controls.Add(lblClaveTrabajador);
            grpDatosGenerales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosGenerales.ForeColor = Color.FromArgb(108, 117, 125);
            grpDatosGenerales.Location = new Point(12, 42);
            grpDatosGenerales.Name = "grpDatosGenerales";
            grpDatosGenerales.Size = new Size(480, 253);
            grpDatosGenerales.TabIndex = 0;
            grpDatosGenerales.TabStop = false;
            grpDatosGenerales.Text = "Datos Generales";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuesto.ForeColor = Color.FromArgb(108, 117, 125);
            lblPuesto.Location = new Point(257, 190);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(60, 21);
            lblPuesto.TabIndex = 15;
            lblPuesto.Text = "Puesto:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(17, 190);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 14;
            lblDepartamento.Text = "Departamento:";
            // 
            // cmbPuesto
            // 
            cmbPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Location = new Point(257, 214);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(200, 29);
            cmbPuesto.TabIndex = 13;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(16, 214);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(200, 29);
            cmbDepartamento.TabIndex = 12;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(257, 158);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(200, 29);
            txtApellidoMaterno.TabIndex = 11;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(17, 158);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(200, 29);
            txtApellidoPaterno.TabIndex = 10;
            // 
            // rdbMujer
            // 
            rdbMujer.AutoSize = true;
            rdbMujer.CheckAlign = ContentAlignment.MiddleRight;
            rdbMujer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbMujer.Location = new Point(71, 105);
            rdbMujer.Name = "rdbMujer";
            rdbMujer.Size = new Size(45, 25);
            rdbMujer.TabIndex = 9;
            rdbMujer.TabStop = true;
            rdbMujer.Text = "M:";
            rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            rdbHombre.AutoSize = true;
            rdbHombre.CheckAlign = ContentAlignment.MiddleRight;
            rdbHombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbHombre.Location = new Point(16, 105);
            rdbHombre.Name = "rdbHombre";
            rdbHombre.Size = new Size(42, 25);
            rdbHombre.TabIndex = 8;
            rdbHombre.TabStop = true;
            rdbHombre.Text = "H:";
            rdbHombre.TextAlign = ContentAlignment.BottomRight;
            rdbHombre.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(257, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 7;
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.Location = new Point(16, 48);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(200, 29);
            txtClaveTrabajador.TabIndex = 6;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoMaterno.ForeColor = Color.FromArgb(108, 117, 125);
            lblApellidoMaterno.Location = new Point(257, 134);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(133, 21);
            lblApellidoMaterno.TabIndex = 4;
            lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaterno.ForeColor = Color.FromArgb(108, 117, 125);
            lblApellidoPaterno.Location = new Point(17, 134);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(127, 21);
            lblApellidoPaterno.TabIndex = 3;
            lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.ForeColor = Color.FromArgb(108, 117, 125);
            lblGenero.Location = new Point(16, 80);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(64, 21);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "Genero:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombre.Location = new Point(257, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(88, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre(s):";
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(16, 24);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(151, 21);
            lblClaveTrabajador.TabIndex = 0;
            lblClaveTrabajador.Text = "Clave del Trabajador";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(104, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de Nuevo Empleado";
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(txtCodigoPostal);
            grpGenero.Controls.Add(txtMunicipio);
            grpGenero.Controls.Add(txtLocalidad);
            grpGenero.Controls.Add(txtNumCalle);
            grpGenero.Controls.Add(lblMunicipio);
            grpGenero.Controls.Add(lblLocalidad);
            grpGenero.Controls.Add(lblCP);
            grpGenero.Controls.Add(lblNumCalle);
            grpGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpGenero.ForeColor = Color.FromArgb(108, 117, 125);
            grpGenero.Location = new Point(12, 301);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(480, 134);
            grpGenero.TabIndex = 2;
            grpGenero.TabStop = false;
            grpGenero.Text = "Direccion";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(257, 41);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(200, 29);
            txtCodigoPostal.TabIndex = 7;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(257, 96);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(200, 29);
            txtMunicipio.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(16, 96);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(200, 29);
            txtLocalidad.TabIndex = 5;
            // 
            // txtNumCalle
            // 
            txtNumCalle.Location = new Point(16, 41);
            txtNumCalle.Name = "txtNumCalle";
            txtNumCalle.Size = new Size(200, 29);
            txtNumCalle.TabIndex = 4;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMunicipio.ForeColor = Color.FromArgb(108, 117, 125);
            lblMunicipio.Location = new Point(257, 72);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(82, 21);
            lblMunicipio.TabIndex = 3;
            lblMunicipio.Text = "Municipio:";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalidad.ForeColor = Color.FromArgb(108, 117, 125);
            lblLocalidad.Location = new Point(16, 72);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(79, 21);
            lblLocalidad.TabIndex = 2;
            lblLocalidad.Text = "Localidad:";
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCP.ForeColor = Color.FromArgb(108, 117, 125);
            lblCP.Location = new Point(260, 17);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(35, 21);
            lblCP.TabIndex = 1;
            lblCP.Text = "C.P:";
            // 
            // lblNumCalle
            // 
            lblNumCalle.AutoSize = true;
            lblNumCalle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumCalle.ForeColor = Color.FromArgb(108, 117, 125);
            lblNumCalle.Location = new Point(17, 19);
            lblNumCalle.Name = "lblNumCalle";
            lblNumCalle.Size = new Size(89, 21);
            lblNumCalle.TabIndex = 0;
            lblNumCalle.Text = "Num. Calle:";
            // 
            // grpDatosDeContacto
            // 
            grpDatosDeContacto.Controls.Add(txtCorreoInstitucional);
            grpDatosDeContacto.Controls.Add(txtTelefono);
            grpDatosDeContacto.Controls.Add(lblCorreoInstitucional);
            grpDatosDeContacto.Controls.Add(lblTelefono);
            grpDatosDeContacto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosDeContacto.ForeColor = Color.FromArgb(108, 117, 125);
            grpDatosDeContacto.Location = new Point(12, 441);
            grpDatosDeContacto.Name = "grpDatosDeContacto";
            grpDatosDeContacto.Size = new Size(480, 83);
            grpDatosDeContacto.TabIndex = 3;
            grpDatosDeContacto.TabStop = false;
            grpDatosDeContacto.Text = "Datos de Contacto";
            // 
            // txtCorreoInstitucional
            // 
            txtCorreoInstitucional.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoInstitucional.Location = new Point(257, 43);
            txtCorreoInstitucional.Name = "txtCorreoInstitucional";
            txtCorreoInstitucional.Size = new Size(200, 29);
            txtCorreoInstitucional.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(17, 43);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 29);
            txtTelefono.TabIndex = 2;
            // 
            // lblCorreoInstitucional
            // 
            lblCorreoInstitucional.AutoSize = true;
            lblCorreoInstitucional.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreoInstitucional.ForeColor = Color.FromArgb(108, 117, 125);
            lblCorreoInstitucional.Location = new Point(257, 19);
            lblCorreoInstitucional.Name = "lblCorreoInstitucional";
            lblCorreoInstitucional.Size = new Size(150, 21);
            lblCorreoInstitucional.TabIndex = 1;
            lblCorreoInstitucional.Text = "Correo Insititucional";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.FromArgb(108, 117, 125);
            lblTelefono.Location = new Point(17, 19);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Telefono";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(12, 540);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 40);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(310, 540);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmNuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(504, 603);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatosDeContacto);
            Controls.Add(grpGenero);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosGenerales);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Asistence";
            grpDatosGenerales.ResumeLayout(false);
            grpDatosGenerales.PerformLayout();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            grpDatosDeContacto.ResumeLayout(false);
            grpDatosDeContacto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatosGenerales;
        private Label lblApellidoMaterno;
        private Label lblApellidoPaterno;
        private Label lblGenero;
        private Label lblNombre;
        private Label lblClaveTrabajador;
        public TextBox txtNombre;
        public TextBox txtClaveTrabajador;
        public RadioButton rdbHombre;
        public RadioButton rdbMujer;
        public TextBox txtApellidoMaterno;
        public TextBox txtApellidoPaterno;
        public GroupBox grpGenero;
        public TextBox txtLocalidad;
        public TextBox txtNumCalle;
        private Label lblMunicipio;
        private Label lblLocalidad;
        private Label lblCP;
        private Label lblNumCalle;
        public TextBox txtCodigoPostal;
        public TextBox txtMunicipio;
        private GroupBox grpDatosDeContacto;
        public TextBox txtCorreoInstitucional;
        public TextBox txtTelefono;
        private Label lblCorreoInstitucional;
        private Label lblTelefono;
        private Button btnGuardar;
        private Button btnCancelar;
        public ComboBox cmbPuesto;
        public ComboBox cmbDepartamento;
        private Label lblPuesto;
        private Label lblDepartamento;
        public Label lblTitulo;
    }
}
