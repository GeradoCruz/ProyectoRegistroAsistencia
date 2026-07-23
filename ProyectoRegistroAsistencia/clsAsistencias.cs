using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRegistroAsistencia
{
    internal class clsAsistencias
    {
        private DataTable tabla;
        private MySqlDataAdapter consulta;
        private DataTable clave;
        private DataTable fecha;
        private MySqlCommand comando;
        public DataTable CargaDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT T.clave_trabajador AS Clave_Trabajador, " +
                        "CONCAT(T.nombre,'',  T.a_paterno,' ', T.a_materno) AS Trabajador," +
                        "A.registro  AS Registro," +
                        "A.fecha AS Fecha " +
                        "FROM tblasistencia A " +
                        "INNER JOIN tbltrabajador T ON A.id_trabajador = T.id_departamento;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla" + ex.Message);
            }
            return tabla;
        }


        public DataTable BusquedaFecha(DateTime fecha, string apellido)
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT T.clave_trabajador AS Clave_Trabajador,"+
                                 "CONCAT(T.nombre, ' ', T.a_paterno, ' ', T.a_materno) AS Trabajador, " +
                                 "A.registro AS Registro, " +
                                 "A.fecha AS Fecha " +
                                 "FROM tblasistencia A " +
                                 "INNER JOIN tbltrabajador T ON A.id_trabajador = T.id_trabajador " +
                                 "WHERE DATE(A.fecha) = @fecha ";

                    if (!string.IsNullOrEmpty(apellido))
                    {
                        sql += "AND T.a_paterno LIKE @apellido ";
                    }

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@fecha", fecha.Date);

                        if (!string.IsNullOrEmpty(apellido))
                        {
                            consultar.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
                        }

                        using (consulta = new MySqlDataAdapter (consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la asistencia: " + ex.Message);
            }

            return tabla;

        }



    }
}
