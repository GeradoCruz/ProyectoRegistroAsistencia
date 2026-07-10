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
    public partial class frmAsignacionHorarios : Form
    {
        public frmAsignacionHorarios()
        {
            InitializeComponent();
            btnBuscar.Click += btnBuscar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusacarClave.Text))
            {
                MessageBox.Show("Escribe la clave del trabajador a buscar.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: buscar al trabajador en la base de datos y llenar
            // txtBuscarNombreCompleto, txtDepartamento, txtPuesto y txtSemestre
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBuscarNombreCompleto.Text))
            {
                MessageBox.Show("Primero busca un trabajador valido.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(chkLunes.Checked || chkMartes.Checked || chkMiercoles.Checked ||
                  chkJueves.Checked || chkViernes.Checked))
            {
                MessageBox.Show("Selecciona al menos un dia.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            // TODO: guardar la asignacion de horario en la base de datos

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
