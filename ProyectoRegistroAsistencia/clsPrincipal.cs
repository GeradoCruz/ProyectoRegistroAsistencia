using System.Windows.Forms;

namespace ProyectoRegistroAsistencia
{
    internal class clsPrincipal
    {
        private Form misformsabiertos;

        public void agregarAlContenedor(Form formulario, Panel panel)
        {
            //verifico si esta abierto
            if (misformsabiertos != null)
            {
                misformsabiertos.Close();//cierra la instancia
                misformsabiertos.Dispose();//libera de memoria
            }

            //para abrir el formulario en caso de no estar abierto
            misformsabiertos = formulario;
            panel.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }
    }
}
