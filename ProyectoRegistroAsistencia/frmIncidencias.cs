using MySqlConnector;
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
    public partial class frmIncidencias : Form
    {
        clsIncidencias incidencias;

        public frmIncidencias()
        {
            InitializeComponent();

            // Se inicializa primero porque abajo se tocan controles (SelectedIndex, etc.)
            // que ya disparan la búsqueda en vivo y necesitan "incidencias" listo.
            incidencias = new clsIncidencias();

            cmbTipoIncidencia.Items.Clear();
            cmbTipoIncidencia.Items.Add("Todos");
            cmbTipoIncidencia.Items.Add("Falta");
            cmbTipoIncidencia.Items.Add("Retardo");

            cmbTipoIncidencia.SelectedIndex = 0;
            cmbTipoIncidencia.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpFecha.ShowCheckBox = true;
            dtpFecha.Checked = false;

            CargarComboTipos();

            dgvIncidencias.DataSource = null;
            dgvIncidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvIncidencias.DataSource = incidencias.CargarDataGrid();
                dgvIncidencias.Columns["id_incidencia"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void CargarComboTipos()
        {
            incidencias = new clsIncidencias();
            try
            {
                DataTable dtTipos = incidencias.ObtenerTiposIncidencia();

                DataRow filaTodos = dtTipos.NewRow();
                filaTodos["id_tipo_incidencia"] = 0;
                filaTodos["nombre_tipo"] = "-- Todos --";
                dtTipos.Rows.InsertAt(filaTodos, 0);

                cmbTipoIncidencia.DataSource = dtTipos;
                cmbTipoIncidencia.DisplayMember = "nombre_tipo";
                cmbTipoIncidencia.ValueMember = "id_tipo_incidencia";
                cmbTipoIncidencia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de incidencia: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefrescarGrid()
        {

            dgvIncidencias.DataSource = incidencias.CargarDataGrid();
            dgvIncidencias.Columns["id_incidencia"].Visible = false;
        }



        // Búsqueda en vivo (por LIKE), sin necesidad de botón Buscar.
        private void RealizarBusqueda()
        {
            try
            {
                DateTime? fecha = null;

                // Solo se usa la fecha si la casilla del DateTimePicker está marcada
                if (dtpFecha.Checked)
                {
                    fecha = dtpFecha.Value.Date;
                }

                string nombre = txtNombreTrabajador.Text.Trim();

                // idTipo = 0 ("-- Todos --") significa que no se filtra por tipo
                int idTipo = cmbTipoIncidencia.SelectedValue != null
                    ? Convert.ToInt32(cmbTipoIncidencia.SelectedValue)
                    : 0;

                dgvIncidencias.DataSource = incidencias.FiltrarBusqueda(fecha, nombre, idTipo);
            }
            catch
            {
                // No mostrar mensajes mientras se escribe/selecciona
            }
        }

        private void txtNombreTrabajador_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void cmbTipoIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        // DateTimePicker no expone CheckedChanged; con MouseUp cubrimos el clic
        // sobre la casilla de activar/desactivar el filtro de fecha.
        private void dtpFecha_MouseUp(object sender, MouseEventArgs e)
        {
            RealizarBusqueda();
        }

        // Restablece los filtros a su estado inicial y vuelve a cargar el grid completo.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFecha.Checked = false;
            txtNombreTrabajador.Clear();
            cmbTipoIncidencia.SelectedIndex = 0;
            RefrescarGrid();
        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {
            if (dgvIncidencias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una incidencia.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(
                    dgvIncidencias.CurrentRow.Cells["id_incidencia"].Value);

                string nombre = dgvIncidencias.CurrentRow
                    .Cells["Nombre completo"].Value.ToString();

                string departamento = dgvIncidencias.CurrentRow
                    .Cells["Nombre departamento"].Value.ToString();

                string incidencia = dgvIncidencias.CurrentRow
                    .Cells["Tipo de incidencia"].Value.ToString();

                DateTime fecha = Convert.ToDateTime(
                    dgvIncidencias.CurrentRow.Cells["Fecha"].Value);

                using (frmJustificante frm = new frmJustificante())
                {
                    frm.CargarDatos(id, nombre, departamento, incidencia, fecha);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la justificación: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
