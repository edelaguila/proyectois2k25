using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Capa_Modelo_Presupuesto;

namespace TestPresupuesto
{

    public class MockTextBox
    {
        public string Text { get; set; }
        public string Name { get; set; }
    }

    public class MockDataGridViewCell
    {
        public object Value { get; set; }
    }

    public class MockDataGridViewRow
    {
        private Dictionary<string, MockDataGridViewCell> _cells;

        public MockDataGridViewRow(Dictionary<string, object> cellValues)
        {
            _cells = new Dictionary<string, MockDataGridViewCell>();
            foreach (var cellValue in cellValues)
            {
                _cells[cellValue.Key] = new MockDataGridViewCell { Value = cellValue.Value };
            }
        }

        public Dictionary<string, MockDataGridViewCell> Cells => _cells; // Cambio a propiedad indexada
    }

    public class PresupuestoService
    {
        public List<MockDataGridViewRow> Dgv_presupuesto { get; set; }
        private List<MockTextBox> _textBoxes;

        public PresupuestoService(List<MockTextBox> textBoxes)
        {
            _textBoxes = textBoxes;
        }

        public void IncrementarTodosLosMeses(decimal dePorcentaje)
        {
            foreach (var vMes in _textBoxes)
            {
                decimal deValorActual = Convert.ToDecimal(vMes.Text);
                decimal deIncremento = deValorActual * (dePorcentaje / 100);
                vMes.Text = (deValorActual + deIncremento).ToString("F2");
            }
        }

        public void IncrementarMesEspecifico(decimal dePorcentaje, string sNombreMes)
        {
            MockTextBox txtMesSeleccionado = _textBoxes.Find(tb => tb.Name == sNombreMes);

            if (txtMesSeleccionado != null)
            {
                decimal deValorActual = Convert.ToDecimal(txtMesSeleccionado.Text);
                decimal deIncremento = deValorActual * (dePorcentaje / 100);
                txtMesSeleccionado.Text = (deValorActual + deIncremento).ToString("F2");
            }
        }

        public void SumarColumna(string sNombreColumna, MockLabel txtResultado)
        {
            decimal deSuma = 0;

            foreach (var DgvrFila in Dgv_presupuesto)
            {
                if (DgvrFila.Cells[sNombreColumna].Value != null &&
                    decimal.TryParse(DgvrFila.Cells[sNombreColumna].Value.ToString(), out decimal deValor))
                {
                    deSuma += deValor;
                }
            }
            txtResultado.Text = $"{deSuma}";
        }
    }

    public class MockLabel
    {
        public string Text { get; set; }
    }

    [TestClass]
    public class PresupuestoServiceTests
    {
        private List<MockTextBox> _textBoxes;
        private PresupuestoService _presupuestoService;

        [TestInitialize]
        public void TestInitialize()
        {
            _textBoxes = new List<MockTextBox>
            {
                new MockTextBox { Text = "100.00", Name = "Enero" },
                new MockTextBox { Text = "200.00", Name = "Febrero" },
                new MockTextBox { Text = "300.00", Name = "Marzo" }
            };

            _presupuestoService = new PresupuestoService(_textBoxes)
            {
                Dgv_presupuesto = new List<MockDataGridViewRow>
                {
                    new MockDataGridViewRow(new Dictionary<string, object> { { "Mes", 100.00m }, { "Otro", 50.00m } }),
                    new MockDataGridViewRow(new Dictionary<string, object> { { "Mes", 200.00m }, { "Otro", 75.00m } }),
                    new MockDataGridViewRow(new Dictionary<string, object> { { "Mes", 300.00m }, { "Otro", 25.00m } })
                }
            };
        }

        [TestMethod]
        public void IncrementarTodosLosMeses_AplicaIncrementoCorrectamente()
        {
            var presupuestoService = new PresupuestoService(_textBoxes);
            decimal porcentajeIncremento = 10;

            presupuestoService.IncrementarTodosLosMeses(porcentajeIncremento);

            Assert.AreEqual("110.00", _textBoxes[0].Text, "Incremento incorrecto en el primer TextBox.");
            Assert.AreEqual("220.00", _textBoxes[1].Text, "Incremento incorrecto en el segundo TextBox.");
            Assert.AreEqual("330.00", _textBoxes[2].Text, "Incremento incorrecto en el tercer TextBox.");
        }

        [TestMethod]
        public void IncrementarMesEspecifico_AplicaIncrementoCorrectamente()
        {
            decimal porcentajeIncremento = 20;
            string mes = "Febrero";

            _presupuestoService.IncrementarMesEspecifico(porcentajeIncremento, mes);

            Assert.AreEqual("240.00", _textBoxes.Find(tb => tb.Name == mes).Text, "Incremento incorrecto en el TextBox del mes especificado.");
        }

        [TestMethod]
        public void SumarColumna_CalculaSumaCorrectamente()
        {
            string columna = "Mes";
            var resultadoLabel = new MockLabel();

            _presupuestoService.SumarColumna(columna, resultadoLabel);

            Assert.AreEqual("600.00", resultadoLabel.Text, "La suma de la columna 'Mes' es incorrecta.");
        }
    }

    //Simulacion
    [TestClass]
    public class SentenciaTests
    {
        Sentencia _sentencia = new Sentencia();

        [TestMethod]
        public void EliminarPresupuestoSimulado_EliminaCorrectamente()
        {
            
            // Arrange
            int iIdPresupuesto = 1;
            bool presupuestoEliminado;

            // Act
            _sentencia.EliminarPresupuestoSimulado(iIdPresupuesto, out presupuestoEliminado);

            // Assert
            Assert.IsTrue(presupuestoEliminado, "El presupuesto debería haberse eliminado.");
        }

        [TestMethod]
        public void VerificarCuentasSimulado_DevuelveTrue_SiHayCuentas()
        {
            // Act
            bool hayCuentas = _sentencia.VerificarCuentasSimulado();

            // Assert
            Assert.IsTrue(hayCuentas, "Debería haber al menos una cuenta.");
        }

        [TestMethod]
        public void ActualizarEstadosPresupuestosSimulado_ActualizaCorrectamente()
        {
            // Arrange
            int registrosActualizados;

            // Act
            bool actualizacionExitosa = _sentencia.ActualizarEstadosPresupuestosSimulado(out registrosActualizados);

            // Assert
            Assert.IsTrue(actualizacionExitosa, "La actualización debería ser exitosa.");
            Assert.AreEqual(5, registrosActualizados, "Deberían haberse actualizado 5 registros.");
        }
    }
}

