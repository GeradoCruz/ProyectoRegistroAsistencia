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
                //aqui iria el codigo para ocultar la columna de id_incidencia----------------------------------------------------------
                dgvIncidencias.Columns["id_incidencia"].Visible = false;

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

        private void btnJustificar_Click_1(object sender, EventArgs e)
        {
            if (dgvIncidencias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una incidencia.");
                return;
            }

            string nombre = dgvIncidencias.CurrentRow.Cells["Nombre completo"].Value.ToString();
            string departamento = dgvIncidencias.CurrentRow.Cells["Nombre departamento"].Value.ToString();
            string incidencia = dgvIncidencias.CurrentRow.Cells["Tipo de incidencia"].Value.ToString();
            DateTime fecha = Convert.ToDateTime(dgvIncidencias.CurrentRow.Cells["Fecha"].Value);

            frmJustificante frm = new frmJustificante();

            frm.CargarDatos(nombre, departamento, incidencia, fecha);

            frm.ShowDialog();
        }
    }

}
