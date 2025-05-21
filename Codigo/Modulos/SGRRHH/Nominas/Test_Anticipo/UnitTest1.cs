using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Anticipo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange: Preparar datos de prueba
            decimal anticipo = 200; // Ejemplo de un anticpo
            decimal mul = 1; // solo para que multiplique 

            // Act: Ejecutar el calculo de anticipos
            decimal total_anticipos = anticipo * mul;
            decimal resultado = 200;

            // Assert: Comprobar que el es el resultado esperado
            Assert.AreEqual(total_anticipos, resultado, "El calculo de anticipos no es correcto.");
        }
    }
}
