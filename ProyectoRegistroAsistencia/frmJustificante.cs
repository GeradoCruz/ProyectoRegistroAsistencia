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
    public partial class frmJustificante : Form
    {
        private int idIncidencia;
        private clsIncidencias incidencias = new clsIncidencias();
        public frmJustificante()
        {
            InitializeComponent();

        }
        public void CargarDatos(int id,
                        string nombre,
                        string departamento,
                        string incidencia,
                        DateTime fecha)
        {
            idIncidencia = id;

            txtNombre.Text = nombre;
            txtDepartamento.Text = departamento;
            txtIncidencia.Text = incidencia;
            dtpFecha.Value = fecha;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJustificante.Text))
            {
                MessageBox.Show("Escribe una justificación.");

                return;
            }

            try
            {
                incidencias.GuardarJustificacion(
                    idIncidencia,
                    txtJustificante.Text.Trim());

                MessageBox.Show("Justificación guardada correctamente.");

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
