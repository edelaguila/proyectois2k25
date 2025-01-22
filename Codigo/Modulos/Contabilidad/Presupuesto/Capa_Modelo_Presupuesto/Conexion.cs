using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Presupuesto
{
    class Conexion
    {
        public OdbcConnection NuevaConexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("dsn=colchoneria");
            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No Conectó ",ex);
            }
            return conn;
        }
    }
}

