using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Compras
{
    public class Conexion
    {


        public OdbcConnection conexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conexion.Open();
            }
            //catch (OdbcException)
            //{
            //    Console.WriteLine("No Conectó");
            //}
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }

            return conexion;
        }
    


    public void desconexion(OdbcConnection conexion)
    {
        try
        {
            conexion.Close();
        }
        catch (OdbcException)
        {
            Console.WriteLine("No Conectó");
        }
    }
}


}
