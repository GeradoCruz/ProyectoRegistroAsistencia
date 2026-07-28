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
            lblBuscarPuesto = new Label();
            txtBuscarPuesto = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            dgvPuestos = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnDarBaja = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(400, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Puestos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitulo.Location = new Point(306, 51);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(522, 25);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestión de los puestos de la institución";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblBuscarPuesto
            //
            lblBuscarPuesto.AutoSize = true;
            lblBuscarPuesto.ForeColor = Color.FromArgb(108, 117, 125);
            lblBuscarPuesto.Location = new Point(13, 94);
            lblBuscarPuesto.Name = "lblBuscarPuesto";
            lblBuscarPuesto.Size = new Size(150, 21);
            lblBuscarPuesto.TabIndex = 2;
            lblBuscarPuesto.Text = "Nombre del puesto";
            //
            // txtBuscarPuesto
            //
            txtBuscarPuesto.BackColor = Color.White;
            txtBuscarPuesto.ForeColor = Color.FromArgb(108, 117, 125);
            txtBuscarPuesto.Location = new Point(13, 127);
            txtBuscarPuesto.Name = "txtBuscarPuesto";
            txtBuscarPuesto.Size = new Size(200, 29);
            txtBuscarPuesto.TabIndex = 3;
            //
            // btnBuscar
            //
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(43, 76, 140);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(688, 120);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            //
            // btnLimpiar
            //
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(876, 120);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            //
            // dgvPuestos
            //
            dgvPuestos.AllowUserToAddRows = false;
            dgvPuestos.AllowUserToDeleteRows = false;
            dgvPuestos.AllowUserToResizeColumns = false;
            dgvPuestos.AllowUserToResizeRows = false;
            dgvPuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPuestos.BackgroundColor = Color.FromArgb(240, 242, 245);
            dgvPuestos.BorderStyle = BorderStyle.None;
            dgvPuestos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvPuestos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 45, 92);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPuestos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 32, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 90, 166);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPuestos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPuestos.EnableHeadersVisualStyles = false;
            dgvPuestos.GridColor = Color.FromArgb(221, 225, 232);
            dgvPuestos.Location = new Point(11, 178);
            dgvPuestos.MultiSelect = false;
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.ReadOnly = true;
            dgvPuestos.RowHeadersVisible = false;
            dgvPuestos.RowTemplate.Height = 40;
            dgvPuestos.Size = new Size(1044, 427);
            dgvPuestos.TabIndex = 6;
            dgvPuestos.SelectionChanged += dgvPuestos_SelectionChanged;
            //
            // btnNuevo
            //
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(43, 76, 140);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(514, 613);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(180, 40);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            //
            // btnEditar
            //
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(43, 76, 140);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(700, 613);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(180, 40);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            //
            // btnDarBaja
            //
            btnDarBaja.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDarBaja.BackColor = Color.FromArgb(108, 117, 125);
            btnDarBaja.ForeColor = Color.White;
            btnDarBaja.Image = (Image)resources.GetObject("btnDarBaja.Image");
            btnDarBaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarBaja.Location = new Point(884, 613);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(180, 40);
            btnDarBaja.TabIndex = 9;
            btnDarBaja.Text = "Dar de Baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
            //
            // frmPuestos
            //
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 659);
            Controls.Add(btnDarBaja);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvPuestos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarPuesto);
            Controls.Add(lblBuscarPuesto);
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
        private Label lblBuscarPuesto;
        private TextBox txtBuscarPuesto;
        private Button btnBuscar;
        private Button btnLimpiar;
        public DataGridView dgvPuestos;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnDarBaja;
    }
}
