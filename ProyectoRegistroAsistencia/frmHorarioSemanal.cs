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
    public partial class frmHorarioSemanal : Form
    {
        public frmHorarioSemanal()
        {
            InitializeComponent();
            btnAsignarHorario.Click += btnAsignarHorario_Click;
        }

        private void RefrescarGrid()
        {
            // TODO: volver a cargar dgvHorarios desde la base de datos
        }

        private void btnAsignarHorario_Click(object? sender, EventArgs e)
        {
            using (var frm = new frmAsignacionHorarios())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarGrid();
                }
            }
        }
    }
}
