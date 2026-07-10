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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            btnNuevo.Click += btnNuevo_Click;
            btnEditar.Click += btnEditar_Click;
            btnDarBaja.Click += btnDarBaja_Click;
        }

        private void RefrescarGrid()
        {
            // TODO: volver a cargar dgvEmpleados desde la base de datos
        }

        private void btnNuevo_Click(object? sender, EventArgs e)
        {
            using (var frm = new frmNuevoEmpleado())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un empleado de la lista para editar.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: precargar los datos del empleado seleccionado en frmNuevoEmpleado
            using (var frm = new frmNuevoEmpleado())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }

        private void btnDarBaja_Click(object? sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un empleado de la lista para dar de baja.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Deseas dar de baja a este empleado?", "Staff Asistence",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // TODO: dar de baja al empleado en la base de datos
                RefrescarGrid();
            }
        }
    }
}
