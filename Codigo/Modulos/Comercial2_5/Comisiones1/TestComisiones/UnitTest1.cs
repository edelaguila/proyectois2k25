using Capa_Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Controlador;
using Capa_Vista;
using System.Data.Odbc;
using System.Data;
using System.Globalization;

namespace TestComisiones
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_obtenerVendedores()
        {
            // Arrange
            Sentencia sentencia = new Sentencia();

            // Act
            OdbcDataAdapter vendedoresAdapter = sentencia.funObtenerVendedores();
            DataTable dt = new DataTable();
            vendedoresAdapter.Fill(dt);

            // Assert
            Assert.IsTrue(dt.Rows.Count > 0, "No se obtuvieron vendedores.");
            Assert.IsTrue(dt.Columns.Contains("Pk_id_vendedor"));
            Assert.IsTrue(dt.Columns.Contains("NombreCompleto"));

        }

        [TestMethod]
        public void Test_CalculoDeComision()
        {
            // Arrange
            Frm_comisiones frm = new Frm_comisiones();
            frm.deVenta = 1000; // Total de ventas simuladas
            decimal porcentajeComision = 0.20m; // 20% de comisión
            frm.funEstablecerPorcentajeComision(porcentajeComision); // Establece el porcentaje de comisión

            // Act
            frm.funCalcularComision(); // Llama al método para calcular la comisión

            // Assert
            decimal expectedComision = 1000 * porcentajeComision; // Comision esperada: 200
            Assert.AreEqual(expectedComision, frm.deComisionCalculada, "El cálculo de la comisión no es correcto.");


        }


    }
}
