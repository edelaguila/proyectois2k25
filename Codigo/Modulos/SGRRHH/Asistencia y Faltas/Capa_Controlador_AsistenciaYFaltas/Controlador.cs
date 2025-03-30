using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_AsistenciaYFaltas;
using System.Data;

namespace Capa_Controlador_AsistenciaYFaltas
{
    public class Controlador
    {
        private readonly Sentencia sn = new Sentencia();
        public void RegistrarAsistencia(string idEmpleado, DateTime fecha, TimeSpan horaEntrada, TimeSpan horaSalida)
        {
            sn.InsertarAsistencia(idEmpleado, fecha, horaEntrada, horaSalida);
        }

    }
}
