using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo
{
    public class Conexion
    {
        // Realizado por Ammy Patricia Catún López - 0901-21-4857
        public OdbcConnection conexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conexion.Open();
                return conexion; // Devuelve la conexión abierta
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No se pudo conectar: " + ex.Message);
                return null; // Devuelve null si no se puede conectar
            }
        }

        public void desconexion(OdbcConnection conexion)
        {
            if (conexion != null)
            {
                try
                {
                    conexion.Close();
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
                }
            }
        }
    }
}
