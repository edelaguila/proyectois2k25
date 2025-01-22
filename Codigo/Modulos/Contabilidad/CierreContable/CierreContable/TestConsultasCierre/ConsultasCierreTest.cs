using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Vista_CierreContable;
using System.Windows.Forms;
using System;
using System.Data;

namespace TestConsultasCierre
{
    [TestClass]
    public class ConsultasCierreTest
    {
        [TestMethod]
        public void Totales_Test()
        {
            // Inicializar los DataGridView y TextBox de prueba
            DataGridView dgvDebe = new DataGridView();
            DataGridView dgvHaber = new DataGridView();
            TextBox txtTotD = new TextBox();
            TextBox txtTotH = new TextBox();

            // Añadir columnas vacías para que "Monto" esté en la posición 4
            for (int i = 0; i < 4; i++)
            {
                dgvDebe.Columns.Add($"Columna{i}", $"Columna{i}");
                dgvHaber.Columns.Add($"Columna{i}", $"Columna{i}");
            }

            // Añadir la columna "Monto" en el índice 4
            dgvDebe.Columns.Add("Monto", "Monto");
            dgvDebe.Rows.Add(null, null, null, null, "100");
            dgvDebe.Rows.Add(null, null, null, null, "200");

            dgvHaber.Columns.Add("Monto", "Monto");
            dgvHaber.Rows.Add(null, null, null, null, "150");
            dgvHaber.Rows.Add(null, null, null, null, "250");

            // Ejecutar el método
            ConsultasCierre consultasCierre = new ConsultasCierre();
            consultasCierre.Totales(dgvDebe, dgvHaber, txtTotD, txtTotH);

            // Verificar el resultado esperado
            Assert.AreEqual("300.00", txtTotD.Text); // Verifica que el total en txtTotD sea correcto
            Assert.AreEqual("400.00", txtTotH.Text); // Verifica que el total en txtTotH sea correcto
        }


        [TestMethod]
        public void LlenarCuentas_Test()
        {
            // Arrange
            var form = new ConsultasCierre();
            form.LlenarCuentas();

            // Act
            int cuentaItems = form.Cbo_cuenta.Items.Count;

            // Assert
            Assert.IsTrue(cuentaItems > 0, "El ComboBox de cuentas no se llenó correctamente.");
            Assert.AreEqual("Todas las cuentas", form.Cbo_cuenta.Items[0].ToString());
        }

        [TestMethod]
        public void LlenarCboAnio_Test()
        {
            // Arrange
            var form = new ConsultasCierre();

            // Act
            form.LlenarCboAnio();
            int cantidadAnios = form.Cbo_consultaAño.Items.Count;

            // Assert
            Assert.AreEqual(11, cantidadAnios, "El ComboBox de años no tiene los próximos 10 años.");
            Assert.AreEqual(DateTime.Now.Year.ToString(), form.Cbo_consultaAño.Items[0].ToString());
        }

        [TestMethod]
        public void ConsultarCierreG_Test()//Si no hay resultados, notifica al usuario
        {
            // Arrange
            var form = new ConsultasCierre();
            int periodo = 1;
            string anio = "2024";
            string cuenta = "NoExistente";

            // Usar DataTables simuladas
            DataTable dtDebe = new DataTable();
            DataTable dtHaber = new DataTable();
            form.Dgv_cargos.DataSource = dtDebe;
            form.Dgv_abonos.DataSource = dtHaber;

            // Act
            form.ConsultarCierreG(periodo, anio, cuenta, form.Dgv_cargos, form.Dgv_abonos);

            // Assert
            Assert.AreEqual(0, form.Dgv_cargos.Rows.Count, "DataGridView de debe no está vacío.");
            Assert.AreEqual(0, form.Dgv_abonos.Rows.Count, "DataGridView de haber no está vacío.");
        }


    }
}
