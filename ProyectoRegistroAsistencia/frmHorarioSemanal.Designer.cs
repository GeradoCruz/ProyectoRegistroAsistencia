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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblDepartamento = new Label();
            cmbDepartamento = new ComboBox();
            btnAsignarHorario = new Button();
            dgvListaEmpleados = new DataGridView();
            btnLimpiar = new Button();
            dgvDiasHorarios = new DataGridView();
            txtApellido = new TextBox();
            lblNombreApellido = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiasHorarios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(341, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(359, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Horario Semanal";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(217, 67);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(548, 30);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Gestión de los horarios de cada empleado";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(12, 127);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(143, 28);
            lblDepartamento.TabIndex = 5;
            lblDepartamento.Text = "Departamento:";
            lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.BackColor = Color.White;
            cmbDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(12, 156);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(200, 36);
            cmbDepartamento.TabIndex = 6;
            cmbDepartamento.SelectionChangeCommitted += cmbDepartamento_SelectionChangeCommitted;
            // 
            // btnAsignarHorario
            // 
            btnAsignarHorario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAsignarHorario.BackColor = Color.FromArgb(43, 76, 140);
            btnAsignarHorario.ForeColor = Color.White;
            btnAsignarHorario.Image = (Image)resources.GetObject("btnAsignarHorario.Image");
            btnAsignarHorario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsignarHorario.Location = new Point(875, 143);
            btnAsignarHorario.Name = "btnAsignarHorario";
            btnAsignarHorario.Size = new Size(180, 40);
            btnAsignarHorario.TabIndex = 11;
            btnAsignarHorario.Text = "Asignar Horario";
            btnAsignarHorario.UseVisualStyleBackColor = false;
            btnAsignarHorario.Click += btnAsignarHorario_Click;
            // 
            // dgvListaEmpleados
            // 
            dgvListaEmpleados.AllowUserToAddRows = false;
            dgvListaEmpleados.AllowUserToDeleteRows = false;
            dgvListaEmpleados.AllowUserToResizeColumns = false;
            dgvListaEmpleados.AllowUserToResizeRows = false;
            dgvListaEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaEmpleados.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvListaEmpleados.BorderStyle = BorderStyle.None;
            dgvListaEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvListaEmpleados.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 45, 92);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaEmpleados.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListaEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListaEmpleados.EnableHeadersVisualStyles = false;
            dgvListaEmpleados.GridColor = Color.FromArgb(221, 225, 232);
            dgvListaEmpleados.Location = new Point(12, 204);
            dgvListaEmpleados.MultiSelect = false;
            dgvListaEmpleados.Name = "dgvListaEmpleados";
            dgvListaEmpleados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 45, 92);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListaEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListaEmpleados.RowHeadersVisible = false;
            dgvListaEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(28, 32, 51);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvHorarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvHorarios.RowTemplate.Height = 40;
            dgvHorarios.Size = new Size(551, 427);
            dgvHorarios.TabIndex = 12;
            dgvHorarios.CellClick += dgvHorarios_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(43, 76, 140);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(691, 143);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvDiasHorarios
            // 
            dgvDiasHorarios.AllowUserToAddRows = false;
            dgvDiasHorarios.AllowUserToDeleteRows = false;
            dgvDiasHorarios.AllowUserToResizeColumns = false;
            dgvDiasHorarios.AllowUserToResizeRows = false;
            dgvDiasHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvDiasHorarios.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvDiasHorarios.BorderStyle = BorderStyle.None;
            dgvDiasHorarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvDiasHorarios.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 45, 92);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDiasHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDiasHorarios.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDiasHorarios.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDiasHorarios.EnableHeadersVisualStyles = false;
            dgvDiasHorarios.GridColor = Color.FromArgb(221, 225, 232);
            dgvDiasHorarios.Location = new Point(569, 204);
            dgvDiasHorarios.MultiSelect = false;
            dgvDiasHorarios.Name = "dgvDiasHorarios";
            dgvDiasHorarios.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(35, 45, 92);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDiasHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDiasHorarios.RowHeadersVisible = false;
            dgvDiasHorarios.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(28, 32, 51);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgvDiasHorarios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvDiasHorarios.RowTemplate.Height = 40;
            dgvDiasHorarios.Size = new Size(484, 427);
            dgvDiasHorarios.TabIndex = 12;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(258, 156);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 29);
            txtApellido.TabIndex = 14;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombreApellido.Location = new Point(254, 127);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(136, 21);
            lblNombreApellido.TabIndex = 15;
            lblNombreApellido.Text = "Nombre/apellidos";
            // 
            // frmHorarioSemanal
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 659);
            Controls.Add(lblNombreApellido);
            Controls.Add(txtApellido);
            Controls.Add(dgvDiasHorarios);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvListaEmpleados);
            Controls.Add(btnAsignarHorario);
            Controls.Add(cmbDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(108, 117, 125);
            Margin = new Padding(4);
            Name = "frmHorarioSemanal";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)dgvListaEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiasHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblDepartamento;
        private ComboBox cmbDepartamento;
        private Button btnAsignarHorario;
        private DataGridView dgvListaEmpleados;
        private Button btnLimpiar;
        private DataGridView dgvDiasHorarios;
        private TextBox txtApellido;
        private Label lblNombreApellido;
    }
}
