namespace ProyectoRegistroAsistencia
{
    partial class frmIncidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncidencias));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            txtNombreTrabajador = new TextBox();
            lblNombreTrabajador = new Label();
            lblTipoIncidencia = new Label();
            cmbTipoIncidencia = new ComboBox();
            btnBuscar = new Button();
            dgvIncidencias = new DataGridView();
            btnJustificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIncidencias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(320, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(304, 30);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Incidencias";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(109, 52);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(790, 41);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Consulte todas las incidencias de un empleado en una fecha especifica";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(14, 126);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.FromArgb(108, 117, 125);
            lblFecha.Location = new Point(16, 95);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 21);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            // 
            // txtNombreTrabajador
            // 
            txtClaveTrabajador.BackColor = Color.White;
            txtClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            txtClaveTrabajador.Location = new Point(223, 126);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(200, 29);
            txtClaveTrabajador.TabIndex = 9;
            // 
            // lblNombreTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(225, 95);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(150, 21);
            lblClaveTrabajador.TabIndex = 8;
            lblClaveTrabajador.Text = "Clave de Trabajador:";
            // 
            // lblTipoIncidencia
            // 
            lblTipoIncidencia.AutoSize = true;
            lblTipoIncidencia.ForeColor = Color.FromArgb(108, 117, 125);
            lblTipoIncidencia.Location = new Point(434, 95);
            lblTipoIncidencia.Name = "lblTipoIncidencia";
            lblTipoIncidencia.Size = new Size(134, 21);
            lblTipoIncidencia.TabIndex = 10;
            lblTipoIncidencia.Text = "Tipo de Incidencia";
            // 
            // cmbTipoIncidencia
            // 
            cmbTipoIncidencia.BackColor = Color.White;
            cmbTipoIncidencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoIncidencia.ForeColor = Color.FromArgb(108, 117, 125);
            cmbTipoIncidencia.FormattingEnabled = true;
            cmbTipoIncidencia.Location = new Point(432, 126);
            cmbTipoIncidencia.Name = "cmbTipoIncidencia";
            cmbTipoIncidencia.Size = new Size(200, 29);
            cmbTipoIncidencia.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(877, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvIncidencias
            // 
            dgvIncidencias.AllowUserToAddRows = false;
            dgvIncidencias.AllowUserToDeleteRows = false;
            dgvIncidencias.AllowUserToResizeColumns = false;
            dgvIncidencias.AllowUserToResizeRows = false;
            dgvIncidencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIncidencias.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvIncidencias.BorderStyle = BorderStyle.None;
            dgvIncidencias.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvIncidencias.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 45, 92);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvIncidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvIncidencias.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 32, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvIncidencias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvIncidencias.EnableHeadersVisualStyles = false;
            dgvIncidencias.GridColor = Color.FromArgb(221, 225, 232);
            dgvIncidencias.Location = new Point(12, 171);
            dgvIncidencias.MultiSelect = false;
            dgvIncidencias.Name = "dgvIncidencias";
            dgvIncidencias.ReadOnly = true;
            dgvIncidencias.RowHeadersVisible = false;
            dgvIncidencias.RowTemplate.Height = 40;
            dgvIncidencias.Size = new Size(1044, 427);
            dgvIncidencias.TabIndex = 17;
            // 
            // btnJustificar
            // 
            btnJustificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnJustificar.BackColor = Color.FromArgb(43, 76, 140);
            btnJustificar.ForeColor = Color.White;
            btnJustificar.Image = (Image)resources.GetObject("btnJustificar.Image");
            btnJustificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnJustificar.Location = new Point(884, 610);
            btnJustificar.Name = "btnJustificar";
            btnJustificar.Size = new Size(180, 40);
            btnJustificar.TabIndex = 18;
            btnJustificar.Text = "Justificar";
            btnJustificar.UseVisualStyleBackColor = false;
            btnJustificar.Click += btnJustificar_Click;
            // 
            // frmIncidencias
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 659);
            Controls.Add(btnJustificar);
            Controls.Add(dgvIncidencias);
            Controls.Add(btnBuscar);
            Controls.Add(cmbTipoIncidencia);
            Controls.Add(lblTipoIncidencia);
            Controls.Add(txtNombreTrabajador);
            Controls.Add(lblNombreTrabajador);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmIncidencias";
            ((System.ComponentModel.ISupportInitialize)dgvIncidencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private TextBox txtNombreTrabajador;
        private Label lblNombreTrabajador;
        private Label lblTipoIncidencia;
        private ComboBox cmbTipoIncidencia;
        private Button btnBuscar;
        private DataGridView dgvIncidencias;
        private Button btnJustificar;
    }
}
