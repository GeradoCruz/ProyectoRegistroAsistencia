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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblBienvenida = new Label();
            lblSubtitulo = new Label();
            lblFecha = new Label();
            lblClaveTrabajador = new Label();
            dtpFiltroAsistencia = new DateTimePicker();
            txtClaveTrabajador = new TextBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            dgvRegistros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(108, 117, 125);
            lblBienvenida.Location = new Point(148, 35);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(415, 30);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido Administrador: Kevin Solares";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(74, 77);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(589, 25);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Consulte todos los registros de un empleado en una fecha especifica";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.FromArgb(108, 117, 125);
            lblFecha.Location = new Point(6, 153);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 21);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblClaveTrabajador
            // 
            lblClaveTrabajador.AutoSize = true;
            lblClaveTrabajador.ForeColor = Color.FromArgb(108, 117, 125);
            lblClaveTrabajador.Location = new Point(214, 153);
            lblClaveTrabajador.Name = "lblClaveTrabajador";
            lblClaveTrabajador.Size = new Size(150, 21);
            lblClaveTrabajador.TabIndex = 3;
            lblClaveTrabajador.Text = "Clave de Trabajador:";
            // 
            // dtpFiltroAsistencia
            // 
            dtpFiltroAsistencia.Format = DateTimePickerFormat.Custom;
            dtpFiltroAsistencia.Location = new Point(6, 177);
            dtpFiltroAsistencia.Name = "dtpFiltroAsistencia";
            dtpFiltroAsistencia.Size = new Size(200, 29);
            dtpFiltroAsistencia.TabIndex = 4;
            // 
            // txtClaveTrabajador
            // 
            txtClaveTrabajador.BackColor = Color.White;
            txtClaveTrabajador.Location = new Point(214, 177);
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
            btnLimpiar.Location = new Point(506, 170);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(694, 170);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvRegistros
            // 
            dgvRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistros.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvRegistros.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 76, 140);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistros.Location = new Point(4, 233);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.Size = new Size(878, 454);
            dgvRegistros.TabIndex = 8;
            // 
            // frmAsistencias
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(886, 749);
            Controls.Add(dgvRegistros);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtClaveTrabajador);
            Controls.Add(dtpFiltroAsistencia);
            Controls.Add(lblClaveTrabajador);
            Controls.Add(lblFecha);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblBienvenida);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAsistencias";
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblSubtitulo;
        private Label lblFecha;
        private Label lblClaveTrabajador;
        private DateTimePicker dtpFiltroAsistencia;
        private TextBox txtClaveTrabajador;
        private Button btnLimpiar;
        private Button btnBuscar;
        private DataGridView dgvRegistros;
    }
}