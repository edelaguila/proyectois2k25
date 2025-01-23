using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Vista_CierreContable;
using System.Windows.Forms;
using System;
using System.Data;

namespace CierreMensualTest
{
    [TestClass]
    public class CierreMensualTests
    {
        private CierreMensual cierreMensual;

        [TestInitialize]
        public void Setup()
        {
            cierreMensual = new CierreMensual();
        }

        [TestMethod]
        public void LlenarCboAnio_Test() //Añadir año actual a combobox
        {
            // Act
            cierreMensual.LlenarCboAnio();

            // Assert
            Assert.AreEqual(1, cierreMensual.Cbo_año.Items.Count);
            Assert.AreEqual(DateTime.Now.Year.ToString(), cierreMensual.Cbo_año.Items[0]);
        }

        [TestMethod]
        public void LlenarCboMes_Test()//Añadir meses a combobox
        {
            // Arrange
            cierreMensual.LlenarCboAnio(); // Primero llena el CboAnio
            cierreMensual.Cbo_año.SelectedIndex = 0; // Selecciona el año actual
            cierreMensual.LlenarCuentas(); // Asegura las cuentas para obtener los meses

            // Act
            cierreMensual.LlenarCboMes();

            // Assert
            Assert.IsTrue(cierreMensual.Cbo_mes.Items.Count > 0, "El ComboBox de meses debería tener elementos.");
        }

        [TestMethod]
        public void LlenarCuentas_Test()//Añadir cuentas a combobox
        {
            // Arrange
            // Configura cualquier dependencia necesaria, como la base de datos o un servicio
            cierreMensual.LlenarCuentas(); // Asumiendo que este método obtiene datos de cuentas

            // Act
            int cuentaCount = cierreMensual.Cbo_cuenta.Items.Count;

            // Assert
            Assert.IsTrue(cuentaCount > 0, "El ComboBox de cuentas debería tener elementos.");
        }



    }

}
