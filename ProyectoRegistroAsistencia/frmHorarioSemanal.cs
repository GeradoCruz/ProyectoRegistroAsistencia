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
    public partial class frmHorarioSemanal : Form
    {
        clsHorarioSemanal horario;
        private int idDepartamento;
        public frmHorarioSemanal()
        {
            InitializeComponent();
            cargarComboBox();
            cargarGrid();
            cargarGridDiasHorario(1);

        }
        public void cargarGrid()
        {
            horario = new clsHorarioSemanal();
            dgvHorarios.DataSource = null;
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvHorarios.DataSource = horario.cargarDataGrid();
                dgvHorarios.Columns["id_trabajador"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //Evento que se dispara cuando se selecciona una fila en el DataGridView dgvHorarios
        private void dgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                int idTrabajador = Convert.ToInt32(dgvHorarios.Rows[e.RowIndex].Cells["id_trabajador"].Value);
                cargarGridDiasHorario(idTrabajador);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cargarGridDiasHorario(int idTrabajador)
        {
            horario = new clsHorarioSemanal();
            try
            {

                dgvDiasHorarios.DataSource = null;
                dgvDiasHorarios.DataSource = horario.cargarDataGridDiasHorarios(idTrabajador);
                dgvDiasHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
        private void btnAsignarHorario_Click(object? sender, EventArgs e)
        {
            using (var frm = new frmAsignacionHorarios())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    cargarGrid();
                    // Buscar la fila del trabajador que acabamos de asignar
                    foreach (DataGridViewRow fila in dgvHorarios.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells["id_trabajador"].Value) == frm.IdTrabajadorAsignado)
                        {
                            fila.Selected = true;
                            dgvHorarios.CurrentCell = fila.Cells[1];
                            cargarGridDiasHorario(frm.IdTrabajadorAsignado);
                            break;
                        }
                    }
                }
            }
        }
        public void cargarComboBox()
        {
            horario = new clsHorarioSemanal();
            try
            {
                DataTable dtCarrera = horario.ObtenerDepartamento();
                DataRow filaCarrera = dtCarrera.NewRow();
                filaCarrera["id_departamento"] = 0;
                filaCarrera["nombre_departamento"] = "-- Selecciona una Carrera --";
                dtCarrera.Rows.InsertAt(filaCarrera, 0);

                cmbDepartamento.DataSource = dtCarrera;
                cmbDepartamento.DisplayMember = "nombre_departamento";
                cmbDepartamento.ValueMember = "id_departamento";
                cmbDepartamento.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús desplegables: " + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            horario = new clsHorarioSemanal();

            try
            {
                if (cmbDepartamento.SelectedValue == null)
                    return;

                idDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);

                if (idDepartamento == 0)
                {
                    dgvHorarios.DataSource = horario.cargarDataGrid();
                }
                else
                {
                    dgvHorarios.DataSource = horario.consultarPorBusquedaDepartamento(idDepartamento);
                }
                dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbDepartamento.SelectedIndex = 0; // vuelve a "Selecciona una Carrera"
            cargarGrid();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                horario = new clsHorarioSemanal();

                string apellido = txtApellido.Text.Trim();

                if (!string.IsNullOrWhiteSpace(apellido))
                {
                    dgvHorarios.DataSource = horario.BusquedaNombreApellido(apellido);
                }
                else
                {
                    cargarGrid();
                }
            }
            catch
            {
                // No mostrar mensajes mientras escribe
            }
        }
    }
}
