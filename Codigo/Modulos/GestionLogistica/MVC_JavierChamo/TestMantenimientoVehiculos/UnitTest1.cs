using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador;
using MVC_JavierChamo;

namespace TestMantenimientoVehiculos
{
    [TestClass]
    public class MantenimientoDeVehiculosTests
    {
        private Mantenimiento_de_Vehiculos form;
        private Mock<Cls_Controlador> mockControlador;

        [TestInitialize]
        public void Setup()
        {
            // Crear un Mock del controlador
            mockControlador = new Mock<Cls_Controlador>();
            form = new Mantenimiento_de_Vehiculos(); // Puedes modificar esto para inyectar el mock si es necesario
        }

        [TestMethod]
        public void TestLimpiarTextbox()
        {
            // Arrange: Asignar valores a los textboxes
            form.txtID_mantenimiento.Text = "123";
            form.txt_NombreSolicitante.Text = "Juan Perez";
            form.txt_responsableAsignado.Text = "Carlos";
            form.txt_CodigoError.Text = "E001";
            form.txt_TiempoEstimado.Text = "2h";
            form.txt_fk_id_vehiculo.Text = "1";

            // Act: Llamar al método que limpia los textbox
            form.LimpiarTextbox();

            // Assert: Comprobar que todos los textbox están vacíos
            Assert.AreEqual(string.Empty, form.txtID_mantenimiento.Text);
            Assert.AreEqual(string.Empty, form.txt_NombreSolicitante.Text);
            Assert.AreEqual(string.Empty, form.txt_responsableAsignado.Text);
            Assert.AreEqual(string.Empty, form.txt_CodigoError.Text);
            Assert.AreEqual(string.Empty, form.txt_TiempoEstimado.Text);
            Assert.AreEqual(string.Empty, form.txt_fk_id_vehiculo.Text);
        }
        [TestMethod]
        public void TestInicializacionTextbox()
        {
            // Assert: Verificar que los textboxes están vacíos al iniciar el formulario
            Assert.AreEqual(string.Empty, form.txtID_mantenimiento.Text, "El TextBox txtID_mantenimiento debería estar vacío al iniciar.");
            Assert.AreEqual(string.Empty, form.txt_NombreSolicitante.Text, "El TextBox txt_NombreSolicitante debería estar vacío al iniciar.");
            Assert.AreEqual(string.Empty, form.txt_responsableAsignado.Text, "El TextBox txt_responsableAsignado debería estar vacío al iniciar.");
            Assert.AreEqual(string.Empty, form.txt_CodigoError.Text, "El TextBox txt_CodigoError debería estar vacío al iniciar.");
            Assert.AreEqual(string.Empty, form.txt_TiempoEstimado.Text, "El TextBox txt_TiempoEstimado debería estar vacío al iniciar.");
            Assert.AreEqual(string.Empty, form.txt_fk_id_vehiculo.Text, "El TextBox txt_fk_id_vehiculo debería estar vacío al iniciar.");
        }

        [TestMethod]
        public void TestTextboxFunctionality()
        {
            // Arrange: Asignar un valor al TextBox
            string expectedText = "Texto de prueba";
            form.txt_NombreSolicitante.Text = expectedText;

            // Act: Obtener el texto del TextBox
            string actualText = form.txt_NombreSolicitante.Text;

            // Assert: Verificar que el TextBox retorne el valor esperado
            Assert.AreEqual(expectedText, actualText, "El TextBox txt_NombreSolicitante debería contener el texto asignado.");
        }

        [TestMethod]
        public void TestTextboxFunctionality_Empty()
        {
            // Arrange: Limpiar el TextBox
            form.txt_fk_id_vehiculo.Text = string.Empty;

            // Act: Obtener el texto del TextBox
            string actualText = form.txt_fk_id_vehiculo.Text;

            // Assert: Verificar que el TextBox esté vacío
            Assert.AreEqual(string.Empty, actualText, "El TextBox txt_fk_id_vehiculo debería estar vacío.");
        }
    }
}
