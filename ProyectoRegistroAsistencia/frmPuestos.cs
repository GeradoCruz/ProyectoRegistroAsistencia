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
        clsPuestos puestos;

        public frmPuestos()
        {
            InitializeComponent();
            CargarDataGrid();
        }

        public void CargarDataGrid(string filtro = "")
        {
            puestos = new clsPuestos();
            dgvPuestos.DataSource = null;
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvPuestos.DataSource = puestos.Consultar(filtro);
                dgvPuestos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el listado de puestos: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPuestos_SelectionChanged(object sender, EventArgs e)
        {
            // El renglón seleccionado se toma directo del grid al editar/eliminar
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDataGrid(txtBuscarPuesto.Text.Trim());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarPuesto.Clear();
            CargarDataGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var frm = new frmNuevoPuesto())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarDataGrid();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un puesto de la lista para editarlo.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var frm = new frmNuevoPuesto())
            {
                try
                {
                    frm.lblTitulo.Text = "Editar Puesto";
                    frm.IdPuesto = Convert.ToInt32(dgvPuestos.CurrentRow.Cells["Id"].Value);
                    frm.txtNombrePuesto.Text = dgvPuestos.CurrentRow.Cells["Puesto"].Value.ToString();
                    frm.txtDescripcion.Text = dgvPuestos.CurrentRow.Cells["Descripcion"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar el puesto seleccionado: " + ex.Message,
                        "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarDataGrid();
                }
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un puesto de la lista para darlo de baja.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombrePuesto = dgvPuestos.CurrentRow.Cells["Puesto"].Value.ToString();
            var respuesta = MessageBox.Show(
                $"¿Deseas dar de baja el puesto \"{nombrePuesto}\"?\nDejará de aparecer en el catálogo, pero su información no se borrará.",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                puestos = new clsPuestos();
                puestos.IdPuesto = Convert.ToInt32(dgvPuestos.CurrentRow.Cells["Id"].Value);
                string resultado = puestos.DarDeBaja();
                MessageBox.Show(resultado, "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
