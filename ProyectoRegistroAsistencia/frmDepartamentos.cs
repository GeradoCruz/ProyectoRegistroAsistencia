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
        clsDepartamentos departamentos;
        int idDepartamentoSeleccionado = 0; // 0 = no hay ninguna fila seleccionada

        public frmDepartamentos()
        {
            InitializeComponent();
            CargarDataGrid();
        }

        public void CargarDataGrid()
        {
            departamentos = new clsDepartamentos();
            dgvDepartamentos.DataSource = null;
            dgvDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvDepartamentos.DataSource = departamentos.Consultar("");
                dgvDepartamentos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el listado de departamentos: " + ex.Message,
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartamentos.CurrentRow == null)
            {
                idDepartamentoSeleccionado = 0;
                return;
            }
            idDepartamentoSeleccionado = Convert.ToInt32(dgvDepartamentos.CurrentRow.Cells["Id"].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var frm = new frmNuevoDepartamento())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarDataGrid();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un departamento de la lista para editarlo.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var frm = new frmNuevoDepartamento())
            {
                try
                {
                    frm.lblTitulo.Text = "Editar Departamento";
                    frm.IdDepartamento = Convert.ToInt32(dgvDepartamentos.CurrentRow.Cells["Id"].Value);
                    frm.txtDepartamento.Text = dgvDepartamentos.CurrentRow.Cells["Departamento"].Value.ToString();
                    frm.txtDescripcion.Text = dgvDepartamentos.CurrentRow.Cells["Descripcion"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar el departamento seleccionado: " + ex.Message,
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
            if (dgvDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un departamento de la lista para darlo de baja.",
                    "Staff Asistence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreDepartamento = dgvDepartamentos.CurrentRow.Cells["Departamento"].Value.ToString();
            var respuesta = MessageBox.Show(
                $"¿Deseas dar de baja el departamento \"{nombreDepartamento}\"?\nDejará de aparecer en el catálogo, pero su información no se borrará.",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                departamentos = new clsDepartamentos();
                departamentos.IdDepartamento = Convert.ToInt32(dgvDepartamentos.CurrentRow.Cells["Id"].Value);
                string resultado = departamentos.DarDeBaja();
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
