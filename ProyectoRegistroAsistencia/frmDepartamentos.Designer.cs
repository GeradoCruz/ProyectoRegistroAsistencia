namespace ProyectoRegistroAsistencia
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnEditar = new Button();
            btnNuevo = new Button();
            dgvDepartamentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(303, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(346, 30);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Departamentos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(199, 80);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(584, 25);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Gestión de los departamentos de la institución";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(43, 76, 140);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(877, 144);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(180, 40);
            btnEditar.TabIndex = 14;
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
            btnNuevo.Location = new Point(691, 144);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(180, 40);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dgvDepartamentos
            // 
            dgvDepartamentos.AllowUserToAddRows = false;
            dgvDepartamentos.AllowUserToDeleteRows = false;
            dgvDepartamentos.AllowUserToResizeColumns = false;
            dgvDepartamentos.AllowUserToResizeRows = false;
            dgvDepartamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepartamentos.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvDepartamentos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 76, 140);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 126, 193);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDepartamentos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDepartamentos.Location = new Point(11, 200);
            dgvDepartamentos.Name = "dgvDepartamentos";
            dgvDepartamentos.ReadOnly = true;
            dgvDepartamentos.Size = new Size(1044, 427);
            dgvDepartamentos.TabIndex = 15;
            // 
            // frmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 659);
            Controls.Add(dgvDepartamentos);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDepartamentos";
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnEditar;
        private Button btnNuevo;
        private DataGridView dgvDepartamentos;
    }
}
