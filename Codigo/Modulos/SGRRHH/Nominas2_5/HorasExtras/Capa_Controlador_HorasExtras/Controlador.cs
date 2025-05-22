using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_HorasExtras;

namespace Capa_Controlador_HorasExtras
{
    public class Controlador
    {
 
            //*******************************Kateryn De Leon**************************************
        private readonly Sentencia sn = new Sentencia();

        // Obtener lista de empleados
        public List<string> funObtenerEmpleados()
        {
            return sn.funObtenerEmpleados();
        }

        // Obtener meses de un empleado específico
        public List<string> funObtenerMesesPorEmpleado(string sNombreEmpleado)
        {
            return sn.funObtenerMesesPorEmpleado(sNombreEmpleado);
        }

        // Obtener total de horas extras de un empleado en un mes específico
        public decimal funObtenerHorasExtras(string sNombreEmpleado, string sMes)
        {
            return sn.funCalcularHorasExtrasEmpleadoMes(sNombreEmpleado, sMes);
        }


    }
    //************************************************************************************
}
