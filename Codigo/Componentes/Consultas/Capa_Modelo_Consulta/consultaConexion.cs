using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

//Capa modelo desarrollada por Carlos González 9959-20-6164

namespace Capa_Modelo_Consulta
{
    public class consultaConexion
    {
        public OdbcConnection connection()
        {
            //Se requiere colocar el nombre del DSN
            //Escoger un DSN para todos, hablar en clase
            OdbcConnection conn = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conn.Open();
            }
            catch (OdbcException e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }


        public void disconnect(OdbcConnection conn)
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
