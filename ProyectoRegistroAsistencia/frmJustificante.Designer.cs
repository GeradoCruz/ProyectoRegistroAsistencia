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
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblFecha = new Label();
            lblIncidencia = new Label();
            lblDepartamento = new Label();
            txtJustificante = new TextBox();
            txtNombre = new TextBox();
            lblJustificante = new Label();
            txtDepartamento = new TextBox();
            lblNombre = new Label();
            dtpFecha = new DateTimePicker();
            txtIncidencia = new TextBox();
            gpbDatos = new GroupBox();
            gpbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(108, 117, 125);
            lblTitulo.Location = new Point(92, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(261, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Justificante de Incidencia";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(43, 76, 140);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(15, 391);
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
            btnCancelar.Location = new Point(272, 391);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(108, 117, 125);
            lblFecha.Location = new Point(19, 106);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(53, 21);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha:";
            lblFecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIncidencia
            // 
            lblIncidencia.AutoSize = true;
            lblIncidencia.ForeColor = Color.FromArgb(108, 117, 125);
            lblIncidencia.Location = new Point(225, 106);
            lblIncidencia.Margin = new Padding(4, 0, 4, 0);
            lblIncidencia.Name = "lblIncidencia";
            lblIncidencia.Size = new Size(82, 21);
            lblIncidencia.TabIndex = 5;
            lblIncidencia.Text = "Incidencia:";
            lblIncidencia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.FromArgb(108, 117, 125);
            lblDepartamento.Location = new Point(225, 29);
            lblDepartamento.Margin = new Padding(4, 0, 4, 0);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(113, 21);
            lblDepartamento.TabIndex = 3;
            lblDepartamento.Text = "Departamento:";
            lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtJustificante
            // 
            txtJustificante.BackColor = Color.White;
            txtJustificante.ForeColor = Color.FromArgb(64, 64, 64);
            txtJustificante.Location = new Point(18, 219);
            txtJustificante.Margin = new Padding(4);
            txtJustificante.Multiline = true;
            txtJustificante.Name = "txtJustificante";
            txtJustificante.Size = new Size(408, 82);
            txtJustificante.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Enabled = false;
            txtNombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombre.Location = new Point(17, 63);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 29);
            txtNombre.TabIndex = 9;
            // 
            // lblJustificante
            // 
            lblJustificante.AutoSize = true;
            lblJustificante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJustificante.ForeColor = Color.FromArgb(108, 117, 125);
            lblJustificante.Location = new Point(15, 186);
            lblJustificante.Margin = new Padding(4, 0, 4, 0);
            lblJustificante.Name = "lblJustificante";
            lblJustificante.Size = new Size(87, 21);
            lblJustificante.TabIndex = 6;
            lblJustificante.Text = "Justificante";
            lblJustificante.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDepartamento
            // 
            txtDepartamento.BackColor = Color.White;
            txtDepartamento.Enabled = false;
            txtDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
            txtDepartamento.Location = new Point(225, 63);
            txtDepartamento.Margin = new Padding(4);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(200, 29);
            txtDepartamento.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(108, 117, 125);
            lblNombre.Location = new Point(19, 29);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = false;
            dtpFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(15, 140);
            dtpFecha.Margin = new Padding(4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 13;
            // 
            // txtIncidencia
            // 
            txtIncidencia.BackColor = Color.White;
            txtIncidencia.Enabled = false;
            txtIncidencia.ForeColor = Color.FromArgb(64, 64, 64);
            txtIncidencia.Location = new Point(225, 140);
            txtIncidencia.Margin = new Padding(4);
            txtIncidencia.Name = "txtIncidencia";
            txtIncidencia.Size = new Size(200, 29);
            txtIncidencia.TabIndex = 11;
            // 
            // gpbDatos
            // 
            gpbDatos.Controls.Add(txtIncidencia);
            gpbDatos.Controls.Add(dtpFecha);
            gpbDatos.Controls.Add(lblNombre);
            gpbDatos.Controls.Add(txtDepartamento);
            gpbDatos.Controls.Add(lblJustificante);
            gpbDatos.Controls.Add(txtNombre);
            gpbDatos.Controls.Add(txtJustificante);
            gpbDatos.Controls.Add(lblDepartamento);
            gpbDatos.Controls.Add(lblIncidencia);
            gpbDatos.Controls.Add(lblFecha);
            gpbDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDatos.ForeColor = Color.FromArgb(108, 117, 125);
            gpbDatos.Location = new Point(15, 62);
            gpbDatos.Margin = new Padding(4);
            gpbDatos.Name = "gpbDatos";
            gpbDatos.Padding = new Padding(4);
            gpbDatos.Size = new Size(437, 315);
            gpbDatos.TabIndex = 14;
            gpbDatos.TabStop = false;
            gpbDatos.Text = "Datos del Trabajador";
            // 
            // frmJustificante
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(465, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(gpbDatos);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(108, 117, 125);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmJustificante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Assistence";
            gpbDatos.ResumeLayout(false);
            gpbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblFecha;
        private Label lblIncidencia;
        private Label lblDepartamento;
        private TextBox txtJustificante;
        private TextBox txtNombre;
        private Label lblJustificante;
        private TextBox txtDepartamento;
        private Label lblNombre;
        private DateTimePicker dtpFecha;
        private TextBox txtIncidencia;
        private GroupBox gpbDatos;
    }
}
