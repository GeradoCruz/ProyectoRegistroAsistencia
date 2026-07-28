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
    public partial class frmReportes : Form
    {
        clsReportes reportes;
        DataTable tabla;
        int idDepartamento;

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
                MessageBox.Show("Error al mostrar los Departamentos: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Título del reporte seleccionado actualmente, se usa para el PDF, Excel e Impresión
        private string ObtenerTitulo()
        {
            if (rdbSemanal.Checked) return "Reporte de Asistencia Semanal";
            if (rdbMensual.Checked) return "Reporte de Tardanzas y Faltas";
            if (rdbIncidencias.Checked) return "Reporte de Incidencias por Empleado";
            return "Reporte";
        }

        private bool ValidarFechas()
        {
            if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!ValidarFechas()) return;

            reportes = new clsReportes();
            dgvReporte.DataSource = null;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                idDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);

                if (rdbSemanal.Checked)
                {
                    tabla = reportes.ConsultarAsistenciaSemanal(dtpFechaInicio.Value, dtpFechaFin.Value, idDepartamento);
                }
                else if (rdbMensual.Checked)
                {
                    tabla = reportes.ConsultarTardanzasFaltas(dtpFechaInicio.Value, dtpFechaFin.Value, idDepartamento);
                }
                else if (rdbIncidencias.Checked)
                {
                    tabla = reportes.ConsultarIncidenciasPorEmpleado(dtpFechaInicio.Value, dtpFechaFin.Value, idDepartamento);
                }

                dgvReporte.DataSource = tabla;

                if (tabla == null || tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró información con los filtros seleccionados.",
                        "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo generar el reporte",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HayDatosParaExportar()
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("Primero genera un reporte con información antes de exportarlo o imprimirlo.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (!HayDatosParaExportar()) return;

            reportes = new clsReportes();
            try
            {
                reportes.ExportarPDF(tabla, ObtenerTitulo(), ObtenerTitulo().Replace(" ", "_") + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar el PDF: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (!HayDatosParaExportar()) return;

            reportes = new clsReportes();
            try
            {
                reportes.ExportarExcel(tabla, ObtenerTitulo(), ObtenerTitulo().Replace(" ", "_") + ".xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar el Excel: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!HayDatosParaExportar()) return;

            reportes = new clsReportes();
            try
            {
                reportes.Imprimir(tabla, ObtenerTitulo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar el reporte a imprimir: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
