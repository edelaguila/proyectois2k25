using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaModelo_AndresVeron;
using System;


namespace TestTransaccionClientes
{
    [TestClass]
    public class TestTransaccionClientes
    {
        [TestMethod]
        public void InsertarTransaccion_DatosValidos_RetornaTrue()
        {
            // Arrange: configurar las variables de entrada
            var sentencias = new Sentencias();
            int idCliente = 1;
            string fecha = "10/10/2024";
            string monto = "10050";
            string tipoMoneda = "USD";
            int estado = 1;
            int idFactura = 1;
            int idTransC = 2;
            string tipo = "Venta";

            // Act: ejecutar el método que se está probando
            bool resultado = sentencias.InsertarTransaccion(idCliente, fecha, monto, tipoMoneda, estado, idFactura, idTransC, tipo);

            // Assert: verificar el resultado esperado
            Assert.IsTrue(resultado, "La inserción debería retornar true para datos válidos");
        }
    }
}
