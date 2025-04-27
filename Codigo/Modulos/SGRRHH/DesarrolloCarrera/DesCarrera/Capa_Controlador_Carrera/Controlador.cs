using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Carrera;

namespace Capa_Controlador_Carrera
{
    public class Controlador
    {
        /*********************Ismar Leonel Cortez Sanchez -0901-21-560************/
        /***********************Combo box inteligente*****************************/
        Sentencias sn;

        public Controlador(string idUsuario)
        {
            sn = new Sentencias(idUsuario);
        }
        public string[] items(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.funLlenarCmb2(tabla, campo1, campo2);
            /*Este arreglo lo obtiene y retorna de la clase senencias del modelo*/
            return Items;

            /*Aqui viene a parar lo de sentencias*/


        }

        public DataTable enviar(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.obtener2(tabla, campo1, campo2);

            return dt1;
        }
        /**************************************************************************/

        public DataRow ObtenerPuestoYSalario(string idEmpleado)
        {
            return sn.ObtenerDatosEmpleado(idEmpleado);
        }

        public DataTable funcConsultarPromociones()
        {
            try
            {
                OdbcDataAdapter dt = sn.funcConsultaPromociones();
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

        public bool funcInsertarPromocion(int empleado, DateTime fecha, string puestoactual, string salarioactual, string puestonuevo, string salarionuevo, string motivo)
        {
            try
            {
                // Validar que los puestos sean cadenas no vacías
                if (string.IsNullOrEmpty(puestoactual) || string.IsNullOrEmpty(puestonuevo) || string.IsNullOrEmpty(motivo))
                {
                    throw new ArgumentException("Los campos puesto actual, nuevo puesto y motivo no pueden estar vacíos.");
                }

                // Verificar si los salarios son válidos
                //if (salarioactual < 0 || salarionuevo < 0)
                //{
                //    throw new ArgumentException("Los salarios no pueden ser negativos.");
                //}

                // Llamada al modelo para insertar la promoción
                sn.funcInsertarPromocion(empleado, fecha, puestoactual, salarioactual, puestonuevo, salarionuevo, motivo);
                return true; // Si llegamos aquí, la inserción fue exitosa
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en insertar promociones: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                throw new Exception($"Error al insertar el registro: {ex.Message}");
                return false; // En caso de error
            }
        }


    }
    }
