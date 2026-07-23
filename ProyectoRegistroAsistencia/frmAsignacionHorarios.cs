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
    public partial class frmAsignacionHorarios : Form
    {
        private clsHorarioSemanal horario;
        public frmAsignacionHorarios()
        {
            InitializeComponent();
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            CargarComboSemestre();
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtBusacarClave.Text))
            {
                MessageBox.Show("Escribe la clave del trabajador a buscar.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: buscar al trabajador en la base de datos y llenar
            // txtBuscarNombreCompleto, txtDepartamento, txtPuesto y txtSemestre

            horario = new clsHorarioSemanal();
            horario.ClaveTrabajador = txtBusacarClave.Text;

            try
            {
                horario.buscarTrabajador();
                txtBuscarNombreCompleto.Text = horario.NombreTrabajador;
                txtDepartamento.Text = horario.Departamento;
                txtPuesto.Text = horario.Puesto;

                if (horario.IdSemestre > 0)
                {
                    cmbSemestre.SelectedValue = horario.IdSemestre;
                }
                else
                {
                    cmbSemestre.SelectedIndex = 0;   // vuelve a " Selecciona un semestre "
                }


                CheckBox[] checksDias = { chkLunes, chkMartes, chkMiercoles, chkJueves, chkViernes };
                for (int i = 0; i < checksDias.Length; i++)
                {
                    int idDia = i + 1;
                    checksDias[i].Checked = false;

                    checksDias[i].Enabled = !horario.TieneHorarioAsignado(horario.IdTrabajador, idDia,horario.IdSemestre );
                }

                DataTable diasFalta = horario.diasFaltantes(horario.IdTrabajador);

                if (diasFalta.Rows.Count > 0 )
                {
                    string mensaje = "Días pendientes por asignar:\n";
                    foreach (DataRow fila in diasFalta.Rows)
                    {
                        mensaje += "- " + fila["nombre_dia"].ToString() + "\n";
                    }
                    if(horario.IdSemestre == 0)
                    {
                        mensaje += "¡¡Avisó¡¡";
                        mensaje += "\n-Seleccione un Semestre";
                    }
                    MessageBox.Show(mensaje, "Staff Asistence",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBuscarNombreCompleto.Text))
            {
                MessageBox.Show("Primero busca un trabajador valido.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(chkLunes.Checked || chkMartes.Checked || chkMiercoles.Checked ||
                  chkJueves.Checked || chkViernes.Checked))
            {
                MessageBox.Show("Selecciona al menos un dia.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // la validación extra para que no se guarde semestre con 0:
            if (cmbSemestre.SelectedValue == null || Convert.ToInt32(cmbSemestre.SelectedValue) == 0)
            {
                MessageBox.Show("Selecciona un semestre.", "Staff Asistence",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            // TODO: guardar la asignacion de horario en la base de datos
            try
            {
                // Guardamos las horas seleccionadas
                horario.HoraEntrada = dtpHoraEntrada.Value.ToString("HH:mm:ss");
                horario.HoraSalida = dtpHoraSalida.Value.ToString("HH:mm:ss");
                horario.IdSemestre = Convert.ToInt32(cmbSemestre.SelectedValue); // toma el valor del combo, no el que trajo la búsqueda


                // Guardar los días seleccionados

                CheckBox[] checksDias = { chkLunes, chkMartes, chkMiercoles, chkJueves, chkViernes };
                for (int i = 0; i < checksDias.Length; i++)
                {

                    if (checksDias[i].Checked)
                    {
                        horario.IdDia = i + 1;
                        horario.GuardarHorario();
                    }
                }

                MessageBox.Show("Los horarios se guardaron correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public void CargarComboSemestre()
        {
            horario = new clsHorarioSemanal();
            try
            {
                DataTable dtSemestres = horario.ObtenerSemestres();

                DataRow filaVacia = dtSemestres.NewRow();
                filaVacia["id_semestre"] = 0;
                filaVacia["semestre"] = " Selecciona un semestre ";
                dtSemestres.Rows.InsertAt(filaVacia, 0);

                cmbSemestre.DataSource = dtSemestres;
                cmbSemestre.DisplayMember = "semestre";
                cmbSemestre.ValueMember = "id_semestre";
                cmbSemestre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los semestres: " + ex.Message);
            }
        }
    }
}
