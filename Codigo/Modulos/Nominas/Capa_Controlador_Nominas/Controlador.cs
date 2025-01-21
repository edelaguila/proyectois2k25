using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Nominas;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Reflection;

namespace Capa_Controlador_Nominas
{
    public class Controlador
    {
        Sentencias sn = new Sentencias(); //Conexion con capa modelo


        /********0901-21-13093 - Brandon Alejandro Boch Lopez*********************/

        /*************************************************************************/


        /********0901-21-1278 - Gabriela Alejandra Suc Gomez**********************/

        /*************************************************************************/


        /********0901-21-4866 - Kateryn Johana De León Hernández******************/

        /*************************************************************************/


        /********0901-21-843 - Marco Alejandro Monroy Rousselin*******************/

        /*************************************************************************/


        /********0901-21-581 - Fernando José García de León***********************/
        public DataTable funcConsultaLogicaDeduPerp()
        {
            try
            {
                OdbcDataAdapter dt = sn.funcConsultaDeduPerp();
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcConsultaLogicaDeduPerp: " + ex.Message);
                return null;
            }
        }

        public bool funcInsertarLogicaDeduPerp(string clase, string concepto, string tipo, string aplicacion, int excepcion, float monto)
        {
            try
            {
                // Validaciones básicas antes de insertar
                if (string.IsNullOrEmpty(clase) || string.IsNullOrEmpty(concepto) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(aplicacion))
                {
                    throw new ArgumentException("Los campos clase, concepto, tipo y aplicación son obligatorios.");
                }

                if (monto < 0)
                {
                    throw new ArgumentException("El monto no puede ser negativo.");
                }

                // Intenta realizar la inserción
                sn.funcInsertarDeduPerp(clase, concepto, tipo, aplicacion, excepcion, monto);
                return true; // Si llegamos aquí, la inserción fue exitosa
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en funcInsertarLogicaDeduPerp: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");

                // Relanzar la excepción para que la capa de presentación pueda manejarla
                throw new Exception($"Error al insertar el registro: {ex.Message}");

                return false; // En caso de error
            }
        }

        public void funcActualizarLogicaDeduPerp(int id, string clase, string concepto, string tipo, string aplicacion, int excepcion, float monto)
        {
            try
            {
                sn.funcActualizarDeduPerp(id, clase, concepto, tipo, aplicacion, excepcion, monto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarLogicaDeduPerp: " + ex.Message);
            }
        }

        public void funcEliminarLogicaDeduPerp(int id)
        {
            try
            {
                sn.funcEliminarDeduPerp(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarLogicaDeduPerp: " + ex.Message);
            }
        }


        /*************************************************************************/


        /********0901-21-506 - Ismar Leonel Cortez Sanchez************************/
        // Método que obtiene el logo en formato Image
        //public Image ObtenerLogoEmpresa(int empresaId)
        //{
        //    byte[] imageBytes = modelo.ObtenerLogoEmpresa(empresaId); // Este método retorna un arreglo de bytes

        //    if (imageBytes != null)
        //    {
        //        using (MemoryStream ms = new MemoryStream(imageBytes))
        //        {
        //            return Image.FromStream(ms); // Esto convierte los bytes a una imagen usando System.Drawing.Image
        //        }
        //    }
        //    return null;
        //}
        /*************************************************************************/












    }
}
