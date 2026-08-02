namespace ProyectoRegistroAsistencia
{
    partial class frmAsignacionHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignacionHorarios));
            btnGuardar = new Button();
            lblDias = new Label();
            chkViernes = new CheckBox();
            chkJueves = new CheckBox();
            chkMiercoles = new CheckBox();
            chkMartes = new CheckBox();
            chkLunes = new CheckBox();
            lblHoraSalida = new Label();
            dtpHoraSalida = new DateTimePicker();
            lblHoraEntrada = new Label();
            dtpHoraEntrada = new DateTimePicker();
            btnCancelar = new Button();
            gpbHorario = new GroupBox();
            lblTitulo = new Label();
            cmbSemestre = new ComboBox();
            txtPuesto = new TextBox();
            txtNombreCompleto = new TextBox();
            lblPuesto = new Label();
            lblDepartamento = new Label();
            lblSemestre = new Label();
            lblNombreCompleto = new Label();
            btnBuscar = new Button();
            txtBuscarClave = new TextBox();
            lblClaveTrabajador = new Label();
            gpbBuscarTrabajador = new GroupBox();
            txtDepartamento = new TextBox();
            gpbDatosTrabajador = new GroupBox();
            gpbHorario.SuspendLayout();
            gpbBuscarTrabajador.SuspendLayout();
            gpbDatosTrabajador.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(11, 482);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 40);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.ForeColor = Color.FromArgb(108, 117, 125);
            lblDias.Location = new Point(18, 138);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(43, 21);
            lblDias.TabIndex = 9;
            lblDias.Text = "Días:";
            lblDias.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Font = new Font("Segoe UI", 9F);
            chkViernes.Location = new Point(342, 143);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(63, 19);
            chkViernes.TabIndex = 8;
            chkViernes.Text = "viernes";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Font = new Font("Segoe UI", 9F);
            chkJueves.Location = new Point(277, 143);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(59, 19);
            chkJueves.TabIndex = 7;
            chkJueves.Text = "jueves";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Font = new Font("Segoe UI", 9F);
            chkMiercoles.Location = new Point(196, 143);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(77, 19);
            chkMiercoles.TabIndex = 6;
            chkMiercoles.Text = "miércoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Font = new Font("Segoe UI", 9F);
            chkMartes.Location = new Point(129, 142);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(62, 19);
            chkMartes.TabIndex = 5;
            chkMartes.Text = "martes";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Font = new Font("Segoe UI", 9F);
            chkLunes.Location = new Point(67, 143);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(54, 19);
            chkLunes.TabIndex = 4;
            chkLunes.Text = "lunes";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.ForeColor = Color.FromArgb(108, 117, 125);
            lblHoraSalida.Location = new Point(18, 79);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(111, 21);
            lblHoraSalida.TabIndex = 3;
            lblHoraSalida.Text = "Hora de Salida";
            lblHoraSalida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new Point(18, 103);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new Size(122, 29);
            dtpHoraSalida.TabIndex = 2;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.ForeColor = Color.FromArgb(108, 117, 125);
            lblHoraEntrada.Location = new Point(18, 23);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(122, 21);
            lblHoraEntrada.TabIndex = 1;
            lblHoraEntrada.Text = "Hora de Entrada";
            lblHoraEntrada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpHoraEntrada
            // 
            dtpHoraEntrada.Format = DateTimePickerFormat.Time;
            dtpHoraEntrada.Location = new Point(18, 47);
            dtpHoraEntrada.Name = "dtpHoraEntrada";
            dtpHoraEntrada.ShowUpDown = true;
            dtpHoraEntrada.Size = new Size(122, 29);
            dtpHoraEntrada.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(294, 482);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gpbHorario
            // 
            gpbHorario.Controls.Add(lblDias);
            gpbHorario.Controls.Add(chkViernes);
            gpbHorario.Controls.Add(chkJueves);
            gpbHorario.Controls.Add(chkMiercoles);
            gpbHorario.Controls.Add(chkMartes);
            gpbHorario.Controls.Add(chkLunes);
            gpbHorario.Controls.Add(lblHoraSalida);
            gpbHorario.Controls.Add(dtpHoraSalida);
            gpbHorario.Controls.Add(lblHoraEntrada);
            gpbHorario.Controls.Add(dtpHoraEntrada);
            gpbHorario.FlatStyle = FlatStyle.Popup;
            gpbHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbHorario.ForeColor = Color.FromArgb(108, 117, 125);
            gpbHorario.Location = new Point(13, 288);
            gpbHorario.Name = "gpbHorario";
            gpbHorario.Size = new Size(460, 178);
            gpbHorario.TabIndex = 9;
            gpbHorario.TabStop = false;
            gpbHorario.Text = "Horario";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(142, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 30);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Asignación de Horario";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSemestre
            // 
            cmbSemestre.BackColor = Color.White;
            cmbSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestre.ForeColor = Color.FromArgb(64, 64, 64);
            cmbSemestre.FormattingEnabled = true;
            cmbSemestre.Location = new Point(247, 49);
            cmbSemestre.Margin = new Padding(3, 2, 3, 2);
            cmbSemestre.Name = "cmbSemestre";
            cmbSemestre.Size = new Size(200, 29);
            cmbSemestre.TabIndex = 8;
            // 
            // txtPuesto
            // 
            txtPuesto.BackColor = Color.White;
            txtPuesto.ForeColor = Color.FromArgb(64, 64, 64);
            txtPuesto.Location = new Point(247, 105);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.ReadOnly = true;
            txtPuesto.Size = new Size(200, 29);
            txtPuesto.TabIndex = 7;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BackColor = Color.White;
            txtNombreCompleto.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombreCompleto.Location = new Point(18, 49);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(200, 29);
            txtNombreCompleto.TabIndex = 4;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.ForeColor = Color.FromArgb(108, 117, 125);
            lblPuesto.Location = new Point(247, 81);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(60, 21);
            lblPuesto.TabIndex = 3;
            lblPuesto.Text = "Puesto:";
            lblPuesto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(18, 81);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 2;
            lblDepartamento.Text = "Departamento:";
            lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.ForeColor = Color.FromArgb(108, 117, 125);
            lblSemestre.Location = new Point(247, 25);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(78, 21);
            lblSemestre.TabIndex = 1;
            lblSemestre.Text = "Semestre:";
            lblSemestre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombreCompleto.Location = new Point(18, 25);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(143, 21);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre Completo:";
            lblNombreCompleto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(247, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarClave
            // 
            txtBuscarClave.BackColor = Color.White;
            txtBuscarClave.ForeColor = Color.FromArgb(64, 64, 64);
            txtBuscarClave.Location = new Point(18, 49);
            txtBuscarClave.Name = "txtBuscarClave";
            txtBuscarClave.Size = new Size(200, 29);
            txtBuscarClave.TabIndex = 1;
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(18, 25);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(154, 21);
            lblClaveTrabajador.TabIndex = 0;
            lblClaveTrabajador.Text = "Clave del Trabajador:";
            lblClaveTrabajador.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gpbBuscarTrabajador
            // 
            gpbBuscarTrabajador.Controls.Add(btnBuscar);
            gpbBuscarTrabajador.Controls.Add(txtBuscarClave);
            gpbBuscarTrabajador.Controls.Add(lblClaveTrabajador);
            gpbBuscarTrabajador.FlatStyle = FlatStyle.Popup;
            gpbBuscarTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbBuscarTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            gpbBuscarTrabajador.Location = new Point(13, 44);
            gpbBuscarTrabajador.Name = "gpbBuscarTrabajador";
            gpbBuscarTrabajador.Size = new Size(460, 87);
            gpbBuscarTrabajador.TabIndex = 6;
            gpbBuscarTrabajador.TabStop = false;
            gpbBuscarTrabajador.Text = "Buscar Trabajador";
            // 
            // txtDepartamento
            // 
            txtDepartamento.BackColor = Color.White;
            txtDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
            txtDepartamento.Location = new Point(18, 105);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.ReadOnly = true;
            txtDepartamento.Size = new Size(200, 29);
            txtDepartamento.TabIndex = 6;
            // 
            // gpbDatosTrabajador
            // 
            gpbDatosTrabajador.Controls.Add(cmbSemestre);
            gpbDatosTrabajador.Controls.Add(txtPuesto);
            gpbDatosTrabajador.Controls.Add(txtDepartamento);
            gpbDatosTrabajador.Controls.Add(txtNombreCompleto);
            gpbDatosTrabajador.Controls.Add(lblPuesto);
            gpbDatosTrabajador.Controls.Add(lblDepartamento);
            gpbDatosTrabajador.Controls.Add(lblSemestre);
            gpbDatosTrabajador.Controls.Add(lblNombreCompleto);
            gpbDatosTrabajador.FlatStyle = FlatStyle.Popup;
            gpbDatosTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDatosTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            gpbDatosTrabajador.Location = new Point(13, 137);
            gpbDatosTrabajador.Name = "gpbDatosTrabajador";
            gpbDatosTrabajador.Size = new Size(460, 145);
            gpbDatosTrabajador.TabIndex = 7;
            gpbDatosTrabajador.TabStop = false;
            gpbDatosTrabajador.Text = "Datos Del Trabajador";
            // 
            // frmAsignacionHorarios
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(484, 532);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(gpbHorario);
            Controls.Add(lblTitulo);
            Controls.Add(gpbBuscarTrabajador);
            Controls.Add(gpbDatosTrabajador);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(108, 117, 125);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAsignacionHorarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Assistence";
            gpbHorario.ResumeLayout(false);
            gpbHorario.PerformLayout();
            gpbBuscarTrabajador.ResumeLayout(false);
            gpbBuscarTrabajador.PerformLayout();
            gpbDatosTrabajador.ResumeLayout(false);
            gpbDatosTrabajador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label lblDias;
        private CheckBox chkViernes;
        private CheckBox chkJueves;
        private CheckBox chkMiercoles;
        private CheckBox chkMartes;
        private CheckBox chkLunes;
        private Label lblHoraSalida;
        private DateTimePicker dtpHoraSalida;
        private Label lblHoraEntrada;
        private DateTimePicker dtpHoraEntrada;
        private Button btnCancelar;
        private GroupBox gpbHorario;
        private Label lblTitulo;
        private ComboBox cmbSemestre;
        private TextBox txtPuesto;
        private TextBox txtNombreCompleto;
        private Label lblPuesto;
        private Label lblDepartamento;
        private Label lblSemestre;
        private Label lblNombreCompleto;
        private Button btnBuscar;
        private TextBox txtBuscarClave;
        private Label lblClaveTrabajador;
        private GroupBox gpbBuscarTrabajador;
        private TextBox txtDepartamento;
        private GroupBox gpbDatosTrabajador;
    }
}
