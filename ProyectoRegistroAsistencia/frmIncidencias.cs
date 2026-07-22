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

            incidencias = new clsIncidencias();
            dgvIncidencias.DataSource = null;
            dgvIncidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvIncidencias.DataSource = incidencias.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void RefrescarGrid()
        {
            // TODO: volver a cargar dgvIncidencias desde la base de datos
        }

        private void btnJustificar_Click(object? sender, EventArgs e)
        {
            if (dgvIncidencias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una incidencia de la lista para justificar.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            using (var frm = new frmJustificante())
            {
                // TODO: precargar los datos de la incidencia seleccionada
                // frm.CargarDatos(nombre, departamento, incidencia, fecha);

                if (frm.ShowDialog(this) == DialogResult.OK)
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

                int? tipo = null;

                if (cmbTipoIncidencia.SelectedValue != null)
                {
                    tipo = Convert.ToInt32(cmbTipoIncidencia.SelectedValue);
                }

                dgvIncidencias.DataSource = incidencias.FiltrarBusqueda(fecha, clave, tipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
