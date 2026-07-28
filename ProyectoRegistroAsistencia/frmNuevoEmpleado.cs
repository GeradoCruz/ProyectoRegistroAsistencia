using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (string.IsNullOrWhiteSpace(txtClaveTrabajador.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                MessageBox.Show("Completa al menos Clave, Nombre(s) y Apellido Paterno.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rdbHombre.Checked && !rdbMujer.Checked)
            {
                MessageBox.Show("Selecciona el genero (H/M).", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                empleados.ClaveTrabajador =string.IsNullOrEmpty(txtClaveTrabajador.Text) ? null : txtClaveTrabajador.Text;
                empleados.Nombre =string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text;
                empleados.ApellidoPaterno = string.IsNullOrEmpty(txtApellidoPaterno.Text) ? null : txtApellidoPaterno.Text;
                empleados.ApellidoMaterno = string.IsNullOrEmpty(txtApellidoMaterno.Text) ? null : txtApellidoMaterno.Text;
                empleados.Genero = char.Parse(rdbHombre.Checked ? "M" : "F");
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
                    var resp = MessageBox.Show("¿Desea actualizar el empleado?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
