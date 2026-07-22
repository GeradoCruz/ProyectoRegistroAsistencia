using MySqlConnector;
using System;
using System.Data;

namespace ProyectoRegistroAsistencia
{
    internal class clsConexion
    {
        private string host = "189.240.192.140";
        private string bd = "equipo1_staff_asistence";
        private string user = "usuario1GB";
        private string password = "equipo1gb";
        private string port = "3306";
        
        
        //datos del servidor local 
        private string hostLocal = "localhost";
        private string bdLocal = "equipo1_staff_asistence";
        private string usuarioLocal = "root";
        private string passwordLocal = "root";
        private string puertoLocal = "3306";

        private string CadenaRemota => $"server={host}; database={bd}; user={user}; password={password}; port={port}; CharSet=utf8mb4;";
        private string CadenaLocal => $"server={hostLocal}; database={bdLocal}; user={usuarioLocal}; password={passwordLocal}; port={puertoLocal}; CharSet=utf8mb4;";

        public MySqlConnection AbrirConexion()
        {
            try
            {

                var conexion = new MySqlConnection(CadenaRemota);
                conexion.Open();
                return conexion;
            }
            catch
            {
                try
                {
                    //si el remoto falla, intenta con la base local de respaldo
                    var conexionLocal = new MySqlConnection(CadenaLocal);
                    conexionLocal.Open();
                    return conexionLocal;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al intentar conectarse a la base de datos remota y local: " + ex.Message, ex);
                }
            }
        }

        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar cerrar la conexión a la base de datos :" + ex.Message, ex);
            }
        }
    }
}
