using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Modelo_Liquidaciones;
using System.Data;

namespace Test_dll_liquidacion
{
    [TestClass]
    public class TestLiquidaciones
    {
        /* ------------------------------------------- Código por Gabriela Suc ------------------------------------------- */

        [TestMethod]
        public void funObtenerEmpleados_DevuelveEmpleadosConFechaBajaEnAnioActual()
        {
            // Arrange: inicializar las variables
            var sentencias = new Sentencias();

            // Act: ejecución del método
            DataTable empleados = sentencias.funObtenerEmpleados();

            // Assert: comprobación de los resultados

            Assert.IsNotNull(empleados, "La tabla de empleados no debería ser nula.");
            Assert.IsTrue(empleados.Rows.Count > 0, "Debería devolver al menos un empleado cuya fecha de baja esté en el año actual.");
        }

        [TestMethod]
        public void meObtenerSalario_EmpleadoExistente_DevuelveSalario()
        {
            // Arrange
            var sentencias = new Sentencias();
            int empleadoId = 1;

            // Act
            decimal salario = sentencias.meObtenerSalario(empleadoId);

            // Assert
            Assert.IsTrue(salario > 0, "El salario debería ser mayor a cero para un empleado existente.");
        }

        [TestMethod]
        public void meObtenerFechaAlta_EmpleadoExistente_DevuelveFecha()
        {
            // Arrange
            var sentencias = new Sentencias();
            int empleadoId = 1;

            // Act
            DateTime? fechaAlta = sentencias.meObtenerFechaAlta(empleadoId);

            // Assert
            Assert.IsNotNull(fechaAlta, "La fecha de alta no debería ser nula para un empleado existente.");
        }

        [TestMethod]
        public void meObtenerFechaBaja_EmpleadoExistente_DevuelveFechaOEsNulo()
        {
            // Arrange
            var sentencias = new Sentencias();
            int empleadoId = 1;

            // Act
            DateTime? fechaBaja = sentencias.meObtenerFechaBaja(empleadoId);

            // Assert
            Assert.IsTrue(fechaBaja == null || fechaBaja.Value <= DateTime.Now, "La fecha de baja debería ser nula o menor o igual a la fecha actual.");
        }

        [TestMethod]
        public void meCalcularDiasLaborados_EmpleadoExistente_DevuelveDiasCorrectos()
        {
            // Arrange
            var sentencias = new Sentencias();
            int empleadoId = 1;

            // Act
            int diasLaborados = sentencias.meCalcularDiasLaborados(empleadoId);

            // Assert
            Assert.IsTrue(diasLaborados >= 0, "Los días laborados deberían ser iguales o mayores a cero.");
        }

        [TestMethod]
        public void meCalcularAguinaldo_AnioCompleto_DevuelveMontoCorrecto()
        {
            // Arrange
            int empleadoId = 1;
            int diasLaborados = 365;
            decimal salario = 1000m;
            decimal aguinaldoEsperado = salario * 12 * 1.0m; // Cálculo esperado

            // Crear una instancia de la clase Sentencias
            var sentencias = new Sentencias();

            // Act
            decimal aguinaldoCalculado = sentencias.meCalcularAguinaldo(empleadoId, diasLaborados, salario);

            // Assert
            Assert.AreEqual(aguinaldoEsperado, aguinaldoCalculado, "El cálculo del aguinaldo para un año completo es incorrecto.");
        }

        [TestMethod]
        public void meCalcularAguinaldo_AnioIncompleto_DevuelveMontoProporcional()
        {
            // Arrange
            int empleadoId = 1;
            int diasLaborados = 180;
            decimal salario = 1000m;
            decimal aguinaldoEsperado = (salario * diasLaborados) / 365; // Cálculo esperado

            // Crear una instancia de la clase Sentencias
            var sentencias = new Sentencias();

            // Act
            decimal aguinaldoCalculado = sentencias.meCalcularAguinaldo(empleadoId, diasLaborados, salario);

            // Assert
            Assert.AreEqual(aguinaldoEsperado, aguinaldoCalculado, "El cálculo del aguinaldo proporcional es incorrecto.");
        }

        [TestMethod]
        public void meCalcularVacaciones_AnioCompleto_DevuelveMontoCorrecto()
        {
            // Arrange
            int empleadoId = 1;
            int diasLaborados = 365;
            decimal salario = 1000m;
            decimal vacacionesEsperadas = salario * 12 * 1.0m; // Cálculo esperado

            // Crear una instancia de la clase Sentencias
            var sentencias = new Sentencias();

            // Act
            decimal vacacionesCalculadas = sentencias.meCalcularVacaciones(empleadoId, diasLaborados, salario);

            // Assert
            Assert.AreEqual(vacacionesEsperadas, vacacionesCalculadas, "El cálculo de vacaciones para un año completo es incorrecto.");
        }

        [TestMethod]
        public void meCalcularVacaciones_AnioIncompleto_DevuelveMontoProporcional()
        {
            // Arrange
            int empleadoId = 1;
            int diasLaborados = 180;
            decimal salario = 1000m;
            decimal vacacionesEsperadas = salario * (diasLaborados / 365m) * 1.0m; // Cálculo esperado

            // Crear una instancia de la clase Sentencias
            var sentencias = new Sentencias();

            // Act
            decimal vacacionesCalculadas = sentencias.meCalcularVacaciones(empleadoId, diasLaborados, salario);

            // Assert
            Assert.AreEqual(vacacionesEsperadas, vacacionesCalculadas, "El cálculo de vacaciones proporcional es incorrecto.");
        }

        [TestMethod]
        public void meCalcularBono14_PrimerSemestre_DevuelveMontoCorrecto()
        {
            // Arrange
            int empleadoId = 1;
            decimal salario = 1000m;
            DateTime fechaPrueba = new DateTime(DateTime.Now.Year, 3, 1); // Dentro del primer semestre
            decimal bonoEsperado = salario * 6 * 1.0m; // Cálculo esperado

            // Crear una instancia de la clase Sentencias
            var sentencias = new Sentencias();

            // Act
            decimal bonoCalculado = sentencias.meCalcularBono14(empleadoId, salario);

            // Assert
            Assert.AreEqual(bonoEsperado, bonoCalculado, "El cálculo del Bono 14 para el primer semestre es incorrecto.");
        }

        [TestMethod]
        public void meCalcularBono14_SegundoSemestre_DevuelveMontoCorrecto()
        {
            // Arrange
            int empleadoId = 1;
            decimal salario = 1000m;

            // Crear una instancia de la clase Sentencias
            var sentencias = new Sentencias();

            // Act
            decimal bonoCalculado = sentencias.meCalcularBono14(empleadoId, salario); // Llamada al método de la instancia

            // Assert
            Assert.AreEqual(6000m, bonoCalculado, "El cálculo del Bono 14 para el segundo semestre es incorrecto.");
        }

        [TestMethod]
        public void meObtenerMontoBono14_DevuelveMontoCorrecto()
        {
            // Arrange
            var sentencias = new Sentencias();

            // Obtener el método privado mediante reflexión
            var methodInfo = typeof(Sentencias).GetMethod("meObtenerMontoBono14",
                                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            // Invocar el método privado
            decimal montoCalculado = (decimal)methodInfo.Invoke(sentencias, null);

            decimal montoEsperado = 500m;

            // Assert
            Assert.AreEqual(montoEsperado, montoCalculado, "El monto calculado para el Bono 14 es incorrecto.");
        }


        [TestMethod]
        public void meCalcularMesesLaborados_CalculaMesesCorrectos()
        {
            // Arrange
            int empleadoId = 1;
            DateTime fechaInicio = new DateTime(2023, 1, 1); // Fecha de inicio de prueba
            DateTime fechaFin = new DateTime(2023, 12, 31);  // Fecha de fin de prueba
            var sentencias = new Sentencias();

            // Obtener el método privado mediante reflexión
            var methodInfo = typeof(Sentencias).GetMethod("meCalcularMesesLaborados",
                                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            // Invocar el método privado
            int mesesCalculados = (int)methodInfo.Invoke(sentencias, new object[] { empleadoId, fechaInicio, fechaFin });

            int mesesEsperados = 12; // Se espera que haya 12 meses de trabajo

            // Assert
            Assert.AreEqual(mesesEsperados, mesesCalculados, "El cálculo de los meses laborados es incorrecto.");
        }

        [TestMethod]
        public void meInsertarBono14DeduPerpEmp_RealizaInsercionCorrecta()
        {
            // Arrange
            int empleadoId = 1;
            decimal bono14 = 1000m;
            var sentencias = new Sentencias();

            // Act
            try
            {
                sentencias.meInsertarBono14DeduPerpEmp(empleadoId, bono14);
            }
            catch (Exception ex)
            {
                Assert.Fail($"La inserción del Bono 14 falló: {ex.Message}");
            }

            // Assert: Comprobación que no se lanzó ninguna excepción durante la inserción
            Assert.IsTrue(true, "El Bono 14 se insertó correctamente en la base de datos.");
        }

        [TestMethod]
        public void meVerificarExistenciaLiquidacion_ExisteRegistro_DevuelveTrue()
        {
            // Arrange
            int empleadoId = 1;
            var sentencias = new Sentencias();

            // Act
            bool existeLiquidacion = sentencias.meVerificarExistenciaLiquidacion(empleadoId);

            // Assert
            Assert.IsTrue(existeLiquidacion, "El registro de la liquidación debería existir en la base de datos.");
        }

        [TestMethod]
        public void meVerificarExistenciaLiquidacion_NoExisteRegistro_DevuelveFalse()
        {
            // Arrange
            int empleadoId = 9999; // ID de un empleado que no existe
            var sentencias = new Sentencias();

            // Act
            bool existeLiquidacion = sentencias.meVerificarExistenciaLiquidacion(empleadoId);

            // Assert
            Assert.IsFalse(existeLiquidacion, "El registro de la liquidación no debería existir para un empleado inexistente.");
        }

        [TestMethod]
        public void funObtenerLiquidacionesTrabajadores_DevuelveDatosCorrectos()
        {
            // Arrange
            var sentencias = new Sentencias();

            // Act
            DataTable liquidaciones = sentencias.funObtenerLiquidacionesTrabajadores();

            // Assert
            Assert.IsNotNull(liquidaciones, "La tabla de liquidaciones no debería ser nula.");
            Assert.IsTrue(liquidaciones.Rows.Count > 0, "Debería devolver al menos una liquidación de los trabajadores.");
        }


    }
}
