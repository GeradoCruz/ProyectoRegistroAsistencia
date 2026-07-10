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
        // Se crea una sola instancia de cada pantalla y se reutiliza,
        // asi no se pierden los filtros/datos capturados al cambiar de modulo y volver.
        private readonly frmAsistencias _asistencias = new frmAsistencias();
        private readonly frmEmpleados _empleados = new frmEmpleados();
        private readonly frmHorarioSemanal _horarios = new frmHorarioSemanal();
        private readonly frmDepartamentos _departamentos = new frmDepartamentos();
        private readonly frmPuestos _puestos = new frmPuestos();
        private readonly frmIncidencias _incidencias = new frmIncidencias();
        private readonly frmReportes _reportes = new frmReportes();

        public frmPrincipal()
        {
            InitializeComponent();

            btnAsistencias.Click += btnAsistencias_Click;
            btnEmpleados.Click += btnEmpleados_Click;
            btnHorarios.Click += btnHorarios_Click;
            btnDepartamentos.Click += btnDepartamentos_Click;
            btnPuestos.Click += btnPuestos_Click;
            btnIncidencias.Click += btnIncidencias_Click;
            btnReportes.Click += btnReportes_Click;
            btnCerrarSesion.Click += btnCerrarSesion_Click;

            this.Load += frmPrincipal_Load;
        }

        private void frmPrincipal_Load(object? sender, EventArgs e)
        {
            // Asistencias es la vista que siempre se muestra al arrancar el panel de administracion.
            AbrirModulo(_asistencias, btnAsistencias);
        }

        /// <summary>
        /// Carga "modulo" dentro de pnlContenido, quitando el que estuviera antes,
        /// y resalta el boton del sidebar correspondiente (si aplica).
        /// </summary>
        private void AbrirModulo(Form modulo, Button? botonActivo)
        {
            pnlContenido.SuspendLayout();
            pnlContenido.Controls.Clear();

            modulo.TopLevel = false;
            modulo.FormBorderStyle = FormBorderStyle.None;
            modulo.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(modulo);
            modulo.Show();

            pnlContenido.ResumeLayout();

            ResaltarBoton(botonActivo);
        }

        private void ResaltarBoton(Button? botonActivo)
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
            }
        }

        private void btnAsistencias_Click(object? sender, EventArgs e) => AbrirModulo(_asistencias, btnAsistencias);
        private void btnEmpleados_Click(object? sender, EventArgs e) => AbrirModulo(_empleados, btnEmpleados);
        private void btnHorarios_Click(object? sender, EventArgs e) => AbrirModulo(_horarios, btnHorarios);
        private void btnDepartamentos_Click(object? sender, EventArgs e) => AbrirModulo(_departamentos, btnDepartamentos);
        private void btnPuestos_Click(object? sender, EventArgs e) => AbrirModulo(_puestos, btnPuestos);
        private void btnIncidencias_Click(object? sender, EventArgs e) => AbrirModulo(_incidencias, btnIncidencias);
        private void btnReportes_Click(object? sender, EventArgs e) => AbrirModulo(_reportes, btnReportes);

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Deseas cerrar sesión?", "Staff Asistence",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                this.Hide();
                new frmAccesoAdmin().Show();
            }
        }
    }
}
