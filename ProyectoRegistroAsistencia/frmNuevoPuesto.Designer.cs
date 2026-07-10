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
            lblDepartamento = new Label();
            cmbDepartamento = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlPuesto = new Panel();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(164, 22);
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
            lblNombrePuesto.Location = new Point(129, 108);
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
            txtNombrePuesto.Location = new Point(129, 142);
            txtNombrePuesto.Margin = new Padding(4, 4, 4, 4);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(200, 29);
            txtNombrePuesto.TabIndex = 4;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(129, 195);
            lblDepartamento.Margin = new Padding(4, 0, 4, 0);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(231, 21);
            lblDepartamento.TabIndex = 6;
            lblDepartamento.Text = "Departamento al que pertenece:";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.BackColor = Color.White;
            cmbDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(129, 229);
            cmbDepartamento.Margin = new Padding(4, 4, 4, 4);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(200, 29);
            cmbDepartamento.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(18, 319);
            btnGuardar.Margin = new Padding(4, 4, 4, 4);
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
            btnCancelar.Location = new Point(292, 319);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlPuesto
            // 
            pnlPuesto.BorderStyle = BorderStyle.FixedSingle;
            pnlPuesto.ForeColor = SystemColors.ActiveCaptionText;
            pnlPuesto.Location = new Point(18, 90);
            pnlPuesto.Margin = new Padding(4, 4, 4, 4);
            pnlPuesto.Name = "pnlPuesto";
            pnlPuesto.Size = new Size(454, 209);
            pnlPuesto.TabIndex = 7;
            // 
            // frmNuevoPuesto
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(498, 397);
            Controls.Add(lblDepartamento);
            Controls.Add(lblNombrePuesto);
            Controls.Add(txtNombrePuesto);
            Controls.Add(lblTitulo);
            Controls.Add(cmbDepartamento);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(pnlPuesto);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoPuesto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Staff Asistence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblNombrePuesto;
        private TextBox txtNombrePuesto;
        private Label lblDepartamento;
        private ComboBox cmbDepartamento;
        private Button btnGuardar;
        private Button btnCancelar;
        private Panel pnlPuesto;
    }
}
