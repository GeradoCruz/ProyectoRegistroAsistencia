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
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
            btnNuevo.Click += btnNuevo_Click;
            btnEditar.Click += btnEditar_Click;
        }

        private void RefrescarGrid()
        {
            // TODO: volver a cargar dgvDepartamentos desde la base de datos
        }

        private void btnNuevo_Click(object? sender, EventArgs e)
        {
            using (var frm = new frmNuevoDepartamento())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            if (dgvDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un departamento de la lista para editar.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: precargar los datos del departamento seleccionado en frmNuevoDepartamento
            using (var frm = new frmNuevoDepartamento())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }
    }
}
