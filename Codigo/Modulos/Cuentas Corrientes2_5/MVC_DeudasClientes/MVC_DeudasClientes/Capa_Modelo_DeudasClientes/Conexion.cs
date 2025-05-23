using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo_DeudasClientes
{
    public class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión exitosa.");
            }
            catch (OdbcException ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conexion;
        }

        public void desconexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show($"Error al cerrar la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
