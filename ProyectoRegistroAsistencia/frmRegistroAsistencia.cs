using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoRegistroAsistencia
{
    public partial class frmRegistroAsistencia : Form
    {
        private clsCamara camara;
        private string msg;
        public frmRegistroAsistencia()
        {
            InitializeComponent();
            KeyPreview = true;
            IniciarCamara();
        }

        private void IniciarCamara()
        {
            camara = new clsCamara();
            try
            {
                camara.IniciarCamara();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrCamara_Tick(object sender, EventArgs e)
        {
            if (camara.Foto != null)
            {
                pcbCamara.Image = camara.Foto;
            }
        }

        private void frmRegistroAsistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            camara.DetenerCamara();
        }

        private void btnRegistrar_Click(object? sender, EventArgs e)
        {
            try
            {
                string clave = string.IsNullOrEmpty(txtClaveTrabajador.Text) ? null : txtClaveTrabajador.Text;

                if (clave == null)
                {
                    MessageBox.Show("Escribe tu clave de trabajador.", "Staff Asistence",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var registro = new clsRegistroAsistencia();
                registro.Fecha = DateTime.Now.ToString("yyyy-MM-dd");
                registro.Registro = DateTime.Now.ToString("HH:mm:ss");
                registro.ClaveTrabajador = clave;
                registro.Foto = camara.Foto;

                msg = registro.RegistrarAistencia();

                if (registro.Exito)
                {
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtClaveTrabajador.Clear();
                txtClaveTrabajador.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            camara.DetenerCamara();

            Hide();
            using (var login = new frmAccesoAdmin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    var principal = new frmPrincipal();
                    principal.FormClosed += (s, args) => { Show(); IniciarCamara(); };
                    principal.Show();
                }
                else
                {
                    Show();
                    IniciarCamara();
                }
            }
        }
    }
}
