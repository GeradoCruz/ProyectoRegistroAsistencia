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
            clsLogin login = new clsLogin();
            login.Usuario = string.IsNullOrEmpty(txtUsuario.Text) ? null : txtUsuario.Text;
            login.Password = string.IsNullOrEmpty(txtPassword.Text) ? null : txtPassword.Text;

            if (login.Usuario == null)
            {
                MessageBox.Show("Escribe tu usuario.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (login.Password == null)
            {
                MessageBox.Show("Escribe tu contraseña.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                bool resp = login.ValidarAcceso();
                if (resp == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error de Autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
