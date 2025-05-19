using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using Capa_Modelo_Compras;
using Capa_Controlador_Compras;

[TestClass]
public class ControladorTests
{
    [TestMethod]
    public void ObtenerSucursales_RetornaListaCorrecta()
    {
        // Crear el mock para ISentencias
        var mockModelo = new Mock<ISentencias>();

        // Configurar el método ObtenerSucursales para que devuelva una lista de prueba
        mockModelo.Setup(m => m.ObtenerSucursales())
                 .Returns(new List<string> { "Sucursal1", "Sucursal2" });

        // Crear instancia del controlador usando el mock
        var controlador = new ControladorCompras(mockModelo.Object);

        // Ejecutar el método a probar
        var resultado = controlador.ObtenerListaSucursales();

        // Validar que la lista tenga los datos esperados
        Assert.AreEqual(2, resultado.Count);
        Assert.AreEqual("Sucursal1", resultado[0]);
        Assert.AreEqual("Sucursal2", resultado[1]);

        // Verificar que el método fue llamado exactamente una vez
        mockModelo.Verify(m => m.ObtenerSucursales(), Times.Once);
    }
}
