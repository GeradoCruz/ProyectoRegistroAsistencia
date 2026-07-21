using MySqlConnector;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace ProyectoRegistroAsistencia
{
    internal class clsRegistroAsistencia
    {
        private int idRegistro;
        private string fecha;
        private string registro;
        private string rutaFoto;
        private string claveTrabajador;
        private Bitmap foto;
        private string msg;
        private bool exito;
        private MySqlCommand comando;
        

        public bool Exito { get => exito; }
        public int IdRegistro { get => idRegistro; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Registro { get => registro; set => registro = value; }
        public string RutaFoto { get => rutaFoto; set => rutaFoto = value; }
        public string ClaveTrabajador { get => claveTrabajador; set => claveTrabajador = value; }
        public Bitmap Foto { get => foto; set => foto = value; }

        public string RegistrarAistencia()
        {
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sqlTrabajador = "SELECT id_trabajador FROM tbltrabajador WHERE clave_trabajador = @clave;";
                    object resultado;
                    using (comando = new MySqlCommand(sqlTrabajador, conexion))
                    {
                        comando.Parameters.AddWithValue("@clave", claveTrabajador);
                        resultado = comando.ExecuteScalar();
                    }

                    if (resultado == null)
                    {
                        exito = false;
                        msg = "No se encontró ningún trabajador con esa clave.";
                    }
                    else
                    {
                        int idTrabajadorEncontrado = Convert.ToInt32(resultado);

                        if (foto != null)
                        {
                            string carpetaFotos = Path.Combine(Application.StartupPath, "FotosAsistencia");
                            if (!Directory.Exists(carpetaFotos))
                                Directory.CreateDirectory(carpetaFotos);

                            rutaFoto = Path.Combine(carpetaFotos, $"{claveTrabajador}_{DateTime.Now:yyyyMMdd_HHmmss}.jpg");
                            foto.Save(rutaFoto, ImageFormat.Png);
                        }

                        string sqlInsert = "INSERT INTO tblAsistencia(fecha,registro,ruta_foto,id_trabajador) VALUES(@fecha,@registro,@rutaFoto,@idTrabajador);SELECT LAST_INSERT_ID();";
                        using (comando = new MySqlCommand(sqlInsert, conexion))
                        {
                            comando.Parameters.AddWithValue("@fecha", fecha);
                            comando.Parameters.AddWithValue("@registro", registro);
                            comando.Parameters.AddWithValue("@rutaFoto", rutaFoto);
                            comando.Parameters.AddWithValue("@idTrabajador", idTrabajadorEncontrado);
                            idRegistro = Convert.ToInt32(comando.ExecuteScalar());
                        }

                        exito = true;
                        msg = "Se registró su asistencia correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion: " + ex.Message);
            }
            return msg;
        }
    }
}