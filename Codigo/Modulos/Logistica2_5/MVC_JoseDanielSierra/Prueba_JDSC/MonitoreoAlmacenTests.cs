using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_JDSC;

namespace Prueba_JDSC
{
    [TestClass]
    public class ControladorTests
    {
        private Controlador controlador;

        [TestInitialize]
        public void SetUp()
        {
            // Inicializa el controlador antes de cada prueba
            controlador = new Controlador();
        }

        [TestMethod]
        public void CargarExistencias_Valido_DeberiaLlenarDataTable()
        {
            // Arrange: Configura el ID de bodega y un DataTable para almacenar las existencias
            string idBodega = "1";
            DataTable dtExistencias = new DataTable();

            // Act: Llama al método para cargar existencias en el DataTable
            controlador.CargarExistencias(idBodega, dtExistencias);

            // Assert: Verifica que el DataTable contiene filas
            Assert.IsTrue(dtExistencias.Rows.Count > 0, "El DataTable debería contener datos para la bodega especificada.");
        }

        [TestMethod]
        public void Auditar_Valido_NoLanzaExcepcion()
        {
            // Arrange: Configura los valores necesarios para realizar la auditoría
            int idBodega = 1;
            int idProducto = 1;
            DateTime fechaAuditoria = DateTime.Now;
            string observaciones = "Prueba de auditoría";
            int cantidadRegistrada = 100;
            int cantidadFisica = 95;
            bool discrepancia = true;
            DataGridView dgvAuditorias = new DataGridView();

            // Act & Assert: Ejecuta el método y verifica que no lanza ninguna excepción
            try
            {
                controlador.RealizarAuditoria(idBodega, idProducto, fechaAuditoria, observaciones, cantidadRegistrada, cantidadFisica, discrepancia, dgvAuditorias);
            }
            catch (Exception ex)
            {
                Assert.Fail($"No se esperaba una excepción, pero se lanzó: {ex.Message}");
            }
        }

        [TestMethod]
        public void ListarBodegas_NoVacio()
        {
            // Act: Llama al método para obtener la lista de bodegas
            var bodegas = controlador.listadoBodegas();

            // Assert: Verifica que la lista no sea nula y contenga al menos una bodega
            Assert.IsNotNull(bodegas, "La lista de bodegas no debería ser nula.");
            Assert.IsTrue(bodegas.Count > 0, "Debería haber al menos una bodega en la lista.");
        }
    }
}