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
            grpBuscarTrabajador = new GroupBox();
            btnBuscar = new Button();
            txtBusacarClave = new TextBox();
            lblClaveTrabaj = new Label();
            grpDatosTrabajador = new GroupBox();
            txtPuesto = new TextBox();
            txtDepartamento = new TextBox();
            txtSemestre = new TextBox();
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
            grpBuscarTrabajador.ForeColor = Color.FromArgb(43, 76, 140);
            grpBuscarTrabajador.Location = new Point(12, 37);
            grpBuscarTrabajador.Name = "grpBuscarTrabajador";
            grpBuscarTrabajador.Size = new Size(460, 87);
            grpBuscarTrabajador.TabIndex = 0;
            grpBuscarTrabajador.TabStop = false;
            grpBuscarTrabajador.Text = "Buscar Trabajador";
            //
            // btnBuscar
            //
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(293, 51);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 26);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            //
            // txtBusacarClave
            //
            txtBusacarClave.Location = new Point(18, 49);
            txtBusacarClave.Name = "txtBusacarClave";
            txtBusacarClave.Size = new Size(150, 29);
            txtBusacarClave.TabIndex = 1;
            //
            // lblClaveTrabaj
            //
            lblClaveTrabaj.AutoSize = true;
            lblClaveTrabaj.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabaj.Location = new Point(18, 25);
            lblClaveTrabaj.Name = "lblClaveTrabaj";
            lblClaveTrabaj.Size = new Size(154, 21);
            lblClaveTrabaj.TabIndex = 0;
            lblClaveTrabaj.Text = "Clave del Trabajador:";
            //
            // grpDatosTrabajador
            //
            grpDatosTrabajador.Controls.Add(txtPuesto);
            grpDatosTrabajador.Controls.Add(txtDepartamento);
            grpDatosTrabajador.Controls.Add(txtSemestre);
            grpDatosTrabajador.Controls.Add(txtBuscarNombreCompleto);
            grpDatosTrabajador.Controls.Add(lblPuesto);
            grpDatosTrabajador.Controls.Add(lblDepartamento);
            grpDatosTrabajador.Controls.Add(lblSemestre);
            grpDatosTrabajador.Controls.Add(lblNombreCompleto);
            grpDatosTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatosTrabajador.ForeColor = Color.FromArgb(43, 76, 140);
            grpDatosTrabajador.Location = new Point(12, 130);
            grpDatosTrabajador.Name = "grpDatosTrabajador";
            grpDatosTrabajador.Size = new Size(460, 145);
            grpDatosTrabajador.TabIndex = 1;
            grpDatosTrabajador.TabStop = false;
            grpDatosTrabajador.Text = "Datos Del Trabajador";
            //
            // txtPuesto
            //
            txtPuesto.Location = new Point(247, 105);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(200, 29);
            txtPuesto.TabIndex = 7;
            //
            // txtDepartamento
            //
            txtDepartamento.Location = new Point(18, 105);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(200, 29);
            txtDepartamento.TabIndex = 6;
            //
            // txtSemestre
            //
            txtSemestre.Location = new Point(247, 49);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(200, 29);
            txtSemestre.TabIndex = 5;
            //
            // txtBuscarNombreCompleto
            //
            txtBuscarNombreCompleto.Location = new Point(18, 49);
            txtBuscarNombreCompleto.Name = "txtBuscarNombreCompleto";
            txtBuscarNombreCompleto.Size = new Size(200, 29);
            txtBuscarNombreCompleto.TabIndex = 4;
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
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(43, 76, 140);
            lblTitulo.Location = new Point(141, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 30);
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
            grpHorario.ForeColor = Color.FromArgb(43, 76, 140);
            grpHorario.Location = new Point(12, 281);
            grpHorario.Name = "grpHorario";
            grpHorario.Size = new Size(460, 178);
            grpHorario.TabIndex = 3;
            grpHorario.TabStop = false;
            grpHorario.Text = "Horario";
            //
            // lblDias
            //
            lblDias.AutoSize = true;
            lblDias.ForeColor = Color.FromArgb(108, 117, 125);
            lblDias.Location = new Point(18, 138);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(43, 21);
            lblDias.TabIndex = 9;
            lblDias.Text = "Dias:";
            //
            // chkViernes
            //
            chkViernes.AutoSize = true;
            chkViernes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkViernes.Location = new Point(342, 143);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(64, 17);
            chkViernes.TabIndex = 8;
            chkViernes.Text = "Viernes";
            chkViernes.UseVisualStyleBackColor = true;
            //
            // chkJueves
            //
            chkJueves.AutoSize = true;
            chkJueves.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkJueves.Location = new Point(277, 143);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(59, 17);
            chkJueves.TabIndex = 7;
            chkJueves.Text = "Jueves";
            chkJueves.UseVisualStyleBackColor = true;
            //
            // chkMiercoles
            //
            chkMiercoles.AutoSize = true;
            chkMiercoles.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkMiercoles.Location = new Point(196, 143);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(75, 17);
            chkMiercoles.TabIndex = 6;
            chkMiercoles.Text = "Miercoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            //
            // chkMartes
            //
            chkMartes.AutoSize = true;
            chkMartes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkMartes.Location = new Point(129, 142);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(61, 17);
            chkMartes.TabIndex = 5;
            chkMartes.Text = "Martes";
            chkMartes.UseVisualStyleBackColor = true;
            //
            // chkLunes
            //
            chkLunes.AutoSize = true;
            chkLunes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLunes.Location = new Point(67, 143);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(56, 17);
            chkLunes.TabIndex = 4;
            chkLunes.Text = "Lunes";
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
            // btnGuardar
            //
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(12, 465);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 32);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(372, 465);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            //
            // frmAsignacionHorarios
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(484, 509);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpHorario);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosTrabajador);
            Controls.Add(grpBuscarTrabajador);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAsignacionHorarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Asignacion de Horario";
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
        private TextBox txtSemestre;
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
    }
}
