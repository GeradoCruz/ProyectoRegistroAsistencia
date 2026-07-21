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
            grpDatosGenerales.Location = new Point(14, 56);
            grpDatosGenerales.Margin = new Padding(3, 4, 3, 4);
            grpDatosGenerales.Name = "grpDatosGenerales";
            grpDatosGenerales.Padding = new Padding(3, 4, 3, 4);
            grpDatosGenerales.Size = new Size(549, 337);
            grpDatosGenerales.TabIndex = 0;
            grpDatosGenerales.TabStop = false;
            grpDatosGenerales.Text = "Datos Generales";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuesto.ForeColor = Color.FromArgb(108, 117, 125);
            lblPuesto.Location = new Point(294, 253);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(75, 28);
            lblPuesto.TabIndex = 15;
            lblPuesto.Text = "Puesto:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(19, 253);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(143, 28);
            lblDepartamento.TabIndex = 14;
            lblDepartamento.Text = "Departamento:";
            // 
            // cmbPuesto
            // 
            cmbPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Location = new Point(294, 285);
            cmbPuesto.Margin = new Padding(3, 4, 3, 4);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(228, 36);
            cmbPuesto.TabIndex = 13;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(18, 285);
            cmbDepartamento.Margin = new Padding(3, 4, 3, 4);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(228, 36);
            cmbDepartamento.TabIndex = 12;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(294, 211);
            txtApellidoMaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(228, 34);
            txtApellidoMaterno.TabIndex = 11;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(19, 211);
            txtApellidoPaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(228, 34);
            txtApellidoPaterno.TabIndex = 10;
            // 
            // rdbMujer
            // 
            rdbMujer.AutoSize = true;
            rdbMujer.CheckAlign = ContentAlignment.MiddleRight;
            rdbMujer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbMujer.Location = new Point(81, 140);
            rdbMujer.Margin = new Padding(3, 4, 3, 4);
            rdbMujer.Name = "rdbMujer";
            rdbMujer.Size = new Size(55, 32);
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
            rdbHombre.Location = new Point(18, 140);
            rdbHombre.Margin = new Padding(3, 4, 3, 4);
            rdbHombre.Name = "rdbHombre";
            rdbHombre.Size = new Size(51, 32);
            rdbHombre.TabIndex = 8;
            rdbHombre.TabStop = true;
            rdbHombre.Text = "H:";
            rdbHombre.TextAlign = ContentAlignment.BottomRight;
            rdbHombre.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(294, 64);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 34);
            txtNombre.TabIndex = 7;
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.Location = new Point(18, 64);
            txtClaveTrabajador.Margin = new Padding(3, 4, 3, 4);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(228, 34);
            txtClaveTrabajador.TabIndex = 6;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoMaterno.ForeColor = Color.FromArgb(108, 117, 125);
            lblApellidoMaterno.Location = new Point(294, 179);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(170, 28);
            lblApellidoMaterno.TabIndex = 4;
            lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaterno.ForeColor = Color.FromArgb(108, 117, 125);
            lblApellidoPaterno.Location = new Point(19, 179);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(162, 28);
            lblApellidoPaterno.TabIndex = 3;
            lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.ForeColor = Color.FromArgb(108, 117, 125);
            lblGenero.Location = new Point(18, 107);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(80, 28);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "Genero:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombre.Location = new Point(294, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(109, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre(s):";
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(18, 32);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(189, 28);
            lblClaveTrabajador.TabIndex = 0;
            lblClaveTrabajador.Text = "Clave del Trabajador";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(119, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(390, 37);
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
            grpGenero.Location = new Point(14, 401);
            grpGenero.Margin = new Padding(3, 4, 3, 4);
            grpGenero.Name = "grpGenero";
            grpGenero.Padding = new Padding(3, 4, 3, 4);
            grpGenero.Size = new Size(549, 179);
            grpGenero.TabIndex = 2;
            grpGenero.TabStop = false;
            grpGenero.Text = "Direccion";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(294, 55);
            txtCodigoPostal.Margin = new Padding(3, 4, 3, 4);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(228, 34);
            txtCodigoPostal.TabIndex = 7;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(294, 128);
            txtMunicipio.Margin = new Padding(3, 4, 3, 4);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(228, 34);
            txtMunicipio.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(18, 128);
            txtLocalidad.Margin = new Padding(3, 4, 3, 4);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(228, 34);
            txtLocalidad.TabIndex = 5;
            // 
            // txtNumCalle
            // 
            txtNumCalle.Location = new Point(18, 55);
            txtNumCalle.Margin = new Padding(3, 4, 3, 4);
            txtNumCalle.Name = "txtNumCalle";
            txtNumCalle.Size = new Size(228, 34);
            txtNumCalle.TabIndex = 4;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMunicipio.ForeColor = Color.FromArgb(108, 117, 125);
            lblMunicipio.Location = new Point(294, 96);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(104, 28);
            lblMunicipio.TabIndex = 3;
            lblMunicipio.Text = "Municipio:";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalidad.ForeColor = Color.FromArgb(108, 117, 125);
            lblLocalidad.Location = new Point(18, 96);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(100, 28);
            lblLocalidad.TabIndex = 2;
            lblLocalidad.Text = "Localidad:";
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCP.ForeColor = Color.FromArgb(108, 117, 125);
            lblCP.Location = new Point(297, 23);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(43, 28);
            lblCP.TabIndex = 1;
            lblCP.Text = "C.P:";
            // 
            // lblNumCalle
            // 
            lblNumCalle.AutoSize = true;
            lblNumCalle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumCalle.ForeColor = Color.FromArgb(108, 117, 125);
            lblNumCalle.Location = new Point(19, 25);
            lblNumCalle.Name = "lblNumCalle";
            lblNumCalle.Size = new Size(110, 28);
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
            grpDatosDeContacto.Location = new Point(14, 588);
            grpDatosDeContacto.Margin = new Padding(3, 4, 3, 4);
            grpDatosDeContacto.Name = "grpDatosDeContacto";
            grpDatosDeContacto.Padding = new Padding(3, 4, 3, 4);
            grpDatosDeContacto.Size = new Size(549, 111);
            grpDatosDeContacto.TabIndex = 3;
            grpDatosDeContacto.TabStop = false;
            grpDatosDeContacto.Text = "Datos de Contacto";
            // 
            // txtCorreoInstitucional
            // 
            txtCorreoInstitucional.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoInstitucional.Location = new Point(294, 57);
            txtCorreoInstitucional.Margin = new Padding(3, 4, 3, 4);
            txtCorreoInstitucional.Name = "txtCorreoInstitucional";
            txtCorreoInstitucional.Size = new Size(228, 34);
            txtCorreoInstitucional.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(19, 57);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(228, 34);
            txtTelefono.TabIndex = 2;
            // 
            // lblCorreoInstitucional
            // 
            lblCorreoInstitucional.AutoSize = true;
            lblCorreoInstitucional.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreoInstitucional.ForeColor = Color.FromArgb(108, 117, 125);
            lblCorreoInstitucional.Location = new Point(294, 25);
            lblCorreoInstitucional.Name = "lblCorreoInstitucional";
            lblCorreoInstitucional.Size = new Size(188, 28);
            lblCorreoInstitucional.TabIndex = 1;
            lblCorreoInstitucional.Text = "Correo Insititucional";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.FromArgb(108, 117, 125);
            lblTelefono.Location = new Point(19, 25);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 28);
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
            btnGuardar.Location = new Point(14, 720);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(206, 53);
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
            btnCancelar.Location = new Point(354, 720);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 53);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmNuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(576, 785);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatosDeContacto);
            Controls.Add(grpGenero);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosGenerales);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoEmpleado";
            StartPosition = FormStartPosition.CenterParent;
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
