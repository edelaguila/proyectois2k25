using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace CapaModelo_AndresVeron
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
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
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
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }

        }
    }
}
