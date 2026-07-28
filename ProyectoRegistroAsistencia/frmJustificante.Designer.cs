namespace ProyectoRegistroAsistencia
{
    partial class frmJustificante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJustificante));
            lblTitulo = new Label();
            lblNombre = new Label();
            lblDepartamento = new Label();
            lblFecha = new Label();
            lblIncidencia = new Label();
            lblJustificante = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtJustificante = new TextBox();
            txtIncidencia = new TextBox();
            txtDepartamento = new TextBox();
            dtpFecha = new DateTimePicker();
            grpDatos = new GroupBox();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(133, 10);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(261, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Justificante de Incidencia";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombre.Location = new Point(19, 36);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(285, 36);
            lblDepartamento.Margin = new Padding(4, 0, 4, 0);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 3;
            lblDepartamento.Text = "Departamento:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(108, 117, 125);
            lblFecha.Location = new Point(19, 113);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 21);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha:";
            // 
            // lblIncidencia
            // 
            lblIncidencia.AutoSize = true;
            lblIncidencia.ForeColor = Color.FromArgb(108, 117, 125);
            lblIncidencia.Location = new Point(285, 113);
            lblIncidencia.Margin = new Padding(4, 0, 4, 0);
            lblIncidencia.Name = "lblIncidencia";
            lblIncidencia.Size = new Size(82, 21);
            lblIncidencia.TabIndex = 5;
            lblIncidencia.Text = "Incidencia:";
            // 
            // lblJustificante
            // 
            lblJustificante.AutoSize = true;
            lblJustificante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJustificante.ForeColor = Color.FromArgb(108, 117, 125);
            lblJustificante.Location = new Point(15, 193);
            lblJustificante.Margin = new Padding(4, 0, 4, 0);
            lblJustificante.Name = "lblJustificante";
            lblJustificante.Size = new Size(87, 21);
            lblJustificante.TabIndex = 6;
            lblJustificante.Text = "Justificante";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(15, 408);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 40);
            btnGuardar.TabIndex = 7;
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
            btnCancelar.Location = new Point(338, 408);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Enabled = false;
            txtNombre.ForeColor = Color.FromArgb(108, 117, 125);
            txtNombre.Location = new Point(19, 70);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 9;
            // 
            // txtJustificante
            // 
            txtJustificante.BackColor = Color.White;
            txtJustificante.ForeColor = Color.FromArgb(108, 117, 125);
            txtJustificante.Location = new Point(18, 226);
            txtJustificante.Margin = new Padding(4);
            txtJustificante.Multiline = true;
            txtJustificante.Name = "txtJustificante";
            txtJustificante.Size = new Size(467, 82);
            txtJustificante.TabIndex = 10;
            // 
            // txtIncidencia
            // 
            txtIncidencia.BackColor = Color.White;
            txtIncidencia.Enabled = false;
            txtIncidencia.ForeColor = Color.FromArgb(108, 117, 125);
            txtIncidencia.Location = new Point(285, 147);
            txtIncidencia.Margin = new Padding(4);
            txtIncidencia.Name = "txtIncidencia";
            txtIncidencia.Size = new Size(200, 29);
            txtIncidencia.TabIndex = 11;
            // 
            // txtDepartamento
            // 
            txtDepartamento.BackColor = Color.White;
            txtDepartamento.Enabled = false;
            txtDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            txtDepartamento.Location = new Point(285, 70);
            txtDepartamento.Margin = new Padding(4);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(200, 29);
            txtDepartamento.TabIndex = 12;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = false;
            dtpFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(15, 147);
            dtpFecha.Margin = new Padding(4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 13;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtIncidencia);
            grpDatos.Controls.Add(dtpFecha);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtDepartamento);
            grpDatos.Controls.Add(lblJustificante);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(txtJustificante);
            grpDatos.Controls.Add(lblDepartamento);
            grpDatos.Controls.Add(lblIncidencia);
            grpDatos.Controls.Add(lblFecha);
            grpDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDatos.ForeColor = Color.FromArgb(108, 117, 125);
            grpDatos.Location = new Point(15, 75);
            grpDatos.Margin = new Padding(4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4);
            grpDatos.Size = new Size(501, 315);
            grpDatos.TabIndex = 14;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Trabajador";
            // 
            // frmJustificante
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(531, 489);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatos);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmJustificante";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Staff Asistence";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblDepartamento;
        private Label lblFecha;
        private Label lblIncidencia;
        private Label lblJustificante;
        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtJustificante;
        private TextBox txtIncidencia;
        private TextBox txtDepartamento;
        private DateTimePicker dtpFecha;
        private GroupBox grpDatos;
        private Button btnCancelar;
    }
}
