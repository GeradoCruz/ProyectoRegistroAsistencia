namespace ProyectoRegistroAsistencia
{
    partial class frmAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistencias));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblFecha = new Label();
            lblClaveTrabajador = new Label();
            dtpFiltroAsistencia = new DateTimePicker();
            txtApellido = new TextBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            dgvRegistros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(306, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(413, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Asistencias";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(139, 75);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(771, 25);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Consulte todos los registros de un empleado en una fecha especifica";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.FromArgb(108, 117, 125);
            lblFecha.Location = new Point(12, 144);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 21);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(220, 144);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(150, 21);
            lblClaveTrabajador.TabIndex = 3;
            lblClaveTrabajador.Text = "Apellido:";
            // 
            // dtpFiltroAsistencia
            // 
            dtpFiltroAsistencia.Format = DateTimePickerFormat.Custom;
            dtpFiltroAsistencia.Location = new Point(12, 168);
            dtpFiltroAsistencia.Name = "dtpFiltroAsistencia";
            dtpFiltroAsistencia.Size = new Size(200, 29);
            dtpFiltroAsistencia.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtClaveTrabajador.BackColor = Color.White;
            txtClaveTrabajador.Location = new Point(220, 168);
            txtClaveTrabajador.Name = "txtClaveTrabajador";
            txtClaveTrabajador.Size = new Size(200, 29);
            txtClaveTrabajador.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(43, 76, 140);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(690, 161);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(879, 161);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.AllowUserToResizeColumns = false;
            dgvRegistros.AllowUserToResizeRows = false;
            dgvRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistros.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvRegistros.BorderStyle = BorderStyle.None;
            dgvRegistros.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvRegistros.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 45, 92);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistros.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 32, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.GridColor = Color.FromArgb(221, 225, 232);
            dgvRegistros.Location = new Point(11, 217);
            dgvRegistros.MultiSelect = false;
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.RowTemplate.Height = 40;
            dgvRegistros.Size = new Size(1044, 427);
            dgvRegistros.TabIndex = 8;
            // 
            // frmAsistencias
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 659);
            Controls.Add(dgvRegistros);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtApellido);
            Controls.Add(dtpFiltroAsistencia);
            Controls.Add(lblClaveTrabajador);
            Controls.Add(lblFecha);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAsistencias";
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblFecha;
        private Label lblClaveTrabajador;
        private DateTimePicker dtpFiltroAsistencia;
        private TextBox txtApellido;
        private Button btnLimpiar;
        private Button btnBuscar;
        private DataGridView dgvRegistros;
    }
}
