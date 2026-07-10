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
    public partial class frmIncidencias : Form
    {
        public frmIncidencias()
        {
            InitializeComponent();
            btnJustificar.Click += btnJustificar_Click;
        }

        private void RefrescarGrid()
        {
            // TODO: volver a cargar dgvIncidencias desde la base de datos
        }

        private void btnJustificar_Click(object? sender, EventArgs e)
        {
            if (dgvIncidencias.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una incidencia de la lista para justificar.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var frm = new frmJustificante())
            {
                // TODO: precargar los datos de la incidencia seleccionada
                // frm.CargarDatos(nombre, departamento, incidencia, fecha);

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }
    }
}
