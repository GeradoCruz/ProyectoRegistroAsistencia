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
    public partial class frmPuestos : Form
    {
        public frmPuestos()
        {
            InitializeComponent();
            btnNuevo.Click += btnNuevo_Click;
            btnEditar.Click += btnEditar_Click;
        }

        private void RefrescarGrid()
        {
            // TODO: volver a cargar dgvPuestos desde la base de datos
        }

        private void btnNuevo_Click(object? sender, EventArgs e)
        {
            using (var frm = new frmNuevoPuesto())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            if (dgvPuestos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un puesto de la lista para editar.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: precargar los datos del puesto seleccionado en frmNuevoPuesto
            using (var frm = new frmNuevoPuesto())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }
    }
}
