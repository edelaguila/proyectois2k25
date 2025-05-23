using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Modelo_Cotizacion;

namespace TestCotizacion
{
    [TestClass]
    public class TestInsert
    {
        [TestMethod]
        public void test_insert_encabezado()
        { // Arrange


            var idCotizacion = "12345";
            var idVendedor = "1";
            var idClientes = "1";
            DateTime fechaVencimiento = DateTime.Now.AddDays(30);
            var totalCotizacion = "5000.00";
            var claseCotizacion = new Sentencia(); // Reemplaza por la clase donde está funInsertarCotizacionE
            try
            {
                // Act
                claseCotizacion.funInsertarCotizacionE(idCotizacion, idVendedor, idClientes, fechaVencimiento, totalCotizacion);
            }
            catch (Exception ex)
            {
                // Si hay una excepción, falla la prueba y muestra el mensaje de error
                Assert.Fail($"La inserción falló con la excepción: {ex.Message}");
            }

        }

        [TestMethod]
        public void test_insert_detalle_cotizacion()
        {
            // Arrange
            var idCotizacion = 12345;  // Asegúrate de que este ID existe en Tbl_cotizacion_encabezado si tienes la restricción de llave foránea
            var idProducto = 1;  // Ajusta según un ID de producto válido en tu base de datos
            var cantidad = 10;
            var precio = 150.75m;
            var subtotal = cantidad * precio;
            var claseCotizacion = new Sentencia(); // Reemplaza con el nombre de tu clase real

            try
            {
                // Act
                claseCotizacion.funInsertarCotizacionD(idCotizacion, idProducto, cantidad, precio, subtotal);
            }
            catch (Exception ex)
            {
                // Si hay una excepción, falla la prueba y muestra el mensaje de error
                Assert.Fail($"La inserción del detalle falló con la excepción: {ex.Message}");
            }
        }


    }
}
