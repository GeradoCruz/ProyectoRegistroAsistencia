namespace ProyectoRegistroAsistencia
{
    partial class frmHorarioSemanal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarioSemanal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblDepartamento = new Label();
            cmbDepartamento = new ComboBox();
            btnBuscar = new Button();
            btnAsignarHorario = new Button();
            dgvHorarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(341, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(177, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Horario Semanal";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(217, 81);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(366, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Gestión de los horarios de cada empleado";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(5, 127);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 5;
            lblDepartamento.Text = "Departamento:";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.BackColor = Color.White;
            cmbDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(5, 154);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(200, 29);
            cmbDepartamento.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(504, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAsignarHorario
            // 
            btnAsignarHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAsignarHorario.BackColor = Color.FromArgb(43, 76, 140);
            btnAsignarHorario.ForeColor = Color.White;
            btnAsignarHorario.Image = (Image)resources.GetObject("btnAsignarHorario.Image");
            btnAsignarHorario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsignarHorario.Location = new Point(701, 143);
            btnAsignarHorario.Name = "btnAsignarHorario";
            btnAsignarHorario.Size = new Size(180, 40);
            btnAsignarHorario.TabIndex = 11;
            btnAsignarHorario.Text = "Asignar Horario";
            btnAsignarHorario.UseVisualStyleBackColor = false;
            // 
            // dgvHorarios
            // 
            dgvHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHorarios.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvHorarios.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 76, 140);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHorarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHorarios.Location = new Point(3, 210);
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.Size = new Size(878, 454);
            dgvHorarios.TabIndex = 12;
            // 
            // frmHorarioSemanal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(886, 749);
            Controls.Add(dgvHorarios);
            Controls.Add(btnAsignarHorario);
            Controls.Add(btnBuscar);
            Controls.Add(cmbDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmHorarioSemanal";
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblDepartamento;
        private ComboBox cmbDepartamento;
        private Button btnBuscar;
        private Button btnAsignarHorario;
        private DataGridView dgvHorarios;
    }
}