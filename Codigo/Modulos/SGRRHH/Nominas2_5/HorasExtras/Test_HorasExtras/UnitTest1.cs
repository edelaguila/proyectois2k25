using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_HorasExtras
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHorasExtras()
        {

            // Arrange: Preparar datos de prueba*
            decimal deSalario = 5000.00m; // Ejemplo de salario mensual yo le puse 5000
            decimal deCantidadHorasExtras = 10; // Cantidad de horas extras trabajadas en el mes

            // Cálculo del valor esperado de horas extras
            decimal dePagoPorHora = deSalario / 30 / 8;
            decimal dePagoHorasExtras = dePagoPorHora * 1.5m * deCantidadHorasExtras;

            // Act: Ejecutar el cálculo del pago de horas extras
            decimal deResultado = dePagoPorHora * 1.5m * deCantidadHorasExtras;

            // Assert: Comprobar que el resultado sea el esperado
            Assert.AreEqual(dePagoHorasExtras, deResultado, "El cálculo de horas extras no es correcto.");
            Console.WriteLine($"Valor esperado de horas extras: {dePagoHorasExtras}"); //para que se pueda ver el resultado y tiene que da 312.500



        }


    }
}
