using MySqlConnector;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProyectoRegistroAsistencia
{
    // Esta clase se encarga de registrar la asistencia (entrada/salida) de un trabajador.
    // Un trabajador puede registrar varias entradas/salidas en el mismo día, pero solo la
    // PRIMERA del día se clasifica como Puntual, Retardo o Falta (comparando contra su
    // horario asignado). Las demás se guardan sin ese dato (NULL), para no contarlas de más
    // en los reportes.
    internal class clsRegistroAsistencia
    {
        // Variables privadas de la clase (los datos del registro que se va a guardar)
        private int idRegistro;
        private string fecha;
        private string registro;
        private string rutaFoto;
        private string claveTrabajador;
        private Bitmap foto;
        private string msg;
        private bool exito;
        private MySqlCommand comando;

        // Propiedades públicas para poder leer/escribir esos datos desde el formulario
        public bool Exito { get => exito; }
        public int IdRegistro { get => idRegistro; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Registro { get => registro; set => registro = value; }
        public string RutaFoto { get => rutaFoto; set => rutaFoto = value; }
        public string ClaveTrabajador { get => claveTrabajador; set => claveTrabajador = value; }
        public Bitmap Foto { get => foto; set => foto = value; }

        // Método principal: registra la asistencia. Llama a los demás métodos en orden.
        public string RegistrarAistencia()
        {
            try
            {
                // 1. Buscar el trabajador por su clave
                int idTrabajadorEncontrado = BuscarIdTrabajador(claveTrabajador);

                if (idTrabajadorEncontrado == 0)
                {
                    exito = false;
                    msg = "No se encontró ningún trabajador con esa clave.";
                    return msg;
                }

                // 2. Guardar la foto tomada (si se tomó una)
                GuardarFotoAsistencia();

                // 3. Ver cuántos registros tiene ya el trabajador hoy
                int registrosHoy = ContarRegistrosHoy(idTrabajadorEncontrado);

                // 4. Solo si es el PRIMER registro del día se clasifica (Puntual/Retardo/Falta)
                string estatusRegistro = null;
                if (registrosHoy == 0)
                {
                    estatusRegistro = ClasificarPuntualidad(idTrabajadorEncontrado);
                }

                // 5. Guardar el registro de asistencia en la base de datos
                idRegistro = GuardarRegistro(idTrabajadorEncontrado, estatusRegistro);

                // 6. Armar el mensaje final para el usuario
                exito = true;
                if (estatusRegistro == "Puntual" || estatusRegistro == "Retardo")
                {
                    msg = "Se registró su asistencia correctamente. Estatus: " + estatusRegistro + ".";
                }
                else
                {
                    // Si fue Falta, o no se clasificó (no era el primer registro del día),
                    // no se informa el estatus en pantalla.
                    msg = "Se registró su asistencia correctamente.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion: " + ex.Message);
            }
            return msg;
        }

        // Busca el id_trabajador a partir de la clave capturada.
        // Regresa el id si lo encuentra, o 0 si no existe ningún trabajador con esa clave.
        public int BuscarIdTrabajador(string clave)
        {
            int idEncontrado = 0;
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_trabajador FROM tbltrabajador WHERE clave_trabajador = @clave;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@clave", clave);
                        object resultado = comando.ExecuteScalar();

                        if (resultado != null)
                        {
                            idEncontrado = Convert.ToInt32(resultado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el trabajador: " + ex.Message);
            }
            return idEncontrado;
        }

        // Guarda en disco la foto tomada al momento de registrar la asistencia (si hay una),
        // y actualiza la propiedad RutaFoto con la ruta donde se guardó.
        public void GuardarFotoAsistencia()
        {
            if (foto == null)
            {
                // No se tomó foto, no hay nada que guardar
                return;
            }

            string carpetaFotos = Path.Combine(Application.StartupPath, "FotosAsistencia");

            if (!Directory.Exists(carpetaFotos))
            {
                Directory.CreateDirectory(carpetaFotos);
            }

            rutaFoto = Path.Combine(carpetaFotos, claveTrabajador + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".jpg");
            foto.Save(rutaFoto, ImageFormat.Png);
        }

        // Cuenta cuántos registros de asistencia tiene ya el trabajador en la fecha actual.
        // Si regresa 0, significa que el registro que se está por guardar es el primero del día.
        public int ContarRegistrosHoy(int idTrabajador)
        {
            int cantidad = 0;
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT COUNT(*) FROM tblasistencia WHERE id_trabajador = @idTrabajador AND fecha = @fecha;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                        comando.Parameters.AddWithValue("@fecha", fecha);
                        cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar los registros del día: " + ex.Message);
            }
            return cantidad;
        }

        // Regresa el id_dia (1=Lunes ... 7=Domingo, según tbldias) que le corresponde a la
        // fecha del registro. DayOfWeek de .NET regresa Domingo=0, Lunes=1 ... Sábado=6,
        // así que solo hay que ajustar el caso del domingo.
        public int ObtenerIdDia()
        {
            DateTime fechaRegistro = DateTime.Parse(fecha);
            int idDia;

            if (fechaRegistro.DayOfWeek == DayOfWeek.Sunday)
            {
                idDia = 7;
            }
            else
            {
                idDia = (int)fechaRegistro.DayOfWeek;
            }

            return idDia;
        }

        // Consulta la hora de entrada asignada al trabajador para un día en específico
        // (tblhorario_trabajo). El trabajador ya tiene horario asignado antes de usar el
        // sistema, así que aquí no se valida si existe o no.
        public string ObtenerHoraEntrada(int idTrabajador, int idDia)
        {
            string horaEntrada = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT hora_entrada FROM tblhorario_trabajo " +
                                 "WHERE id_trabajador = @idTrabajador AND id_dia = @idDia LIMIT 1;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTrabajador", idTrabajador);
                        comando.Parameters.AddWithValue("@idDia", idDia);
                        horaEntrada = comando.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el horario del trabajador: " + ex.Message);
            }
            return horaEntrada;
        }

        // Convierte una hora en formato "HH:mm:ss" a minutos totales, usando solo enteros.
        // Ejemplo: "08:15:00" -> 8*60 + 15 = 495
        public int ConvertirHoraAMinutos(string hora)
        {
            string[] partes = hora.Split(':');
            int horas = Convert.ToInt32(partes[0]);
            int minutos = Convert.ToInt32(partes[1]);
            return (horas * 60) + minutos;
        }

        // Compara la hora del registro contra la hora de entrada asignada al trabajador ese
        // día, y regresa el estatus según la diferencia en minutos:
        //   - 20 minutos o menos de diferencia: "Puntual"
        //   - entre 21 y 40 minutos: "Retardo"
        //   - más de 40 minutos: "Falta"
        public string ClasificarPuntualidad(int idTrabajador)
        {
            int idDia = ObtenerIdDia();
            string horaEntrada = ObtenerHoraEntrada(idTrabajador, idDia);

            int minutosEntrada = ConvertirHoraAMinutos(horaEntrada);
            int minutosRegistro = ConvertirHoraAMinutos(registro);
            int diferencia = minutosRegistro - minutosEntrada;

            string estatus;
            if (diferencia <= 20)
            {
                estatus = "Puntual";
            }
            else if (diferencia <= 40)
            {
                estatus = "Retardo";
            }
            else
            {
                estatus = "Falta";
            }

            return estatus;
        }

        // Inserta el nuevo registro de asistencia en tblasistencia y regresa el id generado.
        // Si estatusRegistro viene null (no era el primer registro del día), se guarda NULL.
        public int GuardarRegistro(int idTrabajador, string estatusRegistro)
        {
            int idGenerado = 0;
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "INSERT INTO tblAsistencia(fecha,registro,ruta_foto,id_trabajador,estatus_registro) " +
                                 "VALUES(@fecha,@registro,@rutaFoto,@idTrabajador,@estatusRegistro);SELECT LAST_INSERT_ID();";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@fecha", fecha);
                        comando.Parameters.AddWithValue("@registro", registro);
                        comando.Parameters.AddWithValue("@rutaFoto", rutaFoto);
                        comando.Parameters.AddWithValue("@idTrabajador", idTrabajador);

                        if (estatusRegistro == null)
                        {
                            comando.Parameters.AddWithValue("@estatusRegistro", DBNull.Value);
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@estatusRegistro", estatusRegistro);
                        }

                        idGenerado = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el registro de asistencia: " + ex.Message);
            }
            return idGenerado;
        }
    }
}
