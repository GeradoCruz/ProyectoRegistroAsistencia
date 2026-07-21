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
            btnAsignarHorario.Click += btnAsignarHorario_Click;
            cargarCombo();
            cargarGrid();
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
                dgvHorarios.Columns["id_semestre"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void RefrescarGrid()
        {
            // TODO: volver a cargar dgvHorarios desde la base de datos
        }

        private void btnAsignarHorario_Click(object? sender, EventArgs e)
        {
            using (var frm = new frmAsignacionHorarios())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }
        public void cargarCombo()
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
            if (cmbDepartamento.SelectedValue == null) return;

            idDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);

            horario = new clsHorarioSemanal();
            dgvHorarios.DataSource = null;
            try
            {
                if (idDepartamento == 0)
                {
                    dgvHorarios.DataSource = horario.cargarDataGrid();
                }
                else
                {
                    dgvHorarios.DataSource = horario.consultar(idDepartamento);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvHorarios.Columns["id_trabajador"].Visible = false;
            dgvHorarios.Columns["id_semestre"].Visible = false;
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbDepartamento.SelectedIndex = 0; // vuelve a "Selecciona una Carrera"
            cargarGrid();
        }
    }
}
