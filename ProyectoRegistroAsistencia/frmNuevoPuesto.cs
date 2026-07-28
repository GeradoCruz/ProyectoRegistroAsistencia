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
    public partial class frmNuevoPuesto : Form
    {
        clsPuestos puestos;

        // 0 mientras sea un puesto nuevo; se llena con el Id real cuando se abre para editar
        public int IdPuesto { get; set; } = 0;

        public frmNuevoPuesto()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombrePuesto.Text))
            {
                MessageBox.Show("Escribe el nombre del puesto.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrePuesto.Focus();
                return false;
            }

            if (txtNombrePuesto.Text.Trim().Length < 3)
            {
                MessageBox.Show("El nombre del puesto debe tener al menos 3 caracteres.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrePuesto.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                int tipoOperacion = IdPuesto == 0 ? 0 : 1;

                puestos = new clsPuestos();
                puestos.IdPuesto = IdPuesto;
                puestos.NombrePuesto = txtNombrePuesto.Text.Trim();
                puestos.Descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim();

                string msg;

                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmas que deseas actualizar este puesto?",
                        "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp != DialogResult.Yes) return;
                }

                msg = puestos.GuardarActualizar(tipoOperacion);
                MessageBox.Show(msg, "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar el puesto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
