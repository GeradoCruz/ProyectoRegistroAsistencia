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

            cmbTipoIncidencia.Items.Clear();
            cmbTipoIncidencia.Items.Add("Todos");
            cmbTipoIncidencia.Items.Add("Falta");
            cmbTipoIncidencia.Items.Add("Retardo");

            cmbTipoIncidencia.SelectedIndex = 0;
            cmbTipoIncidencia.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpFecha.ShowCheckBox = true;
            dtpFecha.Checked = false;

            incidencias = new clsIncidencias();
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
        private void RefrescarGrid()
        {
           
            dgvIncidencias.DataSource = incidencias.CargarDataGrid();
            dgvIncidencias.Columns["id_incidencia"].Visible = false;
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

                string nombre = txtNombreTrabajador.Text.Trim();

                string? tipo = null;

                if (cmbTipoIncidencia.SelectedItem != null &&
                    cmbTipoIncidencia.SelectedItem.ToString() != "Todos")
                {
                    tipo = cmbTipoIncidencia.SelectedItem.ToString();
                }


                //le puse nombre------------------------------------------------------------------
                dgvIncidencias.DataSource = incidencias.FiltrarBusqueda(fecha, nombre, tipo);
                dgvIncidencias.Columns["id_incidencia"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {
            if (dgvIncidencias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una incidencia.");
                return;
            }

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
    }


}
