using MySqlConnector;
using System;
using System.Data;

namespace ProyectoRegistroAsistencia
{
    internal class clsDepartamentos
    {
        private int idDepartamento;
        private string nombreDepartamento;
        private string descripcion;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;

        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        // Trae todos los departamentos para llenar el DataGridView
        public DataTable Consultar(string filtro)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_departamento AS 'Id', " +
                                 "nombre_departamento AS 'Departamento', " +
                                 "descripcion AS 'Descripcion' " +
                                 "FROM tbldepartamento " +
                                 "WHERE estatus = 'activo' AND nombre_departamento LIKE @filtro " +
                                 "ORDER BY nombre_departamento ASC;";
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
                throw new Exception("No se pudo cargar el catálogo de departamentos: " + ex.Message);
            }
            return tabla;
        }

        // Revisa si ya existe un departamento con ese nombre (para no duplicar catálogos)
        private bool ExisteNombre(MySqlConnection conexion)
        {
            string sql = "SELECT COUNT(*) FROM tbldepartamento WHERE estatus = 'activo' AND nombre_departamento = @nombre AND id_departamento <> @idDepartamento;";
            using (var cmd = new MySqlCommand(sql, conexion))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreDepartamento);
                cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
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
                        throw new Exception("Ya existe un departamento registrado con ese nombre.");
                    }

                    switch (tipoOperacion)
                    {
                        case 0: // Nuevo
                            string sqlInsertar = "INSERT INTO tbldepartamento (nombre_departamento, descripcion) " +
                                                 "VALUES (@nombre, @descripcion);";
                            using (comando = new MySqlCommand(sqlInsertar, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", nombreDepartamento);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);
                                comando.ExecuteNonQuery();
                            }
                            msg = "El departamento se guardó correctamente.";
                            break;

                        case 1: // Actualizar
                            string sqlActualizar = "UPDATE tbldepartamento SET nombre_departamento = @nombre, descripcion = @descripcion " +
                                                   "WHERE id_departamento = @idDepartamento;";
                            using (comando = new MySqlCommand(sqlActualizar, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", nombreDepartamento);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);
                                comando.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                                comando.ExecuteNonQuery();
                            }
                            msg = "El departamento se actualizó correctamente.";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar el departamento: " + ex.Message);
            }
            return msg;
        }

        // Baja lógica: el departamento no se borra de la base de datos, solo se marca
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
                    string sql = "UPDATE tbldepartamento SET estatus = 'inactivo' WHERE id_departamento = @idDepartamento;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                        comando.ExecuteNonQuery();
                    }
                    msg = "El departamento se dio de baja correctamente.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo dar de baja el departamento: " + ex.Message);
            }
            return msg;
        }
    }
}
