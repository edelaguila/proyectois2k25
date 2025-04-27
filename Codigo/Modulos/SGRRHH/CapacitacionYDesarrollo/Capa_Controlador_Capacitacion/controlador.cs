using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Capa_Modelo_Capacitacion;

namespace Capa_Controlador_Capacitacion
{
    public class controlador
    {
        sentencias sn = new sentencias();

        public List<KeyValuePair<int, string>> CargarNiveles()
        {
            return sn.ObtenerNiveles();
        }

        public List<KeyValuePair<int, string>> CargarEmpleados()
        {
            return sn.ObtenerEmpleados();
        }

        public List<KeyValuePair<int, string>> CargarCapacitaciones()
        {
            return sn.ObtenerCapacitaciones();
        }

        public int insertarNota(int fkEmpleado, int fkCapacitacion, int fknivel, decimal puntaje, string fecha)
        {
            return sn.InsertarNota(fkEmpleado, fkCapacitacion, fknivel, puntaje, fecha);
        }


        public int obtenerIdEmpleado(string nombreEmpleado)
        {
            return sn.ObtenerIdEmpleado(nombreEmpleado);
        }

        public int obtenerIdCapacitacion(string nombreCapacitacion)
        {
            return sn.ObtenerIdCapacitacion(nombreCapacitacion);
        }

        public DataTable mostrarNotas()
        {
            return sn.ObtenerNotas();
        }

        public int obtenerSiguienteNota()
        {
            return sn.ObtenerSiguienteIdNota();
        }

        public bool EditarNota(int idNota, int fkEmpleado, int fkCapacitacion, string nivel, decimal puntaje, string fecha)
        {
            return sn.ActualizarNota(idNota, fkEmpleado, fkCapacitacion, nivel, puntaje, fecha);
        }


    }
}
