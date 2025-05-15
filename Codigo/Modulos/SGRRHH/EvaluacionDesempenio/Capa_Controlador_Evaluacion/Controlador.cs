using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Evaluacion; // Para interactuar con el modelo

namespace Capa_Controlador_Evaluacion
{
    public class Controlador
    {
        private Sentencias modelo;  // Instancia del modelo, que maneja la lógica de negocio

        public Controlador()
        {
            // Inicializa la instancia del modelo
            modelo = new Sentencias();
        }

        // Método para obtener empleados y evaluadores desde el modelo
        public DataTable ObtenerEmpleados()
        {
            return modelo.ObtenerEmpleados();
        }

        public DataTable ObtenerEvaluadores()
        {
            return modelo.ObtenerEvaluadores();
        }

        // Método para insertar evaluación general
        public int InsertarEvaluacion(int fkEmpleado, int fkEvaluador, string tipoEvaluacion, decimal calificacion, string comentarios, DateTime fechaEvaluacion)
        {
            return modelo.InsertarEvaluacion(fkEmpleado, fkEvaluador, tipoEvaluacion, calificacion, comentarios, fechaEvaluacion);
        }


        // Método para insertar detalles de la evaluación
        public void InsertarDetalleEvaluacion(int idEvaluacion, int idCompetencia, decimal calificacion, string comentarios)
        {
            modelo.InsertarDetalleEvaluacion(idEvaluacion, idCompetencia, calificacion, comentarios);
        }

        public DataTable ObtenerEvaluacionesPorEmpleado(int idEmpleado)
        {
            return modelo.ObtenerEvaluacionesPorEmpleado(idEmpleado);
        }


        // Obtener competencias activas para la vista
        public DataTable ObtenerCompetenciasActivas()
        {
            return modelo.ObtenerCompetenciasActivas();
        }

    }
}
