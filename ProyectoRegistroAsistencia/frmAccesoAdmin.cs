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
    public partial class frmAccesoAdmin : Form
    {
        public frmAccesoAdmin()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void frmAccesoAdmin_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnInicioSesion_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Ingresa tu usuario y contraseña.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

    }
}
