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
    public partial class frmJustificante : Form
    {
        public frmJustificante()
        {
            InitializeComponent();

        }
        public void CargarDatos(string nombre, string departamento, string incidencia, DateTime fecha)
        {
            txtNombre.Text = nombre;
            txtDepartamento.Text = departamento;
            txtIncidencia.Text = incidencia;
            dtpFecha.Value = fecha;
        }
    }
}
