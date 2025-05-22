using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Faltas;
using System.Data;

namespace Capa_Controlador_Faltas
{
    public class Controlador
    {
        private readonly Sentencia sn = new Sentencia();

        // Método para obtener todos los empleados
        public DataTable ObtenerEmpleados()
        {
            return sn.ObtenerEmpleados();
        }

        // Método para obtener todas las faltas en la tabla deducciones
        public DataTable ObtenerTodasLasFaltas()
        {
            return sn.ObtenerTodasLasFaltas();
        }

        // Método para calcular el descuento por faltas de un empleado
        public decimal CalcularDescuentoPorFaltas(int idEmpleado, string mes)
        {
            return sn.CalcularDescuentoPorFaltas(idEmpleado, mes);
        }

        // Método para guardar o actualizar la deducción por faltas
        public void GuardarDeduccionPorFaltas(int idEmpleado, string mes)
        {
            sn.GuardarDeduccionPorFaltas(idEmpleado, mes);
        }
        // Método para obtener los meses en los que hay faltas registradas
        public DataTable ObtenerMesesConFaltas()
        {
            return sn.ObtenerMesesConFaltas();
        }

    }
}