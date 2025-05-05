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
            string bodegaOrigen = "";
            string bodegaDestino = "";

            // Act
            controlador.registrarTrasladoProductos(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino);

            // Assert
            mockSentencias.Verify(m => m.RealizarTraslado(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>()), Times.Never);
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
            string bodegaOrigen = "Bodega Central";
            string bodegaDestino = "Bodega Norte";

            // Configuramos el mock para simular el método RealizarTraslado
            mockSentencias.Setup(s => s.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino));

            // Act
            controlador.registrarTrasladoProductos(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino);

            // Assert
            mockSentencias.Verify(m => m.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino), Times.Once);
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

        [TestMethod]
        public void RegistrarTrasladoProductos_ConCamposCompletos_LlamaRealizarTrasladoConBodegas()
        {
            // Arrange
            string documento = "TDProd-000001";
            string fecha = "2024-03-20";
            int costoTotal = 100;
            int costoTotalGeneral = 1000;
            int precioTotal = 2000;
            int idProducto = 1;
            int idGuia = 1;
            int codigoProducto = 12345;
            string bodegaOrigen = "Bodega Central";
            string bodegaDestino = "Bodega Norte";

            // Configuramos el mock para simular el método RealizarTraslado
            mockSentencias.Setup(s => s.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino));

            // Act
            controlador.registrarTrasladoProductos(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino);

            // Assert
            mockSentencias.Verify(m => m.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino), Times.Once);
        }

        [TestMethod]
        public void RegistrarTrasladoProductos_ConCamposCompletos_LlamaRealizarTrasladoConBodegas2()
        {
            // Arrange
            string documento = "TDProd-000002";
            string fecha = "2024-03-21";
            int costoTotal = 200;
            int costoTotalGeneral = 2000;
            int precioTotal = 4000;
            int idProducto = 2;
            int idGuia = 2;
            int codigoProducto = 67890;
            string bodegaOrigen = "Bodega Sur";
            string bodegaDestino = "Bodega Este";

            // Configuramos el mock para simular el método RealizarTraslado
            mockSentencias.Setup(s => s.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino));

            // Act
            controlador.registrarTrasladoProductos(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino);

            // Assert
            mockSentencias.Verify(m => m.RealizarTraslado(documento, fecha, costoTotal, costoTotalGeneral, precioTotal, idProducto, idGuia, codigoProducto, bodegaOrigen, bodegaDestino), Times.Once);
        }
    }
}
