using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRegistroAsistencia
{
    internal class clsIncidencias
    {
        //hacemos uso de un adaaptador para poder hacer uso de la base de datos

        private MySqlDataAdapter consulta;
        // usamos una tabla temporal
        private DataTable tabla;

        //metodo para cargar datos en el datagridview

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT \r\n                    T.clave_trabajador AS 'Clave trabajador',\r\n                    CONCAT(T.nombre, ' ', T.a_paterno, ' ', T.a_materno) AS 'Nombre completo',\r\n                    D.nombre_departamento AS 'Nombre departamento',\r\n                    I.tipo_incidencia AS 'Tipo de incidencia',\r\n                    I.justificacion AS 'Justificaciones',\r\n                    I.fecha AS Fecha\r\n                FROM tblincidencias I\r\n                INNER JOIN tbltrabajador T ON T.id_trabajador = I.id_trabajador\r\n                INNER JOIN tbldepartamento D ON D.id_departamento = T.id_departamento";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//liberar la consulta]
                }//liberar la conexión 
            }
            catch(Exception ex)
            {
                throw new Exception("Error en la conexión"+ex.Message);
            }
            return tabla;
        }

        public DataTable FiltrarBusqueda(DateTime? fecha, string claveTrabajador, int? tipoIncidencia) 
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"SELECT 
                                    T.clave_trabajador AS 'Clave trabajador',
                                    CONCAT(T.nombre, ' ', T.a_paterno, ' ', T.a_materno) AS 'Nombre completo',
                                    D.nombre_departamento AS 'Nombre departamento',
                                    I.tipo_incidencia AS 'Tipo de incidencia',
                                    I.justificacion AS 'Justificaciones',
                                    I.fecha AS Fecha
                                FROM tblincidencias I
                                INNER JOIN tbltrabajador T ON T.id_trabajador = I.id_trabajador
                                INNER JOIN tbldepartamento D ON D.id_departamento = T.id_departamento
                                WHERE 1=1";

                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexion;

                        // 1. Filtro por Fecha (si no es nula)
                        if (fecha.HasValue)
                        {
                            sql += " AND DATE(I.fecha) = @fecha";
                            cmd.Parameters.AddWithValue("@fecha", fecha.Value.ToString("yyyy-MM-dd"));
                        }

                        // 2. Filtro por Clave de Trabajador (si el texto no está vacío)
                        if (!string.IsNullOrWhiteSpace(claveTrabajador))
                        {
                            sql += " AND T.clave_trabajador = @clave";
                            cmd.Parameters.AddWithValue("@clave", claveTrabajador.Trim());
                        }

                        // 3. Filtro por Tipo de Incidencia (si se seleccionó una opción válida, ej. id > 0)
                        if (tipoIncidencia.HasValue && tipoIncidencia.Value > 0)
                        {
                            sql += " AND I.id_tipo_incidencia = @tipo";
                            cmd.Parameters.AddWithValue("@tipo", tipoIncidencia.Value);
                        }

                        cmd.CommandText = sql;

                        using (consulta = new MySqlDataAdapter(cmd))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar la búsqueda: " + ex.Message);
            }

            return tabla;
        }
        
        
    }
}
