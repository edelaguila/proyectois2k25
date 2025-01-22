using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Capa_Vista_EstadosFinancieros;

namespace TestEstadosFinancieros
{
    [TestClass]
    public class TestEstadosFinancieros
    {
        private EstadosFinancieros form;

        // Propiedad TestContext para salida en pruebas
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            // Inicializa el formulario antes de cada prueba
            form = new EstadosFinancieros();
        }

        [TestMethod]
        public void Test_Ruta_Balance()
        {
            string expectedPath = Path.Combine(form.sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Balance.rpt");
            TestContext.WriteLine("Ruta generada para el reporte Balance: " + expectedPath);
            bool fileExists = File.Exists(expectedPath);
            Assert.IsTrue(fileExists, $"El archivo de reporte Balance.rpt no se encuentra en la ruta esperada. Ruta buscada: {expectedPath}");
        }

        [TestMethod]
        public void Test_Ruta_FlujoDeEfectivo()
        {
            string expectedPath = Path.Combine(form.sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "FlujoDeEfectivo.rpt");
            TestContext.WriteLine("Ruta generada para el reporte FlujoDeEfectivo: " + expectedPath);
            bool fileExists = File.Exists(expectedPath);
            Assert.IsTrue(fileExists, $"El archivo de reporte FlujoDeEfectivo.rpt no se encuentra en la ruta esperada. Ruta buscada: {expectedPath}");
        }

        [TestMethod]
        public void Test_Ruta_EstadoDeResultados()
        {
            string expectedPath = Path.Combine(form.sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "EstadoDeResultados.rpt");
            TestContext.WriteLine("Ruta generada para el reporte EstadoDeResultados: " + expectedPath);
            bool fileExists = File.Exists(expectedPath);
            Assert.IsTrue(fileExists, $"El archivo de reporte EstadoDeResultados.rpt no se encuentra en la ruta esperada. Ruta buscada: {expectedPath}");
        }

        [TestMethod]
        public void Test_Ruta_BalanceHistorico()
        {
            string expectedPath = Path.Combine(form.sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "BalanceHistorico.rpt");
            TestContext.WriteLine("Ruta generada para el reporte BalanceHistorico: " + expectedPath);
            bool fileExists = File.Exists(expectedPath);
            Assert.IsTrue(fileExists, $"El archivo de reporte BalanceHistorico.rpt no se encuentra en la ruta esperada. Ruta buscada: {expectedPath}");
        }

        [TestMethod]
        public void Test_Ruta_EstadoDeResultadosHistorico()
        {
            string expectedPath = Path.Combine(form.sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "EstadoDeResultadosHistorico.rpt");
            TestContext.WriteLine("Ruta generada para el reporte EstadoDeResultadosHistorico: " + expectedPath);
            bool fileExists = File.Exists(expectedPath);
            Assert.IsTrue(fileExists, $"El archivo de reporte EstadoDeResultadosHistorico.rpt no se encuentra en la ruta esperada. Ruta buscada: {expectedPath}");
        }

        [TestMethod]
        public void Test_Ruta_FlujoDeEfectivoHistorico()
        {
            string expectedPath = Path.Combine(form.sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "FlujoDeEfectivoHistorico.rpt");
            TestContext.WriteLine("Ruta generada para el reporte FlujoDeEfectivoHistorico: " + expectedPath);
            bool fileExists = File.Exists(expectedPath);
            Assert.IsTrue(fileExists, $"El archivo de reporte FlujoDeEfectivoHistorico.rpt no se encuentra en la ruta esperada. Ruta buscada: {expectedPath}");
        }

        [TestMethod]
        public void Test_Ruta_Ayuda()
        {
            string expectedPath = Path.Combine(form.sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "AyudaEstadosFinancieros.chm");
            TestContext.WriteLine("Ruta generada para la ayuda: " + expectedPath);
            bool fileExists = File.Exists(expectedPath);
            Assert.IsTrue(fileExists, $"El archivo de ayuda AyudaEstadosFinancieros.chm no se encuentra en la ruta esperada. Ruta buscada: {expectedPath}");
        }
    }
}
