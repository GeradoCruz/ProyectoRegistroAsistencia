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
        // Layout: gpbOpciones = tipo de reporte, gpbFiltros = fechas/depto/apellidos,
        // dgvReporte = resultados, btnPdf/Excel = acciones abajo a la derecha.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cmbDepartamento = new ComboBox();
            lblDepartamento = new Label();
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
            rdbAsistencia = new RadioButton();
            rdbAntiguedad = new RadioButton();
            rdbSinHorario = new RadioButton();
            gpbOpciones = new GroupBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            btnLimpiar = new Button();
            gpbFiltros = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.Anchor = AnchorStyles.Top;
            cmbDepartamento.BackColor = Color.White;
            cmbDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(460, 213);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(180, 29);
            cmbDepartamento.TabIndex = 27;
            // 
            // lblDepartamento
            // 
            lblDepartamento.Anchor = AnchorStyles.Top;
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(461, 190);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 26;
            lblDepartamento.Text = "Departamento:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Top;
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Location = new Point(245, 213);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(180, 29);
            dtpFechaFin.TabIndex = 25;
            // 
            // lblFechaFin
            // 
            lblFechaFin.Anchor = AnchorStyles.Top;
            lblFechaFin.AutoSize = true;
            lblFechaFin.ForeColor = Color.FromArgb(108, 117, 125);
            lblFechaFin.Location = new Point(246, 190);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(52, 21);
            lblFechaFin.TabIndex = 24;
            lblFechaFin.Text = "Hasta:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Top;
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(30, 213);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(180, 29);
            dtpFechaInicio.TabIndex = 23;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.Anchor = AnchorStyles.Top;
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = Color.FromArgb(108, 117, 125);
            lblFechaInicio.Location = new Point(31, 190);
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
            lblSubtitulo.Location = new Point(194, 50);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(692, 25);
            lblSubtitulo.TabIndex = 21;
            lblSubtitulo.Text = "Consulta y genera reportes de asistencia, antigüedad y horarios del personal";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(275, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(447, 30);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Reportes del Sistema";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerar.BackColor = Color.FromArgb(43, 76, 140);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Image = (Image)resources.GetObject("btnGenerar.Image");
            btnGenerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerar.Location = new Point(876, 192);
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
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvReporte.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 45, 92);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporte.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 32, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.GridColor = Color.FromArgb(221, 225, 232);
            dgvReporte.Location = new Point(10, 272);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowTemplate.Height = 40;
            dgvReporte.Size = new Size(1046, 377);
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
            btnPdf.Click += btnPdf_Click;
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
            btnExcel.Click += btnExcel_Click;
            //
            // rdbAsistencia
            // 
            rdbAsistencia.Anchor = AnchorStyles.Top;
            rdbAsistencia.AutoSize = true;
            rdbAsistencia.Checked = true;
            rdbAsistencia.ForeColor = Color.FromArgb(108, 117, 125);
            rdbAsistencia.Location = new Point(40, 118);
            rdbAsistencia.Name = "rdbAsistencia";
            rdbAsistencia.Size = new Size(196, 25);
            rdbAsistencia.TabIndex = 35;
            rdbAsistencia.TabStop = true;
            rdbAsistencia.Text = "Asistencia y Puntualidad";
            rdbAsistencia.UseVisualStyleBackColor = true;
            // 
            // rdbAntiguedad
            // 
            rdbAntiguedad.Anchor = AnchorStyles.Top;
            rdbAntiguedad.AutoSize = true;
            rdbAntiguedad.ForeColor = Color.FromArgb(108, 117, 125);
            rdbAntiguedad.Location = new Point(280, 118);
            rdbAntiguedad.Name = "rdbAntiguedad";
            rdbAntiguedad.Size = new Size(192, 25);
            rdbAntiguedad.TabIndex = 37;
            rdbAntiguedad.Text = "Antigüedad de Personal";
            rdbAntiguedad.UseVisualStyleBackColor = true;
            // 
            // rdbSinHorario
            // 
            rdbSinHorario.Anchor = AnchorStyles.Top;
            rdbSinHorario.AutoSize = true;
            rdbSinHorario.ForeColor = Color.FromArgb(108, 117, 125);
            rdbSinHorario.Location = new Point(510, 118);
            rdbSinHorario.Name = "rdbSinHorario";
            rdbSinHorario.Size = new Size(254, 25);
            rdbSinHorario.TabIndex = 43;
            rdbSinHorario.Text = "Empleados sin Horario Asignado";
            rdbSinHorario.UseVisualStyleBackColor = true;
            // 
            // gpbOpciones
            // 
            gpbOpciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpbOpciones.ForeColor = Color.FromArgb(108, 117, 125);
            gpbOpciones.Location = new Point(10, 90);
            gpbOpciones.Name = "gpbOpciones";
            gpbOpciones.Size = new Size(856, 62);
            gpbOpciones.TabIndex = 38;
            gpbOpciones.TabStop = false;
            gpbOpciones.Text = "Tipo de Reporte";
            // 
            // lblApellidos
            // 
            lblApellidos.Anchor = AnchorStyles.Top;
            lblApellidos.AutoSize = true;
            lblApellidos.ForeColor = Color.FromArgb(108, 117, 125);
            lblApellidos.Location = new Point(677, 190);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(77, 21);
            lblApellidos.TabIndex = 39;
            lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.Top;
            txtApellidos.ForeColor = Color.FromArgb(64, 64, 64);
            txtApellidos.Location = new Point(674, 213);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(180, 29);
            txtApellidos.TabIndex = 40;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(43, 76, 140);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(876, 143);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 41;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gpbFiltros
            // 
            gpbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpbFiltros.ForeColor = Color.FromArgb(108, 117, 125);
            gpbFiltros.Location = new Point(10, 166);
            gpbFiltros.Name = "gpbFiltros";
            gpbFiltros.Size = new Size(856, 92);
            gpbFiltros.TabIndex = 42;
            gpbFiltros.TabStop = false;
            gpbFiltros.Text = "Filtros de Búsqueda";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 719);
            Controls.Add(btnLimpiar);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(rdbSinHorario);
            Controls.Add(rdbAntiguedad);
            Controls.Add(rdbAsistencia);
            Controls.Add(btnExcel);
            Controls.Add(btnPdf);
            Controls.Add(cmbDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(dtpFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(btnGenerar);
            Controls.Add(dgvReporte);
            Controls.Add(gpbOpciones);
            Controls.Add(gpbFiltros);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmReportes";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDepartamento;
        private Label lblDepartamento;
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
        private RadioButton rdbAsistencia;
        private RadioButton rdbAntiguedad;
        private RadioButton rdbSinHorario;
        private GroupBox gpbOpciones;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Button btnLimpiar;
        private GroupBox gpbFiltros;
    }
}
