using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Falta
{
    [TestClass]
    public class UnitTest1
    {
        // Método cálculo de deducción de faltas
        private decimal SimularCalculoDeduccionFaltas(int cantidadFaltas, decimal montoDeduccionPorFalta)
        {
            if (cantidadFaltas < 0)
                throw new ArgumentException("La cantidad de faltas no puede ser negativa.");

            // cálculo faltas * monto por falta
            return cantidadFaltas * montoDeduccionPorFalta;
        }

        [TestMethod]
        public void SimularCalculoDeduccionFaltas_ConFaltas_RetornaDeduccionCorrecta()
        {
            // Arrange
            int cantidadFaltas = 3;
            decimal montoDeduccionPorFalta = 50;

            // Act
            decimal resultado = SimularCalculoDeduccionFaltas(cantidadFaltas, montoDeduccionPorFalta);

            // Assert
            Assert.AreEqual(150, resultado); // 3 faltas * 50 = 150
        }

        [TestMethod]
        public void SimularCalculoDeduccionFaltas_SinFaltas_RetornaCero()
        {
            // Arrange
            int cantidadFaltas = 0;
            decimal montoDeduccionPorFalta = 50;

            // Act
            decimal resultado = SimularCalculoDeduccionFaltas(cantidadFaltas, montoDeduccionPorFalta);

            // Assert
            Assert.AreEqual(0, resultado); // Sin faltas, la deducción debe ser 0
        }

        [TestMethod]
        public void SimularCalculoDeduccionFaltas_ConCantidadFaltasNegativa_LanzaExcepcion()
        {
            // Arrange
            int cantidadFaltas = -1;
            decimal montoDeduccionPorFalta = 50;

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
                SimularCalculoDeduccionFaltas(cantidadFaltas, montoDeduccionPorFalta));

            Assert.AreEqual("La cantidad de faltas no puede ser negativa.", exception.Message);
        }
    }
}
