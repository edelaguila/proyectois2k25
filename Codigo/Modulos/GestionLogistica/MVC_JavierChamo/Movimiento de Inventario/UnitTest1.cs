using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo;


namespace Movimiento_de_Inventario
{
    [TestClass]
    public class UnitTest1
    {
        private Cls_Sentencias sentencias;

        [TestInitialize]
        public void Setup()
        {
            sentencias = new Cls_Sentencias(); // Inicializa la clase Sentencias
        }
        [TestMethod]
        public void TestLlenarComboBoxID_Producto()
        {
            // Arrange
            string tabla = "Tbl_Productos"; // Cambia esto por el nombre real de tu tabla
            string campoID = "Pk_id_Producto"; // Cambia esto por el nombre real del campo que quieres seleccionar

            // Act
            DataTable resultado = sentencias.Fun_LlenarCmb(tabla, campoID);

            // Assert
            Assert.IsNotNull(resultado, "El resultado no debe ser null.");
            Assert.IsTrue(resultado.Rows.Count > 0, "El ComboBox debería estar lleno con datos.");
        }
        [TestMethod]
        public void TestLlenarComboBoxID_Stock()
        {
            // Arrange
            string tabla = "Tbl_TrasladoProductos"; // Cambia esto por el nombre real de tu tabla
            string campoID = "Pk_id_TrasladoProductos"; // Cambia esto por el nombre real del campo que quieres seleccionar

            // Act
            DataTable resultado = sentencias.Fun_LlenarCmb(tabla, campoID);

            // Assert
            Assert.IsNotNull(resultado, "El resultado no debe ser null.");
            Assert.IsTrue(resultado.Rows.Count > 0, "El ComboBox debería estar lleno con datos.");
        }
        [TestMethod]
        public void TestLlenarComboBoxID_Local()
        {
            // Arrange
            string tabla = "TBL_LOCALES"; // Cambia esto por el nombre real de tu tabla
            string campoID = "Pk_ID_LOCAL"; // Cambia esto por el nombre real del campo que quieres seleccionar

            // Act
            DataTable resultado = sentencias.Fun_LlenarCmb(tabla, campoID);

            // Assert
            Assert.IsNotNull(resultado, "El resultado no debe ser null.");
            Assert.IsTrue(resultado.Rows.Count > 0, "El ComboBox debería estar lleno con datos.");
        }
    }
}
