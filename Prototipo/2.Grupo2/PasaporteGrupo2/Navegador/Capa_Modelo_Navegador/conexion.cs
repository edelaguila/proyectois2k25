using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Navegador
{
    // Clase para gestionar la conexión a la base de datos utilizando ODBC.
    class conexion
    {
        // Método que prueba la conexión a la base de datos utilizando una DSN específica.
        public OdbcConnection ProbarConexion()
        {
            // Crear una nueva conexión utilizando la DSN especificada.
            OdbcConnection conn = new OdbcConnection("dsn=colchoneria"); 
            try
            {
                // Intentar abrir la conexión.
                conn.Open();
            }
            catch (OdbcException)
            {
                // Capturar cualquier excepción relacionada con ODBC y mostrar un mensaje en la consola.
                Console.WriteLine("No Conectó");
            }
            // Retornar el objeto de conexión (abierto si la conexión fue exitosa, o cerrado si ocurrió un error).
            return conn;
        }
    }
}
