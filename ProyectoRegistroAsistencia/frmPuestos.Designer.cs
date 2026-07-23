namespace ProyectoRegistroAsistencia
{
    partial class frmPuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuestos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnEditar = new Button();
            btnNuevo = new Button();
            btnBuscar = new Button();
            cmbDepartamento = new ComboBox();
            lblDepartamento = new Label();
            dgvPuestos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(400, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 30);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Puestos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(306, 76);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(522, 25);
            lblSubtitulo.TabIndex = 4;
            lblSubtitulo.Text = "Gestión de los puestos de la institución";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(43, 76, 140);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(880, 153);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(180, 40);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(43, 76, 140);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(694, 153);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(180, 40);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(508, 153);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.BackColor = Color.White;
            cmbDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(13, 160);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(200, 29);
            cmbDepartamento.TabIndex = 14;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(13, 127);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 13;
            lblDepartamento.Text = "Departamento:";
            // 
            // dgvPuestos
            // 
            dgvPuestos.AllowUserToAddRows = false;
            dgvPuestos.AllowUserToDeleteRows = false;
            dgvPuestos.AllowUserToResizeColumns = false;
            dgvPuestos.AllowUserToResizeRows = false;
            dgvPuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPuestos.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvPuestos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 76, 140);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPuestos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPuestos.Location = new Point(12, 220);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.ReadOnly = true;
            dgvPuestos.Size = new Size(1044, 427);
            dgvPuestos.TabIndex = 18;
            // 
            // frmPuestos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 659);
            Controls.Add(dgvPuestos);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            Controls.Add(cmbDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmPuestos";
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnEditar;
        private Button btnNuevo;
        private Button btnBuscar;
        private ComboBox cmbDepartamento;
        private Label lblDepartamento;
        private DataGridView dgvPuestos;
    }
}
