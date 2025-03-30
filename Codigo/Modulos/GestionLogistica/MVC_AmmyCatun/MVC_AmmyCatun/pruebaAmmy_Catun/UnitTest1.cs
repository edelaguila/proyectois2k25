using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using Moq;
using Capa_Controlador_AmmyCatun;
using Capa_Modelo_AmmyCatun;
using System.Windows.Forms;

namespace pruebaAmmy_Catun
{
    [TestClass]
    public class ControladorTests
    {
        private Mock<Sentencias> mockSentencias;
        private ControladorPedido controladorPedido;
        private ControladorVehiculo controladorVehiculo;

         // Constructor de la clase de prueba
            public ControladorTests()
            {
                // Inicialización de objetos
                mockSentencias = new Mock<Sentencias>();
                controladorPedido = new ControladorPedido(mockSentencias.Object);
                controladorVehiculo = new ControladorVehiculo(mockSentencias.Object);
            }

            // ==========================================
            // Pruebas para el ControladorPedido
            // ==========================================

            [TestMethod]
            public void RegistrarPedido_ConCamposVacios_ReturnsError()
            {
                // Arrange
                var direccionPartida = "";
                var direccionLlegada = "";
                var numeroOrdenRecojo = "";
                var cmbFormaPago = new ComboBox();
                var destino = "";
                DateTime fechaEmision = DateTime.Now;
                DateTime fechaTraslado = DateTime.Now;
                int idRemitente = 0;
                int idDestinatario = 0;
                int idVehiculo = 0;

                // Act
                var result = controladorPedido.guardarPedido(direccionPartida, direccionLlegada, numeroOrdenRecojo, cmbFormaPago, destino, fechaEmision, fechaTraslado, idRemitente, idDestinatario, idVehiculo);

                // Assert
                Assert.AreEqual(0, result);  // Debe retornar 0 si los campos son vacíos
            }

            [TestMethod]
            public void RegistrarPedido_ConCamposCompletos_ReturnsSuccess()
            {
                // Arrange
                var direccionPartida = "Av. Siempre Viva";
                var direccionLlegada = "Calle Falsa 123";
                var numeroOrdenRecojo = "ORD123";
                var cmbFormaPago = new ComboBox();
                cmbFormaPago.Items.Add("Efectivo");
                var destino = "Almacén";
                DateTime fechaEmision = DateTime.Now;
                DateTime fechaTraslado = DateTime.Now.AddHours(2);
                int idRemitente = 1;
                int idDestinatario = 2;
                int idVehiculo = 3;

                // Configuramos el mock para simular que se guarda el pedido
                mockSentencias.Setup(s => s.registrarPedido(fechaEmision, fechaTraslado, direccionPartida, direccionLlegada, numeroOrdenRecojo, "Efectivo", destino, idRemitente, idDestinatario, idVehiculo));

                // Act
                var result = controladorPedido.guardarPedido(direccionPartida, direccionLlegada, numeroOrdenRecojo, cmbFormaPago, destino, fechaEmision, fechaTraslado, idRemitente, idDestinatario, idVehiculo);

                // Assert
                Assert.AreEqual(1, result);  // Debe retornar 1 si el pedido se registra correctamente
                mockSentencias.Verify(m => m.registrarPedido(fechaEmision, fechaTraslado, direccionPartida, direccionLlegada, numeroOrdenRecojo, "Efectivo", destino, idRemitente, idDestinatario, idVehiculo), Times.Once);
            }

            [TestMethod]
            public void EliminarPedido_ConIdGuiaVacio_ReturnsError()
            {
                // Arrange
                var idGuia = "";  // ID vacío

                // Act
                controladorPedido.eliminarPedido(idGuia);

                // Assert
                mockSentencias.Verify(m => m.eliminarPedido(It.IsAny<string>()), Times.Never);  // No debe llamarse eliminar si el id está vacío
            }

            [TestMethod]
            public void EliminarPedido_ConIdGuiaValido_ReturnsSuccess()
            {
                // Arrange
                var idGuia = "12345";  // ID válido

                // Configuramos el mock para simular que el pedido se elimina
                mockSentencias.Setup(m => m.eliminarPedido(idGuia));

                // Act
                controladorPedido.eliminarPedido(idGuia);

                // Assert
                mockSentencias.Verify(m => m.eliminarPedido(It.Is<string>(s => s == idGuia)), Times.Once);  // Verificamos que se haya llamado con el ID correcto
            }

            // ==========================================
            // Pruebas para el ControladorVehiculo
            // ==========================================

            [TestMethod]
            public void RegistrarVehiculo_ConCamposVacios_ReturnsError()
            {
                // Arrange
                var numeroPlaca = "";
                var marca = "";
                var color = "";
                var descripcion = "";
                var horaLlegada = "";
                var horaSalida = "";
                var pesoTotal = 0.0;
                var idChofer = 0;

                // Act
                var result = controladorVehiculo.guardarVehiculo(numeroPlaca, marca, color, descripcion, horaLlegada, horaSalida, pesoTotal, idChofer);

                // Assert
                Assert.AreEqual(0, result);  // Esperamos que retorne 0 en caso de error
            }

            [TestMethod]
            public void RegistrarVehiculo_ConCamposCompletos_ReturnsSuccess()
            {
                // Arrange
                var numeroPlaca = "ABC123";
                var marca = "Toyota";
                var color = "Rojo";
                var descripcion = "Vehículo de carga";
                var horaLlegada = "08:00";
                var horaSalida = "16:00";
                var pesoTotal = 1500.0;
                var idChofer = 1;

                // Configuramos el mock para simular el comportamiento del método registrarVehiculo
                mockSentencias.Setup(s => s.registrarVehiculo(numeroPlaca, marca, color, descripcion, horaLlegada, horaSalida, pesoTotal, idChofer));

                // Act
                var result = controladorVehiculo.guardarVehiculo(numeroPlaca, marca, color, descripcion, horaLlegada, horaSalida, pesoTotal, idChofer);

                // Assert
                Assert.AreEqual(1, result);  // Esperamos que retorne 1 para éxito
                mockSentencias.Verify(m => m.registrarVehiculo(numeroPlaca, marca, color, descripcion, horaLlegada, horaSalida, pesoTotal, idChofer), Times.Once);
            }

            [TestMethod]
            public void EliminarVehiculo_ConIdVacio_ReturnsError()
            {
                // Arrange
                var idVehiculo = "";  // ID vacío

                // Act
                controladorVehiculo.eliminarVehiculo(idVehiculo);

                // Assert
                mockSentencias.Verify(m => m.eliminarVehiculo(It.IsAny<string>()), Times.Never); // No debe llamarse el método eliminar
            }

            [TestMethod]
            public void EliminarVehiculo_ConIdValido_ReturnsSuccess()
            {
                // Arrange
                var idVehiculo = "1";  // ID válido

                // Configuramos el mock para simular que el vehículo se elimina correctamente
                mockSentencias.Setup(m => m.eliminarVehiculo(idVehiculo));

                // Act
                controladorVehiculo.eliminarVehiculo(idVehiculo);

                // Assert
                mockSentencias.Verify(m => m.eliminarVehiculo(It.Is<string>(s => s == idVehiculo)), Times.Once); // Verificamos que se haya llamado con el idVehiculo correcto
            }
        }
    }

