namespace ProyectoRegistroAsistencia
{
    partial class frmNuevoPuesto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoPuesto));
            lblTitulo = new Label();
            pnlPuesto = new Panel();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombrePuesto = new TextBox();
            lblNombrePuesto = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlPuesto.SuspendLayout();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(125, 22);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(151, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Puesto";
            //
            // pnlPuesto
            //
            pnlPuesto.BorderStyle = BorderStyle.FixedSingle;
            pnlPuesto.Controls.Add(txtDescripcion);
            pnlPuesto.Controls.Add(lblDescripcion);
            pnlPuesto.Controls.Add(txtNombrePuesto);
            pnlPuesto.Controls.Add(lblNombrePuesto);
            pnlPuesto.Location = new Point(22, 63);
            pnlPuesto.Margin = new Padding(3, 4, 3, 4);
            pnlPuesto.Name = "pnlPuesto";
            pnlPuesto.Size = new Size(370, 235);
            pnlPuesto.TabIndex = 1;
            //
            // txtDescripcion
            //
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.ForeColor = Color.FromArgb(108, 117, 125);
            txtDescripcion.Location = new Point(21, 116);
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
            lblDescripcion.Location = new Point(21, 84);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(94, 21);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            //
            // txtNombrePuesto
            //
            txtNombrePuesto.BackColor = Color.White;
            txtNombrePuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePuesto.ForeColor = Color.FromArgb(108, 117, 125);
            txtNombrePuesto.Location = new Point(21, 49);
            txtNombrePuesto.Margin = new Padding(3, 4, 3, 4);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(319, 29);
            txtNombrePuesto.TabIndex = 1;
            //
            // lblNombrePuesto
            //
            lblNombrePuesto.AutoSize = true;
            lblNombrePuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePuesto.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombrePuesto.Location = new Point(21, 17);
            lblNombrePuesto.Name = "lblNombrePuesto";
            lblNombrePuesto.Size = new Size(147, 21);
            lblNombrePuesto.TabIndex = 0;
            lblNombrePuesto.Text = "Nombre del puesto:";
            //
            // btnGuardar
            //
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(18, 307);
            btnGuardar.Margin = new Padding(4);
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
            btnCancelar.Location = new Point(215, 307);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            //
            // frmNuevoPuesto
            //
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(416, 361);
            Controls.Add(pnlPuesto);
            Controls.Add(lblTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoPuesto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Staff Asistence";
            pnlPuesto.ResumeLayout(false);
            pnlPuesto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblTitulo;
        private Panel pnlPuesto;
        public TextBox txtDescripcion;
        private Label lblDescripcion;
        public TextBox txtNombrePuesto;
        private Label lblNombrePuesto;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
