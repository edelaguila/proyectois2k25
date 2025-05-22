using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Controlador_Evaluacion;
using System.Data;

namespace Prueba_Evaluacion
{
    [TestClass]
    public class EvaluacionDesempenioTest
    {
        private Controlador controlador;

        [TestInitialize]
        public void SetUp()
        {
            controlador = new Controlador();
        }

        [TestMethod]
        public void ObtenerEmpleados_DeberiaRetornarDatos()
        {
            // Act
            DataTable empleados = controlador.ObtenerEmpleados();

            // Assert
            Assert.IsNotNull(empleados, "La consulta de empleados no debe retornar null.");
            Assert.IsTrue(empleados.Rows.Count > 0, "La consulta de empleados debería retornar al menos una fila.");
        }

        [TestMethod]
        public void ObtenerEvaluadores_DeberiaRetornarDatos()
        {
            // Act
            DataTable evaluadores = controlador.ObtenerEvaluadores();

            // Assert
            Assert.IsNotNull(evaluadores, "La consulta de evaluadores no debe retornar null.");
            Assert.IsTrue(evaluadores.Rows.Count > 0, "La consulta de evaluadores debería retornar al menos una fila.");
        }

        [TestMethod]
        public void InsertarEvaluacion_DatosValidos_DeberiaInsertarYRetornarId()
        {
            // Arrange
            int fkEmpleado = 1;
            int fkEvaluador = 2;
            string tipoEvaluacion = "Evaluacion de subordinado";
            decimal calificacion = 8.7m;
            string comentarios = "Desempeño sólido.";
            DateTime fecha = DateTime.Now;

            // Act
            int idEvaluacion = controlador.InsertarEvaluacion(fkEmpleado, fkEvaluador, tipoEvaluacion, calificacion, comentarios, fecha);

            // Assert
            Assert.IsTrue(idEvaluacion > 0, "El método debería retornar un ID válido (>0).");
        }

        [TestMethod]
        public void InsertarDetalleEvaluacion_DatosValidos_NoLanzaExcepcion()
        {
            // Arrange
            int idEvaluacion = 1; // Asegúrate que este ID exista o se haya generado previamente
            int idCompetencia = 1;
            decimal calificacion = 9.0m;
            string comentario = "Excelente liderazgo.";

            // Act & Assert
            try
            {
                controlador.InsertarDetalleEvaluacion(idEvaluacion, idCompetencia, calificacion, comentario);
            }
            catch (Exception ex)
            {
                Assert.Fail($"No se esperaba una excepción, pero se lanzó: {ex.Message}");
            }
        }

        [TestMethod]
        public void ObtenerEvaluacionesPorEmpleado_IdValido_DeberiaRetornarEvaluaciones()
        {
            // Arrange
            int idEmpleado = 1; // Asegúrate que este empleado tenga evaluaciones registradas

            // Act
            DataTable evaluaciones = controlador.ObtenerEvaluacionesPorEmpleado(idEmpleado);

            // Assert
            Assert.IsNotNull(evaluaciones, "La consulta no debe retornar null.");
            Assert.IsTrue(evaluaciones.Rows.Count > 0, "Debería haber evaluaciones registradas para este empleado.");
        }
    }
}
