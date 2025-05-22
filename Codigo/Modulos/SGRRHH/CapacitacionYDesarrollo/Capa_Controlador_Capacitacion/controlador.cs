using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Capa_Modelo_Capacitacion;

namespace Capa_Controlador_Capacitacion
{
    public class ParametrosDTO
    {
        public decimal LimiteVerde { get; set; }
        public decimal LimiteAmarillo { get; set; }
    }



    public class controlador
    {
        sentencias sn = new sentencias();

        public List<KeyValuePair<int, string>> CargarNiveles()
        {
            return sn.ObtenerNiveles();
        }

        public List<KeyValuePair<int, string>> CargarEmpleados(int idDepartamento)
        {
            return sn.ObtenerEmpleadosPorDepartamento(idDepartamento);
        }

        public List<KeyValuePair<int, string>> CargarCapacitaciones()
        {
            return sn.ObtenerCapacitaciones();
        }

        public List<KeyValuePair<int, string>> CargarDepartamentos()
        {
            return sn.ObtenerDepartamentos();
        }

        public int insertarNota(int fkEmpleado, int fkCapacitacion, int fknivel, decimal puntaje, string fecha)
        {
            return sn.InsertarNota(fkEmpleado, fkCapacitacion, fknivel, puntaje, fecha);
        }

        public void InsertarCierre(int idDepartamento, int idCapacitacion, decimal puntuacion, decimal porcentajeAsistencia, DateTime fecha)
        {
             sn.InsertarCierre(idDepartamento, idCapacitacion, puntuacion, porcentajeAsistencia, fecha);
        }

        public DataTable ObtenerCierres()
        {
            return sn.ObtenerCierres();
        }



        public int obtenerIdEmpleado(string nombreEmpleado)
        {
            return sn.ObtenerIdEmpleado(nombreEmpleado);
        }

        public int obtenerIdDepartamento(int idDepartamento)
        {
            return sn.ObtenerIdDepartamentoPorCapacitacion(idDepartamento);
        }

        public string ObtenerDepartamentoNombre(int idCapacitacion)
        {
            return sn.ObtenerNombreDepartamentoPorCapacitacion(idCapacitacion);
        }

        public int obtenerIdCapacitacion(string nombreCapacitacion)
        {
            return sn.ObtenerIdCapacitacion(nombreCapacitacion);
        }

        public DataTable buscarNotas(string filtro)
        {
            return sn.BusquedaNotas(filtro);
        }

        public DataTable mostrarNotas()
        {
            return sn.ObtenerNotas();
        }

        public List<KeyValuePair<int, string>> CargarCapacitacionesPorDepartamento(int idDepartamento)
        {
            return sn.ObtenerCapacitacionesPorDepartamento(idDepartamento);
        }

        public int ObtenerSiguienteCierre()
        {
            return sn.ObtenerSiguienteIDCierre();
        }



        public bool CambiarEstadoCapacitacion(int idCapacitacion, int nuevoEstado)
        {
            return sn.CambiarEstadoCapacitacion(idCapacitacion, nuevoEstado);
        }

        public void ActualizarNivelCompetencia(int idCapacitacion, string colorSemaforo)
        {
            sn.ActualizarNivelCompetencia(idCapacitacion, colorSemaforo);
        }




        public int obtenerSiguienteNota()
        {
            return sn.ObtenerSiguienteIdNota();
        }

        public bool EditarNota(int idNota, int fkEmpleado, int fkCapacitacion, string nivel, decimal puntaje, string fecha)
        {
            return sn.ActualizarNota(idNota, fkEmpleado, fkCapacitacion, nivel, puntaje, fecha);
        }

        public bool editarNota(int idNota, int fkEmpleado, int fkCapacitacion, int fkNivel, decimal puntaje, string fecha)
        {
            return sn.EditarNota(idNota, fkEmpleado, fkCapacitacion, fkNivel, puntaje, fecha);
        }


        public bool EliminarNota(int idNota)
        {
            return sn.EliminarNota(idNota);
        }

        //METODOS PARA PROMEDIOS
        public decimal ObtenerPromedioNotas(int idDepartamento, int idCapacitacion)
        {
            return sn.promediarNotas(idDepartamento, idCapacitacion);
        }

        public decimal CalcularPorcentajeAsistencia(int idDepartamento, int idCapacitacion)
        {
            return sn.calcularAsistencia(idDepartamento, idCapacitacion);
        }

        // controlador.cs
        public bool InsertarParametros(decimal limiteVerde, decimal limiteAmarillo)
        {
            return sn.InsertarParametros(limiteVerde, limiteAmarillo);
        }

        public bool ActualizarParametros(decimal nuevoVerde, decimal nuevoAmarillo)
        {
            return sn.ActualizarParametros(nuevoVerde, nuevoAmarillo);
        }

        public ParametrosDTO ObtenerParametros()
        {
            Parametros p = sn.ObtenerParametros(); // Devuelve la clase del modelo
            return new ParametrosDTO
            {
                LimiteVerde = p.LimiteVerde,
                LimiteAmarillo = p.LimiteAmarillo
            };
        }

        public int ObtenerIdCompetenciaDesdeCapacitacion(int idCapacitacion)
        {
            return sn.ObtenerIdCompetenciaDesdeCapacitacion(idCapacitacion);
        }

        public string ObtenerNivelActual(int idDepartamento, int idCompetencia)
        {
            return sn.ObtenerNivelActual(idDepartamento, idCompetencia);
        }

        public string ObtenerNombreCompetencia(int idCompetencia)
        {
            return sn.ObtenerNombreCompetencia(idCompetencia);
        }

        public void ActualizarONivelarCompetencia(int idDepartamento, int idCompetencia, string nuevoNivel)
        {
            sn.ActualizarONivelarCompetencia(idDepartamento, idCompetencia, nuevoNivel);
        }

    }
}
