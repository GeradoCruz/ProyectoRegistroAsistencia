namespace ProyectoRegistroAsistencia
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cmbDepartamento = new ComboBox();
            lblDepartamento = new Label();
            txtClaveTrabajador = new TextBox();
            lblClaveTrabajador = new Label();
            dtpFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaInicio = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            btnGenerar = new Button();
            dgvReporte = new DataGridView();
            btnPdf = new Button();
            btnExcel = new Button();
            btnImprimir = new Button();
            rdbSemanal = new RadioButton();
            rdbMensual = new RadioButton();
            rdbHistorial = new RadioButton();
            gpbOpciones = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.BackColor = Color.White;
            cmbDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(661, 178);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(200, 29);
            cmbDepartamento.TabIndex = 29;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(661, 154);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 28;
            lblDepartamento.Text = "Departamento:";
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.BackColor = Color.White;
            txtClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            txtClaveTrabajador.Location = new Point(444, 178);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(200, 29);
            txtClaveTrabajador.TabIndex = 27;
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(446, 154);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(150, 21);
            lblClaveTrabajador.TabIndex = 26;
            lblClaveTrabajador.Text = "Clave de Trabajador:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Location = new Point(227, 178);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 29);
            dtpFechaFin.TabIndex = 25;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.ForeColor = Color.FromArgb(108, 117, 125);
            lblFechaFin.Location = new Point(227, 154);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(52, 21);
            lblFechaFin.TabIndex = 24;
            lblFechaFin.Text = "Hasta:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(10, 178);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 29);
            dtpFechaInicio.TabIndex = 23;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = Color.FromArgb(108, 117, 125);
            lblFechaInicio.Location = new Point(10, 154);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(56, 21);
            lblFechaInicio.TabIndex = 22;
            lblFechaInicio.Text = "Desde:";
            lblFechaInicio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(172, 53);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(621, 25);
            lblSubtitulo.TabIndex = 21;
            lblSubtitulo.Text = "Consulte el resumen de asistencias";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(216, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(506, 30);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Reportes Semanal/Mensuales de Asistencia";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerar.BackColor = Color.FromArgb(43, 76, 140);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Image = (Image)resources.GetObject("btnGenerar.Image");
            btnGenerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerar.Location = new Point(876, 171);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(180, 40);
            btnGenerar.TabIndex = 31;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AllowUserToResizeColumns = false;
            dgvReporte.AllowUserToResizeRows = false;
            dgvReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporte.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvReporte.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 76, 140);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.Location = new Point(10, 220);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowTemplate.Height = 40;
            dgvReporte.Size = new Size(1046, 429);
            dgvReporte.TabIndex = 30;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPdf.BackColor = Color.FromArgb(43, 76, 140);
            btnPdf.ForeColor = Color.White;
            btnPdf.Image = (Image)resources.GetObject("btnPdf.Image");
            btnPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnPdf.Location = new Point(878, 657);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(180, 40);
            btnPdf.TabIndex = 32;
            btnPdf.Text = "Exportar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcel.BackColor = Color.FromArgb(43, 76, 140);
            btnExcel.ForeColor = Color.White;
            btnExcel.Image = (Image)resources.GetObject("btnExcel.Image");
            btnExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcel.Location = new Point(692, 657);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(180, 40);
            btnExcel.TabIndex = 33;
            btnExcel.Text = "Exportar Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.BackColor = Color.FromArgb(43, 76, 140);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(506, 657);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(180, 40);
            btnImprimir.TabIndex = 34;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // rdbSemanal
            // 
            rdbSemanal.AutoSize = true;
            rdbSemanal.Location = new Point(191, 109);
            rdbSemanal.Name = "rdbSemanal";
            rdbSemanal.Size = new Size(161, 25);
            rdbSemanal.TabIndex = 35;
            rdbSemanal.TabStop = true;
            rdbSemanal.Text = "Asistencia Semanal";
            rdbSemanal.UseVisualStyleBackColor = true;
            // 
            // rdbMensual
            // 
            rdbMensual.AutoSize = true;
            rdbMensual.Location = new Point(390, 109);
            rdbMensual.Name = "rdbMensual";
            rdbMensual.Size = new Size(235, 25);
            rdbMensual.TabIndex = 36;
            rdbMensual.TabStop = true;
            rdbMensual.Text = "Tardanzas y Faltas(Mensuales)";
            rdbMensual.UseVisualStyleBackColor = true;
            // 
            // rdbHistorial
            // 
            rdbHistorial.AutoSize = true;
            rdbHistorial.Location = new Point(651, 109);
            rdbHistorial.Name = "rdbHistorial";
            rdbHistorial.Size = new Size(158, 25);
            rdbHistorial.TabIndex = 37;
            rdbHistorial.TabStop = true;
            rdbHistorial.Text = "Historial Individual";
            rdbHistorial.UseVisualStyleBackColor = true;
            // 
            // gpbOpciones
            // 
            gpbOpciones.Location = new Point(184, 84);
            gpbOpciones.Name = "gpbOpciones";
            gpbOpciones.Size = new Size(653, 59);
            gpbOpciones.TabIndex = 38;
            gpbOpciones.TabStop = false;
            gpbOpciones.Text = "Opciones";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 719);
            Controls.Add(rdbHistorial);
            Controls.Add(rdbMensual);
            Controls.Add(rdbSemanal);
            Controls.Add(btnImprimir);
            Controls.Add(btnExcel);
            Controls.Add(btnPdf);
            Controls.Add(cmbDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(txtClaveTrabajador);
            Controls.Add(lblClaveTrabajador);
            Controls.Add(dtpFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(btnGenerar);
            Controls.Add(dgvReporte);
            Controls.Add(gpbOpciones);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDepartamento;
        private Label lblDepartamento;
        private TextBox txtClaveTrabajador;
        private Label lblClaveTrabajador;
        private DateTimePicker dtpFechaFin;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaInicio;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Button btnGenerar;
        private DataGridView dgvReporte;
        private Button btnPdf;
        private Button btnExcel;
        private Button btnImprimir;
        private RadioButton rdbSemanal;
        private RadioButton rdbMensual;
        private RadioButton rdbHistorial;
        private GroupBox gpbOpciones;
    }
}
