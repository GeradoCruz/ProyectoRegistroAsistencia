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
        public frmJustificante()
        {
            InitializeComponent();
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        // Llamar despues de new frmJustificante() para precargar los datos
        // de solo lectura de la incidencia seleccionada en frmIncidencias.
        public void CargarDatos(string nombre, string departamento, string incidencia, DateTime fecha)
        {
            txtNombre.Text = nombre;
            txtDepartamento.Text = departamento;
            txtIncidencia.Text = incidencia;
            dtpFecha.Value = fecha;
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJustificante.Text))
            {
                MessageBox.Show("Escribe el motivo del justificante.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: guardar el justificante en la base de datos

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
