using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo_CajaCC
{
    public class Conexion
    {
        //Clase de conexion --------------

        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No Conectó: " + ex.Message);
            }
            return conn;
        }

        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al desconectar: " + ex.Message);
            }
        }
        internal static OdbcConnection ObtenerConexion()
        {
            Conexion conexion = new Conexion();
            return conexion.conexion();
        }
    }
}