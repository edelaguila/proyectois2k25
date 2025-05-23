using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Modelo_ListaPrecios;

namespace Test_ListaPrecios
{
    [TestClass]
    public class Test_ListaPrecios
    {
        [TestMethod]
        public void test_insert_lista_encabezado()
        {
            // Arrange
            int iCodigoEncabezado = 10; // cambiar según el de la lista ya creada que quieras verificar
            int iClasificacion = 5;       // ID de clasificación (tipo de lista que tiene la lista creada segpun el códigoEncabezado)
            DateTime sFecha = DateTime.Now;
            string sEstado = "Activo"; //puede ser activo o inactivo
            var claseLista = new sentencia(); //clase donde está proinsertarlistaEncabezado

            try
            {
                // Act
                claseLista.proinsertarlistaEncabezado(iCodigoEncabezado, iClasificacion, sFecha, sEstado);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.Fail($"La inserción del encabezado falló con la excepción: {ex.Message}");
            }
        }

        [TestMethod]
        public void test_insert_lista_detalle()
        {
            // Arrange
            int iCodigoEncabezado = 10; // ID del encabezado creado previamente
            int iCodigoProducto = 7;      // ID de un producto existente/agregado dentro de la lista con el encabezado designado
            decimal dPrecioLista = 125.99m;
            var claseLista = new sentencia(); // clase donde está proinsertarlistaDetalle

            try
            {
                // Act
                claseLista.proinsertarlistaDetalle(iCodigoEncabezado, iCodigoProducto, dPrecioLista);
            }
            catch (Exception ex)
            {
                // Assert
                Assert.Fail($"La inserción del detalle falló con la excepción: {ex.Message}");
            }
        }
    }
}
