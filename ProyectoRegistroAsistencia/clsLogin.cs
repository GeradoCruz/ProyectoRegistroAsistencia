using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRegistroAsistencia
{
    internal class clsLogin
    {
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        

        public static string perfil;
        public static string usuarioActual;
        private static bool esAdministrador;
        private static bool auxiliarReporte;

        public static bool EsAdministrador { get => esAdministrador; }
        public static bool AuxiliarReporte { get => auxiliarReporte; }

        public void AsignarPermiso()
        {
            switch(perfil)
            {
                case "administrador":
                    esAdministrador = true;
                    auxiliarReporte = false;
                    break;
                case "auxiliar_reportes":
                    esAdministrador = false;
                    auxiliarReporte = true;
                    break;
                default:
                    esAdministrador = false;
                    auxiliarReporte = false;
                    break;
            }
        }

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT perfil FROM tblusuarios "
                        + "WHERE nombre_usuario = @usuario AND password = MD5(@password)";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                usuarioActual = usuario;
                                AsignarPermiso();
                                if (!esAdministrador && !auxiliarReporte)
                                {
                                    throw new Exception("no tienes permiso para acceder");
                                }
                                MessageBox.Show("Tu perfil es: " + perfil + " del sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos ");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
