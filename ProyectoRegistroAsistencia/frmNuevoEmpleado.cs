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
    public partial class frmNuevoEmpleado : Form
    {
        public frmNuevoEmpleado()
        {
            InitializeComponent();
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtClaveTrabajador.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                MessageBox.Show("Completa al menos Clave, Nombre(s) y Apellido Paterno.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rdbHombre.Checked && !rdbMujer.Checked)
            {
                MessageBox.Show("Selecciona el genero (H/M).", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            // TODO: guardar el nuevo empleado en la base de datos

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
