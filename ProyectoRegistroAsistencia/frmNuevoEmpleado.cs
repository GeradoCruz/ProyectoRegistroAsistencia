using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRegistroAsistencia
{
    public partial class frmNuevoEmpleado : Form
    {
        clsEmpleados empleados;
        frmEmpleados datosE;
        public string ClaveTrabajador { get; set; }
        public frmNuevoEmpleado()
        {
            InitializeComponent();
            CargarCombo();
        }

        private void frmNuevoEmpleado_Load(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClaveTrabajador))
            {
                MessageBox.Show($"Cargar datos del empleado con clave: {ClaveTrabajador}", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCampos()
        {
            // ---- Orden segun la disposicion visual del formulario: Clave, Nombre, Genero,
            // Apellido Paterno/Materno, Departamento, Puesto, Direccion, Datos de Contacto. ----

            if (string.IsNullOrWhiteSpace(txtClaveTrabajador.Text))
            {
                MessageBox.Show("Escribe la clave del trabajador.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveTrabajador.Focus();
                return false;
            }

            // La clave debe tener el formato UTHH- seguido de 4 numeros. Ej: UTHH-0001
            string clave = txtClaveTrabajador.Text.Trim();
            if (!Regex.IsMatch(clave, @"^UTHH-\d{4}$"))
            {
                MessageBox.Show("Formato incorrecto. Debe ser UTHH-#### (4 caracteres numericos).",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveTrabajador.Focus();
                return false;
            }

            // La clave no se debe repetir. Al editar, se excluye la clave original del propio empleado.
            try
            {
                empleados = empleados ?? new clsEmpleados();
                if (empleados.ExisteClave(clave, ClaveTrabajador))
                {
                    MessageBox.Show("Ya existe un empleado registrado con esa clave.",
                        "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveTrabajador.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo validar la clave: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escribe el nombre.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (!rdbHombre.Checked && !rdbMujer.Checked)
            {
                MessageBox.Show("Selecciona el genero (H/M).", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                MessageBox.Show("Escribe el apellido paterno.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidoPaterno.Focus();
                return false;
            }

            // Debe seleccionarse un departamento valido (distinto del elemento "Selecciona un departamento").
            if (cmbDepartamento.SelectedValue == null || Convert.ToInt32(cmbDepartamento.SelectedValue) == 0)
            {
                MessageBox.Show("Selecciona un departamento.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartamento.Focus();
                return false;
            }

            // Debe seleccionarse un puesto valido (distinto del elemento "Selecciona un puesto").
            if (cmbPuesto.SelectedValue == null || Convert.ToInt32(cmbPuesto.SelectedValue) == 0)
            {
                MessageBox.Show("Selecciona un puesto.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPuesto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumCalle.Text))
            {
                MessageBox.Show("Escribe el numero de calle.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumCalle.Focus();
                return false;
            }

            // El numero de calle debe ser numerico.
            if (!Regex.IsMatch(txtNumCalle.Text.Trim(), @"^\d+$"))
            {
                MessageBox.Show("El numero de calle debe ser numerico.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumCalle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
            {
                MessageBox.Show("Escribe el codigo postal.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoPostal.Focus();
                return false;
            }

            // El codigo postal debe ser numerico y de maximo 5 digitos.
            if (!Regex.IsMatch(txtCodigoPostal.Text.Trim(), @"^\d{1,5}$"))
            {
                MessageBox.Show("El codigo postal debe ser numerico y tener un maximo de 5 digitos.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoPostal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocalidad.Text))
            {
                MessageBox.Show("Escribe la localidad.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocalidad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMunicipio.Text))
            {
                MessageBox.Show("Escribe el municipio.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMunicipio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Escribe el telefono.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            // El telefono debe tener exactamente 10 digitos numericos.
            if (!Regex.IsMatch(txtTelefono.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("El telefono debe contener exactamente 10 digitos numericos.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoInstitucional.Text))
            {
                MessageBox.Show("Escribe el correo institucional.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreoInstitucional.Focus();
                return false;
            }

            // El correo institucional debe terminar en @uthh.edu.mx
            if (!Regex.IsMatch(txtCorreoInstitucional.Text.Trim(), @"^[A-Za-z0-9._%+-]+@uthh\.edu\.mx$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("El correo institucional debe tener el formato usuario@uthh.edu.mx",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreoInstitucional.Focus();
                return false;
            }

            return true;
        }
        public void CargarDataGrid()
        {
            empleados = new clsEmpleados();
            datosE = new frmEmpleados();
            datosE.dgvEmpleados.DataSource = null;
            datosE.dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                datosE.dgvEmpleados.DataSource = empleados.Consultar();
                datosE.dgvEmpleados.Columns["id_departamento"].Visible = false;
                datosE.dgvEmpleados.Columns["id_puesto"].Visible = false;
                datosE.dgvEmpleados.Columns["Estatus"].Visible = false;
                datosE.dgvEmpleados.Columns["Nombre"].Visible = false;
                datosE.dgvEmpleados.Columns["Apellido Paterno"].Visible = false;
                datosE.dgvEmpleados.Columns["Apellido Materno"].Visible = false;
                datosE.dgvEmpleados.Columns["Numero Calle"].Visible = false;
                datosE.dgvEmpleados.Columns["Codigo Postal"].Visible = false;
                datosE.dgvEmpleados.Columns["Municipio"].Visible = false;
                datosE.dgvEmpleados.Columns["Localidad"].Visible = false;
                datosE.dgvEmpleados.Columns["Telefono"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            // TODO: guardar el nuevo empleado en la base de datos
            try
            {
                int tipoOperacion = ClaveTrabajador == null ? 0 : 1;
                empleados = new clsEmpleados();

                empleados.ClaveTrabajador = string.IsNullOrWhiteSpace(txtClaveTrabajador.Text) ? null : txtClaveTrabajador.Text.Trim();
                empleados.Nombre =string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text;
                empleados.ApellidoPaterno = string.IsNullOrEmpty(txtApellidoPaterno.Text) ? null : txtApellidoPaterno.Text;
                empleados.ApellidoMaterno = string.IsNullOrEmpty(txtApellidoMaterno.Text) ? null : txtApellidoMaterno.Text;
                empleados.Genero = rdbMujer.Checked ? 'F' : 'M';
                empleados.Departamento = Convert.ToString(cmbDepartamento.SelectedValue);
                empleados.Puesto = Convert.ToString(cmbPuesto.SelectedValue);
                empleados.NumeroCalle = string.IsNullOrEmpty(txtNumCalle.Text) ? 0 : Convert.ToInt32(txtNumCalle.Text);
                empleados.CodigoPostal = string.IsNullOrEmpty(txtCodigoPostal.Text) ? 0 : Convert.ToInt32(txtCodigoPostal.Text);
                empleados.Municipio = string.IsNullOrEmpty(txtMunicipio.Text) ? null : txtMunicipio.Text;
                empleados.Localidad = string.IsNullOrEmpty(txtLocalidad.Text) ? null : txtLocalidad.Text;
                empleados.Telefono = string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text;
                empleados.CorreoElectronico = string.IsNullOrEmpty(txtCorreoInstitucional.Text) ? null : txtCorreoInstitucional.Text;

                string msq = "";
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("�Desea actualizar el empleado?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msq = empleados.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msq, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        if (this.DialogResult == DialogResult.OK)
                        {
                            CargarDataGrid();
                        }
                    }
                }
                else
                {
                    msq = empleados.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msq, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    if (this.DialogResult == DialogResult.OK)
                    {
                        CargarDataGrid();
                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

                DataTable dtPuestos = empleados.ObtenerPuestos();

                DataRow filaPuestos = dtPuestos.NewRow();
                filaPuestos["id_puesto"] = 0;
                filaPuestos["nombre_puesto"] = "Selecciona un puesto";
                dtPuestos.Rows.InsertAt(filaPuestos, 0);

                //Enlazamos los datos con el combobox visual
                cmbPuesto.DataSource = dtPuestos;
                cmbPuesto.DisplayMember = "nombre_puesto";
                cmbPuesto.ValueMember = "id_puesto";
                cmbPuesto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
        }

    }
}
