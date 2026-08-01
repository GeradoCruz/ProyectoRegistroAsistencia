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
        // dgvReporte = resultados, btnPdf/Excel/Imprimir = acciones abajo a la derecha.
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
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
            btnImprimir = new Button();
            rdbAsistencia = new RadioButton();
            rdbIncidencias = new RadioButton();
            gpbOpciones = new GroupBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            btnLimpiar = new Button();
            gpbFiltros = new GroupBox();
            toolTipInfo = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.BackColor = Color.White;
            cmbDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(460, 207);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(190, 29);
            cmbDepartamento.TabIndex = 27;
            toolTipInfo.SetToolTip(cmbDepartamento, "Filtra el reporte por departamento (opcional).");
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(461, 184);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 26;
            lblDepartamento.Text = "Departamento:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Location = new Point(245, 207);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(180, 29);
            dtpFechaFin.TabIndex = 25;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.ForeColor = Color.FromArgb(108, 117, 125);
            lblFechaFin.Location = new Point(246, 184);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(52, 21);
            lblFechaFin.TabIndex = 24;
            lblFechaFin.Text = "Hasta:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(30, 207);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(180, 29);
            dtpFechaInicio.TabIndex = 23;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = Color.FromArgb(108, 117, 125);
            lblFechaInicio.Location = new Point(31, 184);
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
            lblSubtitulo.Location = new Point(318, 56);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(326, 25);
            lblSubtitulo.TabIndex = 21;
            lblSubtitulo.Text = "Consulte el resumen de asistencias";
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
            lblTitulo.Text = "Reportes de Asistencia";
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
            toolTipInfo.SetToolTip(btnGenerar, "Consulta el reporte con los filtros seleccionados.");
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
            btnImprimir.Click += btnImprimir_Click;
            // 
            // rdbAsistencia
            // 
            rdbAsistencia.AutoSize = true;
            rdbAsistencia.Checked = true;
            rdbAsistencia.ForeColor = Color.FromArgb(108, 117, 125);
            rdbAsistencia.Location = new Point(200, 118);
            rdbAsistencia.Name = "rdbAsistencia";
            rdbAsistencia.Size = new Size(196, 25);
            rdbAsistencia.TabIndex = 35;
            rdbAsistencia.TabStop = true;
            rdbAsistencia.Text = "Asistencia y Puntualidad";
            toolTipInfo.SetToolTip(rdbAsistencia, "Muestra, por trabajador, los días puntuales, con retardo y con falta en el rango de fechas.");
            rdbAsistencia.UseVisualStyleBackColor = true;
            // 
            // rdbIncidencias
            // 
            rdbIncidencias.AutoSize = true;
            rdbIncidencias.ForeColor = Color.FromArgb(108, 117, 125);
            rdbIncidencias.Location = new Point(470, 118);
            rdbIncidencias.Name = "rdbIncidencias";
            rdbIncidencias.Size = new Size(205, 25);
            rdbIncidencias.TabIndex = 36;
            rdbIncidencias.Text = "Incidencias por Empleado";
            toolTipInfo.SetToolTip(rdbIncidencias, "Muestra incidencias registradas por trabajador, justificadas y sin justificar.");
            rdbIncidencias.UseVisualStyleBackColor = true;
            // 
            // gpbOpciones
            // 
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
            lblApellidos.AutoSize = true;
            lblApellidos.ForeColor = Color.FromArgb(108, 117, 125);
            lblApellidos.Location = new Point(686, 184);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(77, 21);
            lblApellidos.TabIndex = 39;
            lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            txtApellidos.ForeColor = Color.FromArgb(64, 64, 64);
            txtApellidos.Location = new Point(685, 207);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(160, 29);
            txtApellidos.TabIndex = 40;
            toolTipInfo.SetToolTip(txtApellidos, "Filtra por apellido paterno o materno (no distingue mayúsculas/minúsculas).");
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(876, 143);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 41;
            btnLimpiar.Text = "Limpiar";
            toolTipInfo.SetToolTip(btnLimpiar, "Restablece todos los filtros a sus valores por defecto.");
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gpbFiltros
            // 
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
            Controls.Add(rdbIncidencias);
            Controls.Add(rdbAsistencia);
            Controls.Add(btnImprimir);
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
        private Button btnImprimir;
        private RadioButton rdbAsistencia;
        private RadioButton rdbIncidencias;
        private GroupBox gpbOpciones;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Button btnLimpiar;
        private GroupBox gpbFiltros;
        private ToolTip toolTipInfo;
    }
}
