namespace ProyectoRegistroAsistencia
{
    partial class frmNuevoDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoDepartamento));
            lblTitulo = new Label();
            pnlDepartamento = new Panel();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtDepartamento = new TextBox();
            lblDepartamento = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlDepartamento.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(79, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(226, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Departamento";
            // 
            // pnlDepartamento
            // 
            pnlDepartamento.BorderStyle = BorderStyle.FixedSingle;
            pnlDepartamento.Controls.Add(txtDescripcion);
            pnlDepartamento.Controls.Add(lblDescripcion);
            pnlDepartamento.Controls.Add(txtDepartamento);
            pnlDepartamento.Controls.Add(lblDepartamento);
            pnlDepartamento.Location = new Point(14, 56);
            pnlDepartamento.Margin = new Padding(3, 4, 3, 4);
            pnlDepartamento.Name = "pnlDepartamento";
            pnlDepartamento.Size = new Size(365, 235);
            pnlDepartamento.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.ForeColor = Color.FromArgb(108, 117, 125);
            txtDescripcion.Location = new Point(15, 116);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(319, 105);
            txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.FromArgb(108, 117, 125);
            lblDescripcion.Location = new Point(15, 84);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(94, 21);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.BackColor = Color.White;
            txtDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            txtDepartamento.Location = new Point(15, 49);
            txtDepartamento.Margin = new Padding(3, 4, 3, 4);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(319, 29);
            txtDepartamento.TabIndex = 1;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(15, 17);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 0;
            lblDepartamento.Text = "Departamento:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(12, 303);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(201, 303);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            //
            // frmNuevoDepartamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(393, 361);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(pnlDepartamento);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoDepartamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Staff Asistence";
            pnlDepartamento.ResumeLayout(false);
            pnlDepartamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTitulo;
        private Panel pnlDepartamento;
        private Label lblDescripcion;
        public TextBox txtDepartamento;
        private Label lblDepartamento;
        public TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
