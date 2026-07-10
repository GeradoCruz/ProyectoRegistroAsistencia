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
            KeyDown += frmRegistroAsistencia_KeyDown;
        }

        private void frmRegistroAsistencia_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                e.Handled = true;
                AbrirPanelAdministrador();
            }
        }

        /// <summary>
        /// F5: cierra (oculta) el registro de asistencia y pide las credenciales
        /// de administrador. Si son correctas abre el panel de administración;
        /// si se cancela (Esc), vuelve a mostrar el registro de asistencia.
        /// </summary>
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
