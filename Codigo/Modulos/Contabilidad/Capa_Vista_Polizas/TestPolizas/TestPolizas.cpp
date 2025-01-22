#include "pch.h"
#include "CppUnitTest.h"


using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace TestPolizas
{
	TEST_CLASS(TestPolizas)
	{
	public:

        /*[TestMethod]
        public void Setup()
        {
            mockControlador = new Mock<controladorPolizas>();
            formulario = new Poliza(); // Cambia esto al nombre real de tu formulario
        }*/

        /*[TestMethod]
        public void TestLlenarseCuentas()
        {
            // Arrange
            string tabla = "tbl_cuentas";
            string campo1 = "Pk_id_cuenta";
            string campo2 = "nombre_cuenta";

            // Simular el comportamiento del controlador
            string[] mockItems = new string[]{ "Activo", "Corriente", "Caja" };
            DataTable mockDataTable = new DataTable();
            mockDataTable.Columns.Add(campo1);
            mockDataTable.Columns.Add(campo2);
            mockDataTable.Rows.Add(1, "Activo");
            mockDataTable.Rows.Add(2, "Corriente");

            mockControlador.Setup(m = > m.itemsCuenta(tabla, campo1, campo2)).Returns(mockItems);
            mockControlador.Setup(m = > m.enviarCuentas(tabla, campo1, campo2)).Returns(mockDataTable);

            formulario.SetControlador(mockControlador.Object); // Método para establecer el controlador en el formulario

            // Act
            formulario.llenarseCuentas(tabla, campo1, campo2);

            // Assert
            Assert.AreEqual(2, formulario.cbCuenta.Items.Count); // Verificar que hay dos elementos
            //Assert.AreEqual("Activo", Poliza.cbCuenta.Items[0]);
            //Assert.AreEqual("Corriente", Poliza.cbCuenta.Items[1]);
        }

        [TestMethod]
        public void Polizas()
        {
            Poliza poliza;
            double basePrima = 100.0;
            double factorRiesgo = 1.2;

            double resultado = poliza.calcularPrima(basePrima, factorRiesgo);

            Assert::AreEqual(120.0, resultado, 0.001);
        }

        TEST_METHOD(TestCalcularMonto)
        {
            Poliza poliza;
            double prima = 120.0;
            double tasa = 0.2;

            double resultado = poliza.calcularMonto(prima, tasa);

            Assert::AreEqual(144.0, resultado, 0.001);
        }*/

	};
}
