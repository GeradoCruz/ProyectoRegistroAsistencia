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
        public frmAsistencias()
        {
            InitializeComponent();
            CargarGrid();
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsAsistencias asistencia = new clsAsistencias();

                DateTime fecha = dtpFiltroAsistencia.Value.Date;
                string clave = txtClaveTrabajador.Text.Trim();

                DataTable resultado = asistencia.BusquedaFecha(fecha, clave);

                dgvRegistros.DataSource = resultado;

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros.", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFiltroAsistencia.Value = DateTime.Now;
            txtClaveTrabajador.Clear();
            clsAsistencias asistencia = new clsAsistencias();
            dgvRegistros.DataSource = asistencia.CargaDataGrid();

        }
    }
}
