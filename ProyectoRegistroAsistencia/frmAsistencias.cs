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
    public partial class frmAsistencias : Form
    {
        clsAsistencias asistencia;
        private bool fechaSeleccionada = false;
        public frmAsistencias()
        {
            InitializeComponent();
            CargarGrid();
        }

        private void dtpFiltroAsistencia_ValueChanged(object sender, EventArgs e)
        {
            fechaSeleccionada = true;
            RealizarBusqueda();
        }

        public void CargarGrid()
        {
            asistencia = new clsAsistencias();
            dgvRegistros.DataSource = null;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvRegistros.DataSource = asistencia.CargaDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFiltroAsistencia.Value = DateTime.Now;
            fechaSeleccionada = false;
            txtApellido.Clear();
            clsAsistencias asistencia = new clsAsistencias();
            dgvRegistros.DataSource = asistencia.CargaDataGrid();

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        // Búsqueda en vivo (por LIKE), sin necesidad de botón Buscar.
        private void RealizarBusqueda()
        {
            try
            {
                clsAsistencias asistencia = new clsAsistencias();

                DateTime? fecha = fechaSeleccionada ? dtpFiltroAsistencia.Value.Date : (DateTime?)null;
                string apellido = txtApellido.Text.Trim();

                dgvRegistros.DataSource = asistencia.BusquedaFecha(fecha, apellido);
            }
            catch
            {
                // No mostrar mensajes mientras se escribe/selecciona
            }
        }
    }
}
