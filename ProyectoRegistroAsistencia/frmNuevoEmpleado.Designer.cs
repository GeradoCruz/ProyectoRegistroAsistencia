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
            gpbDireccion = new GroupBox();
            txtCodigoPostal = new TextBox();
            txtMunicipio = new TextBox();
            txtLocalidad = new TextBox();
            txtNumCalle = new TextBox();
            lblMunicipio = new Label();
            lblLocalidad = new Label();
            lblCP = new Label();
            lblNumCalle = new Label();
            lblDepartamento = new Label();
            lblPuesto = new Label();
            gpbDatosDeContacto = new GroupBox();
            txtCorreoInstitucional = new TextBox();
            txtTelefono = new TextBox();
            lblCorreoInstitucional = new Label();
            lblTelefono = new Label();
            btnGuardar = new Button();
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
            btnCancelar = new Button();
            lblTitulo = new Label();
            gpbDatosGenerales = new GroupBox();
            gpbDireccion.SuspendLayout();
            gpbDatosDeContacto.SuspendLayout();
            gpbDatosGenerales.SuspendLayout();
            SuspendLayout();
            // 
            // gpbDireccion
            // 
            gpbDireccion.Controls.Add(txtCodigoPostal);
            gpbDireccion.Controls.Add(txtMunicipio);
            gpbDireccion.Controls.Add(txtLocalidad);
            gpbDireccion.Controls.Add(txtNumCalle);
            gpbDireccion.Controls.Add(lblMunicipio);
            gpbDireccion.Controls.Add(lblLocalidad);
            gpbDireccion.Controls.Add(lblCP);
            gpbDireccion.Controls.Add(lblNumCalle);
            gpbDireccion.FlatStyle = FlatStyle.Popup;
            gpbDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDireccion.ForeColor = Color.FromArgb(108, 117, 125);
            gpbDireccion.Location = new Point(12, 308);
            gpbDireccion.Name = "gpbDireccion";
            gpbDireccion.Size = new Size(480, 134);
            gpbDireccion.TabIndex = 8;
            gpbDireccion.TabStop = false;
            gpbDireccion.Text = "Dirección";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigoPostal.Location = new Point(257, 41);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(200, 29);
            txtCodigoPostal.TabIndex = 5;
            // 
            // txtMunicipio
            // 
            txtMunicipio.ForeColor = Color.FromArgb(64, 64, 64);
            txtMunicipio.Location = new Point(257, 96);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(200, 29);
            txtMunicipio.TabIndex = 7;
            // 
            // txtLocalidad
            // 
            txtLocalidad.ForeColor = Color.FromArgb(64, 64, 64);
            txtLocalidad.Location = new Point(16, 96);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(200, 29);
            txtLocalidad.TabIndex = 6;
            // 
            // txtNumCalle
            // 
            txtNumCalle.ForeColor = Color.FromArgb(64, 64, 64);
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
            lblMunicipio.TextAlign = ContentAlignment.MiddleLeft;
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
            lblLocalidad.TextAlign = ContentAlignment.MiddleLeft;
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
            lblCP.TextAlign = ContentAlignment.MiddleLeft;
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
            lblNumCalle.TextAlign = ContentAlignment.MiddleLeft;
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
            lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
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
            lblPuesto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gpbDatosDeContacto
            // 
            gpbDatosDeContacto.Controls.Add(txtCorreoInstitucional);
            gpbDatosDeContacto.Controls.Add(txtTelefono);
            gpbDatosDeContacto.Controls.Add(lblCorreoInstitucional);
            gpbDatosDeContacto.Controls.Add(lblTelefono);
            gpbDatosDeContacto.FlatStyle = FlatStyle.Popup;
            gpbDatosDeContacto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDatosDeContacto.ForeColor = Color.FromArgb(108, 117, 125);
            gpbDatosDeContacto.Location = new Point(12, 448);
            gpbDatosDeContacto.Name = "gpbDatosDeContacto";
            gpbDatosDeContacto.Size = new Size(480, 83);
            gpbDatosDeContacto.TabIndex = 9;
            gpbDatosDeContacto.TabStop = false;
            gpbDatosDeContacto.Text = "Datos de Contacto";
            // 
            // txtCorreoInstitucional
            // 
            txtCorreoInstitucional.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoInstitucional.ForeColor = Color.FromArgb(64, 64, 64);
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
            lblCorreoInstitucional.Size = new Size(153, 21);
            lblCorreoInstitucional.TabIndex = 1;
            lblCorreoInstitucional.Text = "Correo Insititucional:";
            lblCorreoInstitucional.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.FromArgb(108, 117, 125);
            lblTelefono.Location = new Point(17, 19);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 21);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(12, 547);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 40);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbPuesto
            // 
            cmbPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPuesto.ForeColor = Color.FromArgb(64, 64, 64);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Location = new Point(257, 214);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(200, 29);
            cmbPuesto.TabIndex = 13;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
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
            txtApellidoPaterno.ForeColor = Color.FromArgb(64, 64, 64);
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
            rdbHombre.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombre.Location = new Point(257, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 7;
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.CharacterCasing = CharacterCasing.Upper;
            txtClaveTrabajador.ForeColor = Color.FromArgb(64, 64, 64);
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
            lblApellidoMaterno.TextAlign = ContentAlignment.MiddleLeft;
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
            lblApellidoPaterno.TextAlign = ContentAlignment.MiddleLeft;
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
            lblGenero.TextAlign = ContentAlignment.MiddleLeft;
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
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(16, 24);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(154, 21);
            lblClaveTrabajador.TabIndex = 0;
            lblClaveTrabajador.Text = "Clave del Trabajador:";
            lblClaveTrabajador.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(310, 547);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(104, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(298, 30);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Registro de Nuevo Empleado";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gpbDatosGenerales
            // 
            gpbDatosGenerales.Controls.Add(lblPuesto);
            gpbDatosGenerales.Controls.Add(lblDepartamento);
            gpbDatosGenerales.Controls.Add(cmbPuesto);
            gpbDatosGenerales.Controls.Add(cmbDepartamento);
            gpbDatosGenerales.Controls.Add(txtApellidoMaterno);
            gpbDatosGenerales.Controls.Add(txtApellidoPaterno);
            gpbDatosGenerales.Controls.Add(rdbMujer);
            gpbDatosGenerales.Controls.Add(rdbHombre);
            gpbDatosGenerales.Controls.Add(txtNombre);
            gpbDatosGenerales.Controls.Add(txtClaveTrabajador);
            gpbDatosGenerales.Controls.Add(lblApellidoMaterno);
            gpbDatosGenerales.Controls.Add(lblApellidoPaterno);
            gpbDatosGenerales.Controls.Add(lblGenero);
            gpbDatosGenerales.Controls.Add(lblNombre);
            gpbDatosGenerales.Controls.Add(lblClaveTrabajador);
            gpbDatosGenerales.FlatStyle = FlatStyle.Popup;
            gpbDatosGenerales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDatosGenerales.ForeColor = Color.FromArgb(108, 117, 125);
            gpbDatosGenerales.Location = new Point(12, 49);
            gpbDatosGenerales.Name = "gpbDatosGenerales";
            gpbDatosGenerales.Size = new Size(480, 253);
            gpbDatosGenerales.TabIndex = 6;
            gpbDatosGenerales.TabStop = false;
            gpbDatosGenerales.Text = "Datos Generales";
            // 
            // frmNuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(504, 603);
            Controls.Add(gpbDireccion);
            Controls.Add(gpbDatosDeContacto);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitulo);
            Controls.Add(gpbDatosGenerales);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(108, 117, 125);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoEmpleado";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Assistence";
            gpbDireccion.ResumeLayout(false);
            gpbDireccion.PerformLayout();
            gpbDatosDeContacto.ResumeLayout(false);
            gpbDatosDeContacto.PerformLayout();
            gpbDatosGenerales.ResumeLayout(false);
            gpbDatosGenerales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public GroupBox gpbDireccion;
        public TextBox txtCodigoPostal;
        public TextBox txtMunicipio;
        public TextBox txtLocalidad;
        public TextBox txtNumCalle;
        private Label lblMunicipio;
        private Label lblLocalidad;
        private Label lblCP;
        private Label lblNumCalle;
        private Label lblDepartamento;
        private Label lblPuesto;
        private GroupBox gpbDatosDeContacto;
        public TextBox txtCorreoInstitucional;
        public TextBox txtTelefono;
        private Label lblCorreoInstitucional;
        private Label lblTelefono;
        private Button btnGuardar;
        public ComboBox cmbPuesto;
        public ComboBox cmbDepartamento;
        public TextBox txtApellidoMaterno;
        public TextBox txtApellidoPaterno;
        public RadioButton rdbMujer;
        public RadioButton rdbHombre;
        public TextBox txtNombre;
        public TextBox txtClaveTrabajador;
        private Label lblApellidoMaterno;
        private Label lblApellidoPaterno;
        private Label lblGenero;
        private Label lblNombre;
        private Label lblClaveTrabajador;
        private Button btnCancelar;
        public Label lblTitulo;
        private GroupBox gpbDatosGenerales;
    }
}
