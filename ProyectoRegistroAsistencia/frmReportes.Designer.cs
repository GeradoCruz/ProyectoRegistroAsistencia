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
            tblReportes = new TabControl();
            tblSemana = new TabPage();
            btnPdf = new Button();
            btnExcel = new Button();
            btnImprimir = new Button();
            btnGenerar = new Button();
            dgvReporte = new DataGridView();
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
            tabPage2 = new TabPage();
            tblReportes.SuspendLayout();
            tblSemana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // tblReportes
            // 
            tblReportes.Controls.Add(tblSemana);
            tblReportes.Controls.Add(tabPage2);
            tblReportes.Dock = DockStyle.Fill;
            tblReportes.Location = new Point(0, 0);
            tblReportes.Name = "tblReportes";
            tblReportes.SelectedIndex = 0;
            tblReportes.Size = new Size(886, 749);
            tblReportes.TabIndex = 0;
            // 
            // tblSemana
            // 
            tblSemana.BackColor = Color.FromArgb(240, 242, 245);
            tblSemana.Controls.Add(btnPdf);
            tblSemana.Controls.Add(btnExcel);
            tblSemana.Controls.Add(btnImprimir);
            tblSemana.Controls.Add(btnGenerar);
            tblSemana.Controls.Add(dgvReporte);
            tblSemana.Controls.Add(cmbDepartamento);
            tblSemana.Controls.Add(lblDepartamento);
            tblSemana.Controls.Add(txtClaveTrabajador);
            tblSemana.Controls.Add(lblClaveTrabajador);
            tblSemana.Controls.Add(dtpFechaFin);
            tblSemana.Controls.Add(lblFechaFin);
            tblSemana.Controls.Add(dtpFechaInicio);
            tblSemana.Controls.Add(lblFechaInicio);
            tblSemana.Controls.Add(lblSubtitulo);
            tblSemana.Controls.Add(lblTitulo);
            tblSemana.Location = new Point(4, 30);
            tblSemana.Name = "tblSemana";
            tblSemana.Padding = new Padding(3);
            tblSemana.Size = new Size(878, 715);
            tblSemana.TabIndex = 0;
            tblSemana.Text = "Semanal";
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPdf.BackColor = Color.FromArgb(43, 76, 140);
            btnPdf.ForeColor = Color.White;
            btnPdf.Image = (Image)resources.GetObject("btnPdf.Image");
            btnPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnPdf.Location = new Point(696, 638);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(180, 40);
            btnPdf.TabIndex = 23;
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
            btnExcel.Location = new Point(510, 638);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(180, 40);
            btnExcel.TabIndex = 22;
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
            btnImprimir.Location = new Point(324, 638);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(180, 40);
            btnImprimir.TabIndex = 21;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerar.BackColor = Color.FromArgb(43, 76, 140);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Image = (Image)resources.GetObject("btnGenerar.Image");
            btnGenerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerar.Location = new Point(694, 142);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(180, 40);
            btnGenerar.TabIndex = 19;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // dgvReporte
            // 
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
            dgvReporte.Location = new Point(0, 185);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.Size = new Size(876, 450);
            dgvReporte.TabIndex = 18;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.BackColor = Color.White;
            cmbDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(674, 110);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(200, 29);
            cmbDepartamento.TabIndex = 16;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(674, 86);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 15;
            lblDepartamento.Text = "Departamento:";
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.BackColor = Color.White;
            txtClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            txtClaveTrabajador.Location = new Point(440, 110);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(200, 29);
            txtClaveTrabajador.TabIndex = 13;
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(442, 86);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(150, 21);
            lblClaveTrabajador.TabIndex = 12;
            lblClaveTrabajador.Text = "Clave de Trabajador:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Location = new Point(223, 110);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 29);
            dtpFechaFin.TabIndex = 11;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.ForeColor = Color.FromArgb(108, 117, 125);
            lblFechaFin.Location = new Point(223, 86);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(25, 21);
            lblFechaFin.TabIndex = 10;
            lblFechaFin.Text = "al:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(3, 110);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 29);
            dtpFechaInicio.TabIndex = 9;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = Color.FromArgb(108, 117, 125);
            lblFechaInicio.Location = new Point(3, 86);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(94, 21);
            lblFechaInicio.TabIndex = 8;
            lblFechaInicio.Text = "Semana del:";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(171, 43);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(438, 25);
            lblSubtitulo.TabIndex = 6;
            lblSubtitulo.Text = "Consulte el resumen de asistencias de una semana";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(215, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(323, 30);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Reportes Semanal de Asistencia";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(240, 242, 245);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(878, 721);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mensual";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(886, 749);
            Controls.Add(tblReportes);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmReportes";
            tblReportes.ResumeLayout(false);
            tblSemana.ResumeLayout(false);
            tblSemana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tblReportes;
        private TabPage tblSemana;
        private TabPage tabPage2;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private DateTimePicker dtpFechaFin;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaInicio;
        private TextBox txtClaveTrabajador;
        private Label lblClaveTrabajador;
        private ComboBox cmbDepartamento;
        private Label lblDepartamento;
        private DataGridView dgvReporte;
        private Button btnGenerar;
        private Button btnPdf;
        private Button btnExcel;
        private Button btnImprimir;
    }
}