using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoRegistroAsistencia
{
    public partial class frmReportes : Form
    {
        clsReportes reportes;
        DataTable tabla;
        public frmReportes()
        {
            InitializeComponent();
            CargarCombo();
        }

        public void CargarCombo()
        {
            reportes = new clsReportes();

            try
            {
                DataTable dtDepartamentos = reportes.obtenerDepartamentos();

                DataRow filaDepartamento = dtDepartamentos.NewRow();
                filaDepartamento["id_departamento"] = 0;
                filaDepartamento["nombre_departamento"] = "--Seleccionar Departamento--";
                dtDepartamentos.Rows.InsertAt(filaDepartamento, 0);

                //Enlazamos los datos al comboBox visual
                cmbDepartamento.DataSource = dtDepartamentos;
                cmbDepartamento.DisplayMember = "nombre_departamento";
                cmbDepartamento.ValueMember = "id_departamento";
                cmbDepartamento.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los Departamentos: " + ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            reportes = new clsReportes();
            dgvReporte.DataSource = null;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                int idDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);

                if (rdbSemanal.Checked)
                {
                    tabla = reportes.ConsultarAsistenciaSemanal(dtpFechaInicio.Value, dtpFechaFin.Value, idDepartamento);
                    dgvReporte.DataSource = tabla;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
