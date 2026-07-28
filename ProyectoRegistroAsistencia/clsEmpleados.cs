using MySqlConnector;
using System.Data;
using System.Runtime.InteropServices.Marshalling;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProyectoRegistroAsistencia
{
    internal class clsEmpleados
    {
        private string filtro;
        private string claveTrabajador;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string departamento;
        private string puesto;
        private DateTime fechaIngreso;
        private int numeroCalle;
        private int codigoPostal;
        private string municipio;
        private string localidad;
        private string telefono;
        private string correoElectronico;
        private char genero;

        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;
        public string ClaveTrabajador { get => claveTrabajador; set => claveTrabajador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public int NumeroCalle { get => numeroCalle; set => numeroCalle = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public char Genero { get => genero; set => genero = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Localidad { get => localidad; set => localidad = value; }

        public DataTable Consultar()
        {
            tabla= new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT T.clave_trabajador AS 'Clave Trabajador', " +
                                "T.nombre AS Nombre, " +
                                "T.a_paterno AS 'Apellido Paterno', " +
                                "T.a_materno AS 'Apellido Materno', " +
                                "T.telefono AS Telefono, " +
                                "T.email AS 'Correo Institucional', " +
                                "T.sexo AS Genero, " +
                                "T.municipio AS Municipio, " +
                                "T.localidad AS Localidad, " +
                                "T.cp AS 'Codigo Postal', " +
                                "T.numero_calle AS 'Numero Calle', " +
                                "T.id_departamento, " +
                                "T.id_puesto, " +
                                "T.estatus AS Estatus, " +
                                "D.nombre_departamento AS Departamento, " +
                                "P.nombre_puesto AS Puesto " +
                                "FROM tbltrabajador T " +
                                "INNER JOIN tbldepartamento D ON T.id_departamento = D.id_departamento " +
                                "INNER JOIN tblpuestos P ON T.id_puesto = P.id_Puesto " +
                                "WHERE T.estatus = 'activo' "+
                                "ORDER BY clave_trabajador ASC ";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@Clave Trabajador", "%" + claveTrabajador + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        { 
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion:" + ex.Message);
            }
            return tabla;
        }
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            switch (tipoOperacion)
                            {
                                case 0:
                                    string sqlInsertar = "INSERT INTO tbltrabajador (clave_trabajador, nombre, a_paterno, a_materno, telefono, email, sexo, fecha_ingreso, municipio, localidad, cp, numero_calle, id_departamento, id_puesto) " +
                                        "VALUES (@'Clave Trabajador', @nombre, @'Apellido Paterno', @'Apellido Materno', @telefono, @'Correo Electronico', @genero, CURDATE(), @municipio, @localidad, @'Codigo Postal', @'Numero Calle', @Departamento, @Puesto)";
                                    using (comando = new MySqlCommand(sqlInsertar, conexion, transaccion))
                                    {
                                            comando.Parameters.AddWithValue("@'Clave Trabajador'", claveTrabajador);
                                            comando.Parameters.AddWithValue("@nombre", nombre);
                                            comando.Parameters.AddWithValue("@'Apellido Paterno'", apellidoPaterno);
                                            comando.Parameters.AddWithValue("@'Apellido Materno'", apellidoMaterno);
                                            comando.Parameters.AddWithValue("@telefono", telefono);
                                            comando.Parameters.AddWithValue("@'Correo Electronico'", correoElectronico);
                                            comando.Parameters.AddWithValue("@genero", genero);
                                            comando.Parameters.AddWithValue("@'fecha Ingreso'", fechaIngreso);
                                            comando.Parameters.AddWithValue("@municipio", municipio);
                                            comando.Parameters.AddWithValue("@localidad", localidad);
                                            comando.Parameters.AddWithValue("@'Codigo Postal'", codigoPostal);
                                            comando.Parameters.AddWithValue("@'Numero Calle'", numeroCalle);
                                            comando.Parameters.AddWithValue("@Departamento", departamento);
                                            comando.Parameters.AddWithValue("@Puesto", puesto);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg= "Registro guardado correctamente";
                                    break;
                                case 1:
                                    string sqlActualizar = "UPDATE tbltrabajador SET nombre=@nombre, a_paterno=@'Apellido Paterno', a_materno=@'Apellido Materno', telefono=@Telefono, email=@'Correo Electronico', sexo=@genero, municipio=@municipio, localidad=@localidad, cp=@'Codigo Postal', numero_calle=@'Numero Calle', id_departamento=@Departamento, id_puesto=@Puesto WHERE clave_trabajador=@'Clave Trabajador'";
                                    using (comando = new MySqlCommand(sqlActualizar, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@'Clave Trabajador'", claveTrabajador);
                                        comando.Parameters.AddWithValue("@nombre", nombre);
                                        comando.Parameters.AddWithValue("@'Apellido Paterno'", apellidoPaterno);
                                        comando.Parameters.AddWithValue("@'Apellido Materno'", apellidoMaterno);
                                        comando.Parameters.AddWithValue("@telefono", telefono);
                                        comando.Parameters.AddWithValue("@'Correo Electronico'", correoElectronico);
                                        comando.Parameters.AddWithValue("@genero", genero);
                                        comando.Parameters.AddWithValue("@municipio", municipio);
                                        comando.Parameters.AddWithValue("@localidad", localidad);
                                        comando.Parameters.AddWithValue("@'Codigo Postal'", codigoPostal);
                                        comando.Parameters.AddWithValue("@'Numero Calle'", numeroCalle);
                                        comando.Parameters.AddWithValue("@Departamento", departamento);
                                        comando.Parameters.AddWithValue("@Puesto", puesto);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "Registro actualizado correctamente";
                                    break;


                            }
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error en la operacion. Se cancelaron los cambios:" + ex.Message);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion:" + ex.Message);
            }
            return msg;
        }
        public DataTable ObtenerDepartamentos()
        {
            tabla = new DataTable();
            try 
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion=conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_departamento, nombre_departamento FROM tbldepartamento;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }    
            }
            catch (Exception ex)
            {
                throw new Exception("Error vuelva a intertarlo" + ex.Message);
            }
            return tabla;
        }
        public DataTable ObtenerPuestos()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_puesto, nombre_puesto FROM tblpuestos;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error vuelva a intertarlo" + ex.Message);
            }
            return tabla;
        }
        public string DarDeBaja()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                        try
                        {
                            string sqlEmpleados = "UPDATE tbltrabajador SET estatus = 'inactivo' WHERE clave_trabajador = @claveTrabajador;";
                               
                            using (comando = new MySqlCommand(sqlEmpleados, conexion))
                            {
                                comando.Parameters.AddWithValue("@claveTrabajador", claveTrabajador);
                                comando.ExecuteNonQuery();
                            }
                            
                            msg = "Empleado dado de baja correctamente";
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error en la operacion. Se cancelaron los cambios:" + ex.Message);
                        }
                    }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion:" + ex.Message);
            }
            return msg;
        }
        public DataTable BuscarEmpleado(string filtro)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT T.clave_trabajador AS 'Clave Trabajador', " +
                                "T.nombre AS Nombre, " +
                                "T.a_paterno AS 'Apellido Paterno', " +
                                "T.a_materno AS 'Apellido Materno', " +
                                "T.telefono AS Telefono, " +
                                "T.email AS 'Correo Institucional', " +
                                "T.sexo AS Genero, " +
                                "T.municipio AS Municipio, " +
                                "T.localidad AS Localidad, " +
                                "T.cp AS 'Codigo Postal', " +
                                "T.numero_calle AS 'Numero Calle', " +
                                "T.id_departamento, " +
                                "T.id_puesto, " +
                                "T.estatus AS Estatus, " +
                                "D.nombre_departamento AS Departamento, " +
                                "P.nombre_puesto AS Puesto " +
                                "FROM tbltrabajador T " +
                                "INNER JOIN tbldepartamento D ON T.id_departamento = D.id_departamento " +
                                "INNER JOIN tblpuestos P ON T.id_puesto = P.id_Puesto " +
                                "WHERE clave_trabajador LIKE @filtro " +
                                "OR nombre LIKE @filtro "+
                                "OR a_paterno LIKE @filtro "+
                                "OR a_materno LIKE @filtro ";
                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                        using (consulta = new MySqlDataAdapter(comando))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el empleado: " + ex.Message);
            }
            return tabla;
        }
    }
}
