using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ProyectoRegistroAsistencia
{
    internal class clsHorarioSemanal
    {
        private int id_departamento;

        private MySqlDataAdapter consulta;
        private DataTable tabla;

        private string claveTrabajador;
        private string nombreTrabajador;
        private string departamento;
        private string puesto;
        private string semestre;

        //Nuevas varibables para obtener el horario
        private int idTrabajador;
        private int idSemestre;
        private int idDia;
        private string horaEntrada;
        private string horaSalida;

        public string ClaveTrabajador { get => claveTrabajador; set => claveTrabajador = value; }
        public string NombreTrabajador { get => nombreTrabajador; set => nombreTrabajador = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Semestre { get => semestre; set => semestre = value; }

        //Propiedades para guardar el horario
        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public int IdSemestre { get => idSemestre; set => idSemestre = value; }
        public int IdDia { get => idDia; set => idDia = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }


        public DataTable cargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionDB = new clsConexion();
                using (var conexion = conexionDB.AbrirConexion())
                {
                    string sql = "SELECT T.clave_trabajador AS 'Clave Trabajador', " +
                                    "CONCAT(T.nombre, ' ', T.a_paterno, ' ', T.a_materno) AS 'Nombre Completo', " +
                                    "Dd.nombre_dia AS Dia, " +
                                    "H.hora_entrada AS 'Hora Entrada', " +
                                    "H.hora_salida AS 'Hora Salida', " +
                                    "H.id_trabajador, " +
                                    "H.id_semestre, " +
                                    "S.semestre AS Semestre " +
                                    "FROM tblhorario_trabajo H " +
                                    "INNER JOIN tbltrabajador T ON H.id_trabajador = T.id_trabajador " +
                                    "INNER JOIN tblsemestres S ON H.id_semestre = S.id_semestre " +
                                    "INNER JOIN tbldias Dd ON H.id_dia = Dd.id_dia;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
            return tabla;
        }
        public DataTable ObtenerDepartamento()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {

                    string sql = "SELECT id_departamento,nombre_departamento FROM  tbldepartamento;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de carreras: " + ex.Message);
            }
            return tabla;
        }
        public DataTable consultar(int id_departamento)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT T.clave_trabajador AS 'Clave Trabajador', " +
                                  "CONCAT(T.nombre, ' ', T.a_paterno, ' ', T.a_materno) AS 'Nombre Completo', " +
                                  "D.nombre_departamento AS Departamento, " +
                                  "Dd.nombre_dia AS Dia, " +
                                  "H.hora_entrada AS 'Hora Entrada', " +
                                  "H.hora_salida AS 'Hora Salida', " +
                                  "H.id_trabajador, " +
                                  "H.id_semestre, " +
                                  "S.semestre AS Semestre " +
                                  "FROM tblhorario_trabajo H " +
                                  "INNER JOIN tbltrabajador T ON H.id_trabajador = T.id_trabajador " +
                                  "INNER JOIN tbldias Dd ON H.id_dia = Dd.id_dia " +
                                  "INNER JOIN tblsemestres S ON H.id_semestre = S.id_semestre " +
                                  "INNER JOIN tbldepartamento D ON T.id_departamento = D.id_departamento " +
                                  "WHERE T.id_departamento = @id_departamento;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@id_departamento", id_departamento);
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta" + ex.Message);
            }
            return tabla;
        }
        public void buscarTrabajador()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT T.id_trabajador, T.nombre AS Nombre, " +
                                 "D.nombre_departamento AS Departamento, " +
                                 "P.nombre_puesto AS Puesto, " +
                                 "S.id_semestre, S.semestre AS Semestre " +
                                 "FROM tbltrabajador T " +
                                 "INNER JOIN tbldepartamento D ON T.id_departamento = D.id_departamento " +
                                 "INNER JOIN tblpuestos P ON T.id_puesto = P.id_puesto " +
                                 "LEFT JOIN tblhorario_trabajo H ON T.id_trabajador = H.id_trabajador " +
                                 "LEFT JOIN tblsemestres S ON H.id_semestre = S.id_semestre " +
                                 "WHERE T.clave_trabajador = @clave;";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@clave", claveTrabajador);


                        using (MySqlDataReader datos = comando.ExecuteReader())
                        {
                            if (datos.Read())
                            {
                                idTrabajador = Convert.ToInt32(datos["id_trabajador"]);
                                idSemestre = datos["id_semestre"]== DBNull.Value ? 0 : Convert.ToInt32(datos["id_semestre"]);
                                nombreTrabajador = datos["Nombre"].ToString();
                                Departamento = datos["Departamento"].ToString();
                                puesto = datos["Puesto"].ToString();
                                semestre = datos["Semestre"].ToString();
                            }
                            else
                            {
                                throw new Exception("No se encontró ningún trabajador con esa clave.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string GuardarHorario()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    bool existe = TieneHorarioAsignado(IdTrabajador, IdDia, IdSemestre);
                    string sql;
                    if (existe)
                    {
                         sql = "UPDATE tblhorario_trabajo SET " +
                               "hora_entrada = @entrada, hora_salida = @salida, id_semestre = @semestre " +
                                  "WHERE id_trabajador = @trabajador AND id_dia = @dia;";
                    }
                    else
                    {
                         sql = "INSERT INTO tblhorario_trabajo " +
                                     "(hora_entrada, hora_salida, id_dia, id_semestre, id_trabajador) " +
                                     "VALUES(@entrada, @salida, @dia, @semestre, @trabajador);";
                    }

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@entrada", horaEntrada);
                        comando.Parameters.AddWithValue("@salida", horaSalida);
                        comando.Parameters.AddWithValue("@dia", idDia);
                        comando.Parameters.AddWithValue("@semestre", idSemestre);
                        comando.Parameters.AddWithValue("@trabajador", idTrabajador);

                        comando.ExecuteNonQuery();
                    }
                    msg = "Horario guardado correctamente";

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el Horario" + ex.Message);
            }
            return msg;
        }
        public bool TieneHorarioAsignado(int idTrabajadorConsulta, int idDiaConsulta, int idSemestreConsulta)
        {
            bool existe = false;
            try
            {

                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT COUNT(*) FROM tblhorario_trabajo " +
                                 "WHERE id_trabajador = @trabajador AND id_dia = @dia AND id_semestre = @semestre;";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@trabajador", idTrabajadorConsulta);
                        comando.Parameters.AddWithValue("@dia", idDiaConsulta);
                        comando.Parameters.AddWithValue("@semestre", idSemestreConsulta);

                        int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                        existe = cantidad > 0;

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar el horario: " + ex.Message);
            }
            return existe;
        }
        public DataTable diasFaltantes(int idTrabajador)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using(var conexion= conexionBD.AbrirConexion())
                {
                    string sql = "SELECT D.id_dia, D.nombre_dia " +
                                 "FROM tbldias D " +
                                 "WHERE D.id_dia BETWEEN 1 AND 5 " +
                                 "AND D.id_dia NOT IN ( " +
                                 "    SELECT id_dia FROM tblhorario_trabajo WHERE id_trabajador = @trabajador " +
                                 ");"; 
                    using (MySqlCommand comando = new MySqlCommand(sql,conexion))
                    {
                        comando.Parameters.AddWithValue("@trabajador", idTrabajador);
                        using (consulta = new MySqlDataAdapter(comando))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
                            
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los dias faltantes " + ex.Message);
            }
            return tabla;
        }
        public DataTable ObtenerSemestres()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_semestre, semestre FROM tblsemestres;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de semestres: " + ex.Message);
            }
            return tabla;
        }

    }   
}
