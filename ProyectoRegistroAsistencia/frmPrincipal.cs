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
    public partial class frmPrincipal : Form
    {
        private clsPrincipal principal;

        public frmPrincipal()
        {
            InitializeComponent();
            principal = new clsPrincipal();
        }

        private void frmPrincipal_Load(object? sender, EventArgs e)
        {
            lblUsuario.Text = clsLogin.usuarioActual;
            if (clsLogin.AuxiliarReporte)
            {
                lblBienvenida.Text = "Bienvenido auxiliar:";
            }
            // El auxiliar de reportes entra directo a Reportes; el administrador entra a Asistencias.
            if (clsLogin.AuxiliarReporte)
            {
                principal.agregarAlContenedor(new frmReportes(), pnlContenido);
                ResaltarBoton(btnReportes);
            }
            else
            {
                principal.agregarAlContenedor(new frmAsistencias(), pnlContenido);
                ResaltarBoton(btnAsistencias);
            }

            btnAsistencias.Enabled = clsLogin.EsAdministrador;
            btnEmpleados.Enabled = clsLogin.EsAdministrador;
            btnHorarios.Enabled = clsLogin.EsAdministrador;
            btnDepartamentos.Enabled = clsLogin.EsAdministrador;
            btnPuestos.Enabled = clsLogin.EsAdministrador;
            btnIncidencias.Enabled = clsLogin.EsAdministrador;
            btnReportes.Enabled = clsLogin.EsAdministrador || clsLogin.AuxiliarReporte;
            btnCerrarSesion.Enabled = clsLogin.EsAdministrador || clsLogin.AuxiliarReporte;
        }

        private void ResaltarBoton(Button botonActivo)
        {
            foreach (Control control in pnlSidebar.Controls)
            {
                if (control is Button boton && boton != btnCerrarSesion)
                {
                    boton.BackColor = Color.FromArgb(74, 126, 193); // Azul Claro = inactivo
                }
            }

            if (botonActivo != null)
            {
                botonActivo.BackColor = Color.FromArgb(43, 76, 140); // Azul Institucional = activo
                lblModuloValor.Text = botonActivo.Text;
            }
        }

        private void btnAsistencias_Click(object? sender, EventArgs e)
        {
            principal.agregarAlContenedor(new frmAsistencias(), pnlContenido);
            ResaltarBoton(btnAsistencias);
        }

        private void btnEmpleados_Click(object? sender, EventArgs e)
        {
            principal.agregarAlContenedor(new frmEmpleados(), pnlContenido);
            ResaltarBoton(btnEmpleados);
        }

        private void btnHorarios_Click(object? sender, EventArgs e)
        {
            principal.agregarAlContenedor(new frmHorarioSemanal(), pnlContenido);
            ResaltarBoton(btnHorarios);
        }

        private void btnDepartamentos_Click(object? sender, EventArgs e)
        {
            principal.agregarAlContenedor(new frmDepartamentos(), pnlContenido);
            ResaltarBoton(btnDepartamentos);
        }

        private void btnPuestos_Click(object? sender, EventArgs e)
        {
            principal.agregarAlContenedor(new frmPuestos(), pnlContenido);
            ResaltarBoton(btnPuestos);
        }

        private void btnIncidencias_Click(object? sender, EventArgs e)
        {
            principal.agregarAlContenedor(new frmIncidencias(), pnlContenido);
            ResaltarBoton(btnIncidencias);
        }

        private void btnReportes_Click(object? sender, EventArgs e)
        {
            principal.agregarAlContenedor(new frmReportes(), pnlContenido);
            ResaltarBoton(btnReportes);
        }

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Deseas cerrar sesión?", "Staff Asistence",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pcbAyuda_MouseDown(object mipictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)mipictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X + 1, pcb.Location.Y + 1);
        }

        private void pcbAyuda_MouseUp(object mipictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)mipictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X - 1, pcb.Location.Y - 1);
        }
    }
}
