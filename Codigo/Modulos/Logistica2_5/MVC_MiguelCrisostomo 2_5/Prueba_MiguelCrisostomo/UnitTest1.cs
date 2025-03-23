using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using Capa_Controlador_MiguelCrisostomo;
using Capa_Modelo_MiguelCrisostomo;

namespace Prueba_MiguelCrisostomo
{
    [TestClass]
    public class ControladorTests
    {
        private Mock<sentencias> mockSentencias;
        private controlador controlador;

        // Constructor de la clase de prueba
        public ControladorTests()
        {
            mockSentencias = new Mock<sentencias>();
            controlador = new controlador(mockSentencias.Object);
        }

        [TestMethod]
        public void RegistrarTrasladoProductos_ConCamposVacios_MuestraMensajeError()
        {
            // Arrange
            string documento = "";
            string fecha = "";
            int costoTotal = -1;
            int costoTotalGeneral = -1;
            int precioTotal = -1;
            int idProducto = -1;
            int idGuia = -1;
            int codigoProducto = -1;

            // Act
            controlador.registrarTrasladoProductos(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto);

            // Assert
            mockSentencias.Verify(m => m.RealizarTraslado(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public void RegistrarTrasladoProductos_ConCamposCompletos_LlamaRealizarTraslado()
        {
            // Arrange
            string documento = "TRS123";
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            int costoTotal = 1000;
            int costoTotalGeneral = 2000;
            int precioTotal = 3000;
            int idProducto = 1;
            int idGuia = 2;
            int codigoProducto = 3;

            // Configuramos el mock para simular el método RealizarTraslado
            mockSentencias.Setup(s => s.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto));

            // Act
            controlador.registrarTrasladoProductos(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto);

            // Assert
            mockSentencias.Verify(m => m.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto), Times.Once);
        }

        [TestMethod]
        public void ObtenerIdGuiaPorDestino_ConDestinoValido_ReturnsExpectedId()
        {
            // Arrange
            string destino = "Almacen Central";
            int expectedIdGuia = 10;

            mockSentencias.Setup(s => s.ObtenerIdGuiaPorDestino(destino)).Returns(expectedIdGuia);

            // Act
            int result = controlador.ObtenerIdGuiaPorDestino(destino);

            // Assert
            Assert.AreEqual(expectedIdGuia, result);
        }

        [TestMethod]
        public void ObtenerFechaEmisionPorDestino_ConDestinoValido_ReturnsExpectedFecha()
        {
            // Arrange
            string destino = "Almacen Central";
            DateTime expectedFecha = new DateTime(2023, 10, 5);

            mockSentencias.Setup(s => s.ObtenerFechaEmisionPorDestino(destino)).Returns(expectedFecha);

            // Act
            DateTime result = controlador.ObtenerFechaEmisionPorDestino(destino);

            // Assert
            Assert.AreEqual(expectedFecha, result);
        }

        [TestMethod]
        public void ObtenerCodigosProductos_ReturnsExpectedCodigos()
        {
            // Arrange
            List<int> expectedCodigos = new List<int> { 1, 2, 3 };

            mockSentencias.Setup(s => s.ObtenerCodigosProductos()).Returns(expectedCodigos);

            // Act
            List<int> result = controlador.ObtenerCodigosProductos();

            // Assert
            CollectionAssert.AreEqual(expectedCodigos, result);
        }

        [TestMethod]
        public void ActualizarStockProducto_LlamaMetodoModelo()
        {
            // Arrange
            int codigoProducto = 1;
            int nuevoStock = 50;

            // Act
            controlador.ActualizarStockProducto(codigoProducto, nuevoStock);

            // Assert
            mockSentencias.Verify(m => m.ActualizarStockProducto(codigoProducto, nuevoStock), Times.Once);
        }
    }
}
