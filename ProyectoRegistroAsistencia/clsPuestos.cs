using MySqlConnector;
using System;
using System.Data;

namespace ProyectoRegistroAsistencia
{
    internal class clsPuestos
    {
        private int idPuesto;
        private string nombrePuesto;
        private string descripcion;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;

        public int IdPuesto { get => idPuesto; set => idPuesto = value; }
        public string NombrePuesto { get => nombrePuesto; set => nombrePuesto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        // Trae todos los puestos para llenar el DataGridView (filtrando por nombre si se busca algo)
        public DataTable Consultar(string filtro)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_puesto AS 'Id', " +
                                 "nombre_puesto AS 'Puesto', " +
                                 "descripcion AS 'Descripcion' " +
                                 "FROM tblpuestos " +
                                 "WHERE estatus = 'activo' AND nombre_puesto LIKE @filtro " +
                                 "ORDER BY nombre_puesto ASC;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@filtro", "%" + (filtro ?? "") + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar el catálogo de puestos: " + ex.Message);
            }
            return tabla;
        }

        // Revisa si ya existe un puesto con ese nombre (para no duplicar catálogos)
        private bool ExisteNombre(MySqlConnection conexion)
        {
            string sql = "SELECT COUNT(*) FROM tblpuestos WHERE estatus = 'activo' AND nombre_puesto = @nombre AND id_puesto <> @idPuesto;";
            using (var cmd = new MySqlCommand(sql, conexion))
            {
                cmd.Parameters.AddWithValue("@nombre", nombrePuesto);
                cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                int existentes = Convert.ToInt32(cmd.ExecuteScalar());
                return existentes > 0;
            }
        }

        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    if (ExisteNombre(conexion))
                    {
                        throw new Exception("Ya existe un puesto registrado con ese nombre.");
                    }

                    switch (tipoOperacion)
                    {
                        case 0: // Nuevo
                            string sqlInsertar = "INSERT INTO tblpuestos (nombre_puesto, descripcion) " +
                                                 "VALUES (@nombre, @descripcion);";
                            using (comando = new MySqlCommand(sqlInsertar, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", nombrePuesto);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);
                                comando.ExecuteNonQuery();
                            }
                            msg = "El puesto se guardó correctamente.";
                            break;

                        case 1: // Actualizar
                            string sqlActualizar = "UPDATE tblpuestos SET nombre_puesto = @nombre, descripcion = @descripcion " +
                                                   "WHERE id_puesto = @idPuesto;";
                            using (comando = new MySqlCommand(sqlActualizar, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", nombrePuesto);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);
                                comando.Parameters.AddWithValue("@idPuesto", idPuesto);
                                comando.ExecuteNonQuery();
                            }
                            msg = "El puesto se actualizó correctamente.";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar el puesto: " + ex.Message);
            }
            return msg;
        }

        // Baja lógica: el puesto no se borra de la base de datos, solo se marca
        // como inactivo. Así deja de aparecer en el catálogo pero se conserva su historial
        // (por ejemplo, los empleados que ya estuvieron asignados a él).
        public string DarDeBaja()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "UPDATE tblpuestos SET estatus = 'inactivo' WHERE id_puesto = @idPuesto;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idPuesto", idPuesto);
                        comando.ExecuteNonQuery();
                    }
                    msg = "El puesto se dio de baja correctamente.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo dar de baja el puesto: " + ex.Message);
            }
            return msg;
        }
    }
}
