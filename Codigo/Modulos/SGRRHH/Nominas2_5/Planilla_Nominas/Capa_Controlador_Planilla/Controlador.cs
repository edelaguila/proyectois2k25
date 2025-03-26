using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Planilla;
using System.Windows.Forms;

namespace Capa_Controlador_Planilla
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public bool funEjecutarCalculoPlanilla(int icorrelativoPlanilla, DateTime dfechaInicio, DateTime dfechaFinal, string smesTexto)
        {
            return sn.funInsertarPlanillaEncabezado(icorrelativoPlanilla,dfechaInicio, dfechaFinal,smesTexto);
        }

        public DataTable funObtenerEncabezado(string mesTexto)
        {
            DataTable tablaDeducciones = new DataTable();

            try
            {
                // Llama al método que obtiene el OdbcDataAdapter con los datos de la consulta
                OdbcDataAdapter adapter = sn.funObtenerPlanillaConDetalleCompleto(mesTexto);

                if (adapter != null)
                {
                    // Llenar el DataTable con los datos utilizando el OdbcDataAdapter
                    adapter.Fill(tablaDeducciones);
                }
                else
                {
                    MessageBox.Show("Error: No se pudieron obtener los datos de la planilla.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el encabezado: " + ex.Message);
            }

            return tablaDeducciones;
        }


        public DataTable funObtenerDedu()
        {
            OdbcDataAdapter adapter = sn.funObtenerDedu();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }

        public DataTable proCargarTotalMes()
        {
            OdbcDataAdapter adapter = sn.proCargarTotalMes();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }

        public DataTable funObtenerEncabezadoInicial()
        {
            OdbcDataAdapter adapter = sn.funObtenerEncabezadoInicial();
            DataTable tablaDeducciones = new DataTable();

            if (adapter != null)
            {
                adapter.Fill(tablaDeducciones); // Llenar el DataTable con el resultado del OdbcDataAdapter
            }
            return tablaDeducciones;
        }

        public DataTable funenviar(string stabla, string scampo1, string scampo2)
        {

            var dt1 = sn.funobtener1(stabla, scampo1, scampo2);

            return dt1;
        }

        public DataTable funenviar2(string stabla, string scampo1, string scampo2)
        {


            /**/
            var dt1 = sn.funobtener2(stabla, scampo1, scampo2);

            return dt1;
        }

        //public bool funAgregarPlanillaEncabezado(int icorrelativo, DateTime dfechaInicio, DateTime dfechaFinal, decimal detotalMes)
        //{
        //    Sentencias sentencias = new Sentencias();
        //    return sentencias.funInsertarPlanillaEncabezado(icorrelativo, dfechaInicio, dfechaFinal, detotalMes);
        //}

        public void funcActualizarEncabezado(int iidSeleccionado, int icorrelativo, DateTime dfechaInicio, DateTime dfechaFinal, string smesTexto)
        {
            try
            {
                sn.funcActualizarEncabezado(iidSeleccionado, icorrelativo, dfechaInicio,dfechaFinal, smesTexto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarLogicaDeduPerp: " + ex.Message);
            }
        }

        public void funcEliminarEncabezado(int iidSeleccionado)
        {
            try
            {
                sn.funcEliminarEncabezado(iidSeleccionado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarLogicaDeduPerp: " + ex.Message);
            }
        }

        public void funcActualizarDetalle(int iidSeleccionado2, int ifkIdRegistroPlanillaEncabezado, int ifkClaveEmpleado)
        {
            try
            {
                sn.funcActualizarDetalle(iidSeleccionado2, ifkIdRegistroPlanillaEncabezado, ifkClaveEmpleado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarLogicaDeduPerp: " + ex.Message);
            }
        }

        public void funcEliminarDetalle(int iidSeleccionado2)
        {
            try
            {
                sn.funcEliminarDetalle(iidSeleccionado2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarLogicaDeduPerp: " + ex.Message);
            }
        }

        public bool funIngresarDedu(int iempleado,int idedu, string mes)
        {
            return sn.funInsertarDeduccionPercepcion(iempleado, idedu, mes);
        }


        public void funcActualizarLogicaDeduPerp(int iidSeleccionado, int iempleado, int idedu, string mes)
        {
            try
            {
                sn.funcActualizarLogicaDeduPerp(iidSeleccionado,  iempleado,  idedu,  mes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcActualizarLogicaDeduPerp: " + ex.Message);
            }
        }


        public void funcEliminarLogicaDeduPerp(int iidSeleccionado2)
        {
            try
            {
                sn.funcEliminarLogicaDeduPerp(iidSeleccionado2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en funcEliminarLogicaDeduPerp: " + ex.Message);
            }
        }



    }

}
