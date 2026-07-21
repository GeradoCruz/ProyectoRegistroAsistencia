using System.Data;
namespace ProyectoRegistroAsistencia
{
    public partial class frmEmpleados : Form
    {
        clsEmpleados empleados;
        frmNuevoEmpleado datosE;
        string claveTrabajador;
        public frmEmpleados()
        {
            InitializeComponent();
            CargarDataGrid();
            CargarCombo();
        }

        public void btnNuevo_Click(object? sender, EventArgs e)
        {
            using (var frm = new frmNuevoEmpleado())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarDataGrid();
                }
            }
        }
        public void CargarDataGrid()
        {
            empleados = new clsEmpleados();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvEmpleados.DataSource = empleados.Consultar();
                dgvEmpleados.Columns["id_departamento"].Visible = false;
                dgvEmpleados.Columns["id_puesto"].Visible = false;
                dgvEmpleados.Columns["Estatus"].Visible = false;
                dgvEmpleados.Columns["Numero Calle"].Visible = false;
                dgvEmpleados.Columns["Codigo Postal"].Visible = false;
                dgvEmpleados.Columns["Municipio"].Visible = false;
                dgvEmpleados.Columns["Localidad"].Visible = false;
                dgvEmpleados.Columns["Telefono"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void btnEditar_Click(object? sender, EventArgs e)
        {
            if (ban != 1)
            {
                MessageBox.Show("Selecciona un empleado de la lista para editar.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: precargar los datos del empleado seleccionado en frmNuevoEmpleado
            using (var frm = new frmNuevoEmpleado())
            {
                datosE = new frmNuevoEmpleado();
                if (dgvEmpleados.CurrentRow == null) return;
                try
                {
                    datosE.lblTitulo.Text = "Actualización del Empleado";
                    datosE.ClaveTrabajador = dgvEmpleados.CurrentRow.Cells["Clave Trabajador"].Value.ToString();

                    datosE.txtClaveTrabajador.Text = dgvEmpleados.CurrentRow.Cells["Clave Trabajador"].Value.ToString();
                    datosE.txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                    datosE.txtApellidoPaterno.Text = dgvEmpleados.CurrentRow.Cells["Apellido Paterno"].Value.ToString();
                    datosE.txtApellidoMaterno.Text = dgvEmpleados.CurrentRow.Cells["Apellido Materno"].Value.ToString();
                    datosE.txtLocalidad.Text = dgvEmpleados.CurrentRow.Cells["Localidad"].Value.ToString();
                    datosE.txtMunicipio.Text = dgvEmpleados.CurrentRow.Cells["Municipio"].Value.ToString();
                    datosE.rdbHombre.Checked = dgvEmpleados.CurrentRow.Cells["Genero"].Value.ToString() == "Hombre";
                    datosE.rdbMujer.Checked = dgvEmpleados.CurrentRow.Cells["Genero"].Value.ToString() == "Mujer";
                    datosE.txtCorreoInstitucional.Text = dgvEmpleados.CurrentRow.Cells["Correo Institucional"].Value.ToString();
                    datosE.txtTelefono.Text = dgvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                    datosE.txtCodigoPostal.Text = dgvEmpleados.CurrentRow.Cells["Codigo Postal"].Value.ToString();
                    datosE.txtNumCalle.Text = dgvEmpleados.CurrentRow.Cells["Numero Calle"].Value.ToString();
                    datosE.cmbDepartamento.SelectedValue = dgvEmpleados.CurrentRow.Cells["id_departamento"].Value;
                    datosE.cmbPuesto.SelectedValue = dgvEmpleados.CurrentRow.Cells["id_puesto"].Value;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el empleado: " + ex.Message);
                }
                datosE.ShowDialog();
            }
        }
        public void CargarCombo()
        {
            empleados = new clsEmpleados();
            try
            {
                DataTable dtDepartamentos = empleados.ObtenerDepartamentos();

                DataRow filaDepartamento = dtDepartamentos.NewRow();
                filaDepartamento["id_departamento"] = 0;
                filaDepartamento["nombre_departamento"] = "Selecciona un departamento";
                dtDepartamentos.Rows.InsertAt(filaDepartamento, 0);

                //Enlazamos los datos con el combobox visual
                cmbDepartamento.DataSource = dtDepartamentos;
                cmbDepartamento.DisplayMember = "nombre_departamento";
                cmbDepartamento.ValueMember = "id_departamento";
                cmbDepartamento.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
        }

        public void btnDarBaja_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Deseas dar de baja a este empleado?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    empleados = new clsEmpleados();
                    empleados.ClaveTrabajador = claveTrabajador;
                    string resultado = empleados.DarDeBaja();
                    MessageBox.Show(resultado, "Empleado dado de baja correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text != "") return;

            empleados = new clsEmpleados();
            claveTrabajador = txtBuscarEmpleado.Text;
            dgvEmpleados.DataSource = null;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                if (claveTrabajador != "")
                {
                    dgvEmpleados.DataSource = empleados.BuscarEmpleado(claveTrabajador);

                }
                else
                {
                    dgvEmpleados.DataSource = empleados.Consultar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int ban = 0;
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            ban = 1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }

        private void btnBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarEmpleado.Text))
            {
                CargarDataGrid();
                return;
            }
            empleados = new clsEmpleados();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                empleados.ClaveTrabajador = txtBuscarEmpleado.Text;
                dgvEmpleados.DataSource = empleados.Consultar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
