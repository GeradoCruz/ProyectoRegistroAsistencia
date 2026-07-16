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
    public partial class frmRegistroAsistencia : Form
    {
        public frmRegistroAsistencia()
        {
            InitializeComponent();
            KeyPreview = true;

        }

        private void btnRegistrar_Click(object? sender, EventArgs e)
        {

            string clave = string.IsNullOrEmpty(txtClaveTrabajador.Text) ? null : txtClaveTrabajador.Text;

            if (clave == null)
            {
                MessageBox.Show("Escribe tu clave de trabajador.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void frmRegistroAsistencia_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                e.Handled = true;
                AbrirPanelAdministrador();
            }
        }

        private void AbrirPanelAdministrador()
        {
            Hide();
            using (var login = new frmAccesoAdmin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    var principal = new frmPrincipal();
                    principal.FormClosed += (s, args) => Show();
                    principal.Show();
                }
                else
                {
                    Show();
                }
            }
        }
    }
}
