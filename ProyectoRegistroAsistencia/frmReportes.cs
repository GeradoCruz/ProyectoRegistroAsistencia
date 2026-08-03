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
    // Pantalla de Reportes: lee los filtros, llama a clsReportes y muestra/exporta el resultado.
    public partial class frmReportes : Form
    {
        clsReportes reportes;
        DataTable tabla; // último reporte generado, lo usa Exportar
        int idDepartamento;

        public frmReportes()
        {
            InitializeComponent();
            CargarCombo();
        }

        // Llena el combo Departamento (incluye opción "todos" con id 0).
        public void CargarCombo()
        {
            reportes = new clsReportes();

            try
            {
                // Traer el catálogo y agregar la opción "todos" al inicio
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

        // Título del reporte activo (para el PDF, Excel e impresión).
        private string ObtenerTitulo()
        {
            if (rdbAsistencia.Checked) return "Reporte de Asistencia y Puntualidad";
            if (rdbAntiguedad.Checked) return "Reporte de Antigüedad de Personal";
            if (rdbSinHorario.Checked) return "Reporte de Empleados sin Horario Asignado";
            return "Reporte";
        }

        // "Desde" no puede ser mayor que "Hasta".
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

        // Genera el reporte según el radio button activo y lo muestra en el grid.
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Antigüedad y Sin Horario no usan rango de fechas, se valida solo para los demás reportes
            bool usaFechas = !rdbAntiguedad.Checked && !rdbSinHorario.Checked;
            if (usaFechas && !ValidarFechas()) return;

            reportes = new clsReportes();
            dgvReporte.DataSource = null;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Leer filtros de pantalla
                idDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
                string apellidos = txtApellidos.Text.Trim();

                // Elegir la consulta según el tipo de reporte seleccionado
                if (rdbAsistencia.Checked)
                {
                    tabla = reportes.ConsultarTardanzasFaltas(dtpFechaInicio.Value, dtpFechaFin.Value, idDepartamento, apellidos);
                }
                else if (rdbAntiguedad.Checked)
                {
                    tabla = reportes.ConsultarAntiguedad(idDepartamento, apellidos);
                }
                else if (rdbSinHorario.Checked)
                {
                    tabla = reportes.ConsultarEmpleadosSinHorario(idDepartamento, apellidos);
                }

                // Mostrar resultado en el grid
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

        // Evita exportar/imprimir si todavía no se generó un reporte con datos.
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
                // Nombre de archivo sugerido = título del reporte con guiones bajos
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
                // Nombre de archivo sugerido = título del reporte con guiones bajos
                reportes.ExportarExcel(tabla, ObtenerTitulo(), ObtenerTitulo().Replace(" ", "_") + ".xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar el Excel: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Regresa todos los filtros a su estado inicial y limpia el grid.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Restablecer filtros
            rdbAsistencia.Checked = true;
            cmbDepartamento.SelectedIndex = 0;
            txtApellidos.Clear();
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

            // Vaciar resultados
            dgvReporte.DataSource = null;
            tabla = null;
        }
    }
}
