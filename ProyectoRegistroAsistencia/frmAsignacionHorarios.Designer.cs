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
            grpBuscarTrabajador = new GroupBox();
            btnBuscar = new Button();
            txtBusacarClave = new TextBox();
            lblClaveTrabaj = new Label();
            grpDatosTrabajador = new GroupBox();
            cmbSemestre = new ComboBox();
            txtPuesto = new TextBox();
            txtDepartamento = new TextBox();
            txtBuscarNombreCompleto = new TextBox();
            lblPuesto = new Label();
            lblDepartamento = new Label();
            lblSemestre = new Label();
            lblNombreCompleto = new Label();
            lblTitulo = new Label();
            grpHorario = new GroupBox();
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            grpBuscarTrabajador.SuspendLayout();
            grpDatosTrabajador.SuspendLayout();
            grpHorario.SuspendLayout();
            SuspendLayout();
            // 
            // grpBuscarTrabajador
            // 
            grpBuscarTrabajador.Controls.Add(btnBuscar);
            grpBuscarTrabajador.Controls.Add(txtBusacarClave);
            grpBuscarTrabajador.Controls.Add(lblClaveTrabaj);
            grpBuscarTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBuscarTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            grpBuscarTrabajador.Location = new Point(14, 49);
            grpBuscarTrabajador.Margin = new Padding(3, 4, 3, 4);
            grpBuscarTrabajador.Name = "grpBuscarTrabajador";
            grpBuscarTrabajador.Padding = new Padding(3, 4, 3, 4);
            grpBuscarTrabajador.Size = new Size(526, 116);
            grpBuscarTrabajador.TabIndex = 0;
            grpBuscarTrabajador.TabStop = false;
            grpBuscarTrabajador.Text = "Buscar Trabajador";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(282, 51);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(206, 53);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusacarClave
            // 
            txtBusacarClave.Location = new Point(21, 65);
            txtBusacarClave.Margin = new Padding(3, 4, 3, 4);
            txtBusacarClave.Name = "txtBusacarClave";
            txtBusacarClave.Size = new Size(171, 34);
            txtBusacarClave.TabIndex = 1;
            // 
            // lblClaveTrabaj
            // 
            lblClaveTrabaj.AutoSize = true;
            lblClaveTrabaj.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabaj.Location = new Point(21, 33);
            lblClaveTrabaj.Name = "lblClaveTrabaj";
            lblClaveTrabaj.Size = new Size(193, 28);
            lblClaveTrabaj.TabIndex = 0;
            lblClaveTrabaj.Text = "Clave del Trabajador:";
            // 
            // grpDatosTrabajador
            // 
            grpDatosTrabajador.Controls.Add(cmbSemestre);
            grpDatosTrabajador.Controls.Add(txtPuesto);
            grpDatosTrabajador.Controls.Add(txtDepartamento);
            grpDatosTrabajador.Controls.Add(txtBuscarNombreCompleto);
            grpDatosTrabajador.Controls.Add(lblPuesto);
            grpDatosTrabajador.Controls.Add(lblDepartamento);
            grpDatosTrabajador.Controls.Add(lblSemestre);
            grpDatosTrabajador.Controls.Add(lblNombreCompleto);
            grpDatosTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            grpDatosTrabajador.Location = new Point(14, 173);
            grpDatosTrabajador.Margin = new Padding(3, 4, 3, 4);
            grpDatosTrabajador.Name = "grpDatosTrabajador";
            grpDatosTrabajador.Padding = new Padding(3, 4, 3, 4);
            grpDatosTrabajador.Size = new Size(526, 193);
            grpDatosTrabajador.TabIndex = 1;
            grpDatosTrabajador.TabStop = false;
            grpDatosTrabajador.Text = "Datos Del Trabajador";
            // 
            // cmbSemestre
            // 
            cmbSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestre.FormattingEnabled = true;
            cmbSemestre.Location = new Point(282, 65);
            cmbSemestre.Name = "cmbSemestre";
            cmbSemestre.Size = new Size(228, 36);
            cmbSemestre.TabIndex = 8;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(282, 140);
            txtPuesto.Margin = new Padding(3, 4, 3, 4);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.ReadOnly = true;
            txtPuesto.Size = new Size(228, 34);
            txtPuesto.TabIndex = 7;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(21, 140);
            txtDepartamento.Margin = new Padding(3, 4, 3, 4);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.ReadOnly = true;
            txtDepartamento.Size = new Size(228, 34);
            txtDepartamento.TabIndex = 6;
            // 
            // txtBuscarNombreCompleto
            // 
            txtBuscarNombreCompleto.Location = new Point(21, 65);
            txtBuscarNombreCompleto.Margin = new Padding(3, 4, 3, 4);
            txtBuscarNombreCompleto.Name = "txtBuscarNombreCompleto";
            txtBuscarNombreCompleto.ReadOnly = true;
            txtBuscarNombreCompleto.Size = new Size(228, 34);
            txtBuscarNombreCompleto.TabIndex = 4;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.ForeColor = Color.FromArgb(108, 117, 125);
            lblPuesto.Location = new Point(282, 108);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(75, 28);
            lblPuesto.TabIndex = 3;
            lblPuesto.Text = "Puesto:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(21, 108);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(143, 28);
            lblDepartamento.TabIndex = 2;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.ForeColor = Color.FromArgb(108, 117, 125);
            lblSemestre.Location = new Point(282, 33);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(96, 28);
            lblSemestre.TabIndex = 1;
            lblSemestre.Text = "Semestre:";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombreCompleto.Location = new Point(21, 33);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(181, 28);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(161, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(304, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Asignacion de Horario";
            // 
            // grpHorario
            // 
            grpHorario.Controls.Add(lblDias);
            grpHorario.Controls.Add(chkViernes);
            grpHorario.Controls.Add(chkJueves);
            grpHorario.Controls.Add(chkMiercoles);
            grpHorario.Controls.Add(chkMartes);
            grpHorario.Controls.Add(chkLunes);
            grpHorario.Controls.Add(lblHoraSalida);
            grpHorario.Controls.Add(dtpHoraSalida);
            grpHorario.Controls.Add(lblHoraEntrada);
            grpHorario.Controls.Add(dtpHoraEntrada);
            grpHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpHorario.ForeColor = Color.FromArgb(108, 117, 125);
            grpHorario.Location = new Point(14, 375);
            grpHorario.Margin = new Padding(3, 4, 3, 4);
            grpHorario.Name = "grpHorario";
            grpHorario.Padding = new Padding(3, 4, 3, 4);
            grpHorario.Size = new Size(526, 237);
            grpHorario.TabIndex = 3;
            grpHorario.TabStop = false;
            grpHorario.Text = "Horario";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.ForeColor = Color.FromArgb(108, 117, 125);
            lblDias.Location = new Point(21, 184);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(53, 28);
            lblDias.TabIndex = 9;
            lblDias.Text = "Dias:";
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkViernes.Location = new Point(391, 191);
            chkViernes.Margin = new Padding(3, 4, 3, 4);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(76, 23);
            chkViernes.TabIndex = 8;
            chkViernes.Text = "Viernes";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkJueves.Location = new Point(317, 191);
            chkJueves.Margin = new Padding(3, 4, 3, 4);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(71, 23);
            chkJueves.TabIndex = 7;
            chkJueves.Text = "Jueves";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkMiercoles.Location = new Point(224, 191);
            chkMiercoles.Margin = new Padding(3, 4, 3, 4);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(89, 23);
            chkMiercoles.TabIndex = 6;
            chkMiercoles.Text = "Miercoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkMartes.Location = new Point(147, 189);
            chkMartes.Margin = new Padding(3, 4, 3, 4);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(74, 23);
            chkMartes.TabIndex = 5;
            chkMartes.Text = "Martes";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLunes.Location = new Point(77, 191);
            chkLunes.Margin = new Padding(3, 4, 3, 4);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(67, 23);
            chkLunes.TabIndex = 4;
            chkLunes.Text = "Lunes";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.ForeColor = Color.FromArgb(108, 117, 125);
            lblHoraSalida.Location = new Point(21, 105);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(140, 28);
            lblHoraSalida.TabIndex = 3;
            lblHoraSalida.Text = "Hora de Salida";
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new Point(21, 137);
            dtpHoraSalida.Margin = new Padding(3, 4, 3, 4);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new Size(139, 34);
            dtpHoraSalida.TabIndex = 2;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.ForeColor = Color.FromArgb(108, 117, 125);
            lblHoraEntrada.Location = new Point(21, 31);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(154, 28);
            lblHoraEntrada.TabIndex = 1;
            lblHoraEntrada.Text = "Hora de Entrada";
            // 
            // dtpHoraEntrada
            // 
            dtpHoraEntrada.Format = DateTimePickerFormat.Time;
            dtpHoraEntrada.Location = new Point(21, 63);
            dtpHoraEntrada.Margin = new Padding(3, 4, 3, 4);
            dtpHoraEntrada.Name = "dtpHoraEntrada";
            dtpHoraEntrada.ShowUpDown = true;
            dtpHoraEntrada.Size = new Size(139, 34);
            dtpHoraEntrada.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(11, 633);
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
            btnCancelar.Location = new Point(335, 633);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 53);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAsignacionHorarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(553, 709);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpHorario);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosTrabajador);
            Controls.Add(grpBuscarTrabajador);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAsignacionHorarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Staff Asistence";
            grpBuscarTrabajador.ResumeLayout(false);
            grpBuscarTrabajador.PerformLayout();
            grpDatosTrabajador.ResumeLayout(false);
            grpDatosTrabajador.PerformLayout();
            grpHorario.ResumeLayout(false);
            grpHorario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBuscarTrabajador;
        private GroupBox grpDatosTrabajador;
        private Label lblTitulo;
        private Button btnBuscar;
        private TextBox txtBusacarClave;
        private Label lblClaveTrabaj;
        private TextBox txtPuesto;
        private TextBox txtDepartamento;
        private TextBox txtBuscarNombreCompleto;
        private Label lblPuesto;
        private Label lblDepartamento;
        private Label lblSemestre;
        private Label lblNombreCompleto;
        private GroupBox grpHorario;
        private Button btnGuardar;
        private Button btnCancelar;
        private DateTimePicker dtpHoraSalida;
        private Label lblHoraEntrada;
        private DateTimePicker dtpHoraEntrada;
        private Label lblHoraSalida;
        private CheckBox chkViernes;
        private CheckBox chkJueves;
        private CheckBox chkMiercoles;
        private CheckBox chkMartes;
        private CheckBox chkLunes;
        private Label lblDias;
        private ComboBox cmbSemestre;
    }
}
