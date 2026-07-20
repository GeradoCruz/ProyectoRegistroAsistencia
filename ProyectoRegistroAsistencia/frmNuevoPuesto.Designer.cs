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
            lblNombrePuesto = new Label();
            txtNombrePuesto = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            pnlPuesto = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            txtDepartamento = new TextBox();
            lblDepartamento = new Label();
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
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Nuevo Puesto";
            //
            // lblNombrePuesto
            //
            lblNombrePuesto.AutoSize = true;
            lblNombrePuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePuesto.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombrePuesto.Location = new Point(54, 76);
            lblNombrePuesto.Margin = new Padding(4, 0, 4, 0);
            lblNombrePuesto.Name = "lblNombrePuesto";
            lblNombrePuesto.Size = new Size(147, 21);
            lblNombrePuesto.TabIndex = 5;
            lblNombrePuesto.Text = "Nombre del puesto:";
            //
            // txtNombrePuesto
            //
            txtNombrePuesto.BackColor = Color.White;
            txtNombrePuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePuesto.ForeColor = Color.FromArgb(108, 117, 125);
            txtNombrePuesto.Location = new Point(54, 110);
            txtNombrePuesto.Margin = new Padding(4);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(314, 29);
            txtNombrePuesto.TabIndex = 4;
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
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
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
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            //
            // txtDescripcion
            //
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.ForeColor = Color.FromArgb(108, 117, 125);
            txtDescripcion.Location = new Point(49, 185);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(319, 105);
            txtDescripcion.TabIndex = 7;
            //
            // lblDescripcion
            //
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.FromArgb(108, 117, 125);
            lblDescripcion.Location = new Point(49, 153);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(94, 21);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripci�n:";
            //
            // pnlPuesto
            //
            pnlPuesto.BorderStyle = BorderStyle.FixedSingle;
            pnlPuesto.Controls.Add(textBox1);
            pnlPuesto.Controls.Add(label1);
            pnlPuesto.Controls.Add(txtDepartamento);
            pnlPuesto.Controls.Add(lblDepartamento);
            pnlPuesto.Location = new Point(22, 63);
            pnlPuesto.Margin = new Padding(3, 4, 3, 4);
            pnlPuesto.Name = "pnlPuesto";
            pnlPuesto.Size = new Size(370, 235);
            pnlPuesto.TabIndex = 8;
            //
            // textBox1
            //
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.FromArgb(108, 117, 125);
            textBox1.Location = new Point(21, 116);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 105);
            textBox1.TabIndex = 3;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(108, 117, 125);
            label1.Location = new Point(21, 84);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 2;
            label1.Text = "Descripci�n:";
            //
            // txtDepartamento
            //
            txtDepartamento.BackColor = Color.White;
            txtDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            txtDepartamento.Location = new Point(21, 49);
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
            lblDepartamento.Location = new Point(21, 17);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 0;
            lblDepartamento.Text = "Departamento:";
            //
            // frmNuevoPuesto
            //
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(416, 361);
            Controls.Add(pnlPuesto);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombrePuesto);
            Controls.Add(txtNombrePuesto);
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
        private Label lblTitulo;
        private Label lblNombrePuesto;
        private TextBox txtNombrePuesto;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Panel pnlPuesto;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtDepartamento;
        private Label lblDepartamento;
    }
}
