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

            dtpFecha.ShowCheckBox = true;
            dtpFecha.Checked = false;

            CargarComboTipos();

            incidencias = new clsIncidencias();
            dgvIncidencias.DataSource = null;
            dgvIncidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvIncidencias.DataSource = incidencias.CargarDataGrid();
                //aqui iria el codigo para ocultar la columna de id_incidencia----------------------------------------------------------
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
            // TODO: volver a cargar dgvIncidencias desde la base de datos
            dgvIncidencias.DataSource = incidencias.CargarDataGrid();
            dgvIncidencias.Columns["id_incidencia"].Visible = false;
        }

        private void btnJustificar_Click(object? sender, EventArgs e)
        {
            if (dgvIncidencias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una incidencia.");
                return;
            }

            int id = Convert.ToInt32(
                dgvIncidencias.CurrentRow.Cells["id_incidencia"].Value);

            string nombre = dgvIncidencias.CurrentRow.Cells["Nombre completo"].Value.ToString();
            string departamento = dgvIncidencias.CurrentRow.Cells["Nombre departamento"].Value.ToString();
            string incidencia = dgvIncidencias.CurrentRow.Cells["Tipo de incidencia"].Value.ToString();
            DateTime fecha = Convert.ToDateTime(dgvIncidencias.CurrentRow.Cells["Fecha"].Value);

            using (frmJustificante frm = new frmJustificante())
            {
                frm.CargarDatos(id, nombre, departamento, incidencia, fecha);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? fecha = null;

                // Solo se usa la fecha si la casilla del DateTimePicker está marcada
                if (dtpFecha.Checked)
                {
                    fecha = dtpFecha.Value.Date;
                }

                string clave = txtClaveTrabajador.Text.Trim();

                // idTipo = 0 ("-- Todos --") significa que no se filtra por tipo
                int idTipo = cmbTipoIncidencia.SelectedValue != null
                    ? Convert.ToInt32(cmbTipoIncidencia.SelectedValue)
                    : 0;

                dgvIncidencias.DataSource = incidencias.FiltrarBusqueda(fecha, clave, idTipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJustificar_Click_1(object sender, EventArgs e)
        {
            if (dgvIncidencias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una incidencia.");
                return;
            }

            int id = Convert.ToInt32(
                dgvIncidencias.CurrentRow.Cells["id_incidencia"].Value);

            string nombre = dgvIncidencias.CurrentRow.Cells["Nombre completo"].Value.ToString();
            string departamento = dgvIncidencias.CurrentRow.Cells["Nombre departamento"].Value.ToString();
            string incidencia = dgvIncidencias.CurrentRow.Cells["Tipo de incidencia"].Value.ToString();
            DateTime fecha = Convert.ToDateTime(dgvIncidencias.CurrentRow.Cells["Fecha"].Value);

            using (frmJustificante frm = new frmJustificante())
            {
                frm.CargarDatos(id, nombre, departamento, incidencia, fecha);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }
        public void GuardarJustificacion(int idIncidencia, string justificacion)
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"UPDATE tblincidencias
                           SET justificacion=@justificacion
                           WHERE id_incidencia=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@justificacion", justificacion);
                        cmd.Parameters.AddWithValue("@id", idIncidencia);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la justificación: " + ex.Message);
            }
        }
    }
    

}
