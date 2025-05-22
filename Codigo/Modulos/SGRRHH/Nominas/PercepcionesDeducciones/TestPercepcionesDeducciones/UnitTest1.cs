using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using Capa_Modelo_PercepcionesDeducciones;

namespace TestPercepcionesDeducciones
{
    [TestClass]
    public class TestPercepcionesDeducciones
    {
        private Sentencias _sentencias;

        [TestInitialize]
        public void Setup()
        {
            _sentencias = new Sentencias();
        }

        [TestMethod]
        public void ObtenerPercepciones_DebeRetornarDataAdapter()
        {
            // Arrange
            DataTable dt = new DataTable();

            // Act
            var adapter = _sentencias.ObtenerPercepciones();

            // Verify adapter is not null before filling
            Assert.IsNotNull(adapter, "El DataAdapter no debe ser null");

            adapter.Fill(dt);

            // Assert
            Assert.IsTrue(dt.Columns.Count > 0, "La tabla debe tener columnas");
            Assert.IsTrue(dt.Rows.Count >= 0, "La tabla debe poder contener filas");
        }

        [TestMethod]
        public void ObtenerDeducciones_DebeRetornarDataAdapter()
        {
            // Arrange
            DataTable dt = new DataTable();

            // Act
            var adapter = _sentencias.ObtenerDeducciones();

            Assert.IsNotNull(adapter, "El DataAdapter no debe ser null");

            adapter.Fill(dt);

            // Assert
            Assert.IsTrue(dt.Columns.Count > 0, "La tabla debe tener columnas");
            Assert.IsTrue(dt.Rows.Count >= 0, "La tabla debe poder contener filas");
        }

        [TestMethod]
        public void ValidarEstructuraPercepciones_DebeTenerColumnasCorrectas()
        {
            // Arrange
            DataTable dt = new DataTable();

            // Act
            var adapter = _sentencias.ObtenerPercepciones();
            Assert.IsNotNull(adapter, "El DataAdapter no debe ser null");

            adapter.Fill(dt);

            // Assert con mensajes descriptivos
            Assert.IsTrue(dt.Columns.Contains("Nombre"), "Falta la columna 'Nombre'");
            Assert.IsTrue(dt.Columns.Contains("Apellido"), "Falta la columna 'Apellido'");
            Assert.IsTrue(dt.Columns.Contains("Concepto"), "Falta la columna 'Concepto'");
            Assert.IsTrue(dt.Columns.Contains("Tipo"), "Falta la columna 'Tipo'");
            Assert.IsTrue(dt.Columns.Contains("Cantidad"), "Falta la columna 'Cantidad'");
        }
    }
}