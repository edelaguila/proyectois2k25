using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Vista_Logistica;
using System.Windows.Forms;

namespace TestEnlace
{
    [TestClass]
    public class PruebaEnlace
    {
        public Frm_Polizas formulario;

        [TestInitialize]
        public void Inicializar()
        {
            formulario = new Frm_Polizas();

            // Configuración inicial de los controles (simulación de formulario)
            formulario.Dgv_Polizas = new DataGridView();
            formulario.Txt_CargoTot = new Label();
            formulario.Txt_AbonoTot = new Label();
            formulario.Txt_concepto = new TextBox();
            formulario.Txt_valor = new TextBox();
            formulario.Cbo_Cuenta = new ComboBox();
            formulario.Cbo_operacion = new ComboBox();
            formulario.Cbo_tipopoliza = new ComboBox();
        }

        [TestMethod]
        public void TestSumarColumnas_CalculaTotalCorrecto()
        {
            // Configuración de datos simulados
            formulario.Dgv_Polizas.Columns.Add("Codigo", "Codigo");
            formulario.Dgv_Polizas.Columns.Add("Cuenta", "Cuenta");
            formulario.Dgv_Polizas.Columns.Add("Cargo", "Cargo");
            formulario.Dgv_Polizas.Columns.Add("Abono", "Abono");

            formulario.Dgv_Polizas.Rows.Add("1", "Cuenta1", "100.00", "");
            formulario.Dgv_Polizas.Rows.Add("2", "Cuenta2", "", "50.00");
            formulario.Dgv_Polizas.Rows.Add("3", "Cuenta3", "30.00", "");

            // Ejecutar el método de prueba
            formulario.SumarColumnas();

            // Verificar resultados
            Assert.AreEqual("130.00", formulario.Txt_CargoTot.Text); // Suma de columna Cargo
            Assert.AreEqual("50.00", formulario.Txt_AbonoTot.Text);  // Suma de columna Abono
        }

        [TestMethod]
        public void TestLimpiarCamposEnc_LimpiaCorrectamenteCamposEncabezado()
        {
            // Configuración inicial de los campos
            formulario.Cbo_tipopoliza.Items.Add("Item1");
            formulario.Cbo_tipopoliza.SelectedIndex = 0;
            formulario.Txt_concepto.Text = "Prueba de concepto";
            formulario.Txt_CargoTot.Text = "100.00";
            formulario.Txt_AbonoTot.Text = "50.00";

            // Ejecutar el método
            formulario.LimpiarCamposEnc();

            // Verificar resultados
            Assert.AreEqual(0, formulario.Cbo_tipopoliza.SelectedIndex);
            Assert.AreEqual("", formulario.Txt_concepto.Text);
            Assert.AreEqual("00.00", formulario.Txt_CargoTot.Text);
            Assert.AreEqual("00.00", formulario.Txt_AbonoTot.Text);
        }

        [TestMethod]
        public void TestLimpiarCamposDetelle_LimpiaCorrectamenteCamposDetalle()
        {
            // Configuración inicial de los campos
            formulario.Txt_valor.Text = "123.45";
            formulario.Cbo_Cuenta.Items.Add("Cuenta1");
            formulario.Cbo_Cuenta.SelectedIndex = 0;
            formulario.Cbo_operacion.Items.Add("Operacion1");
            formulario.Cbo_operacion.SelectedIndex = 0;

            // Ejecutar el método
            formulario.LimpiarCamposDetelle();

            // Verificar resultados
            Assert.AreEqual("", formulario.Txt_valor.Text);
            Assert.AreEqual(0, formulario.Cbo_Cuenta.SelectedIndex);
            Assert.AreEqual(0, formulario.Cbo_operacion.SelectedIndex);
        }
    }
}
