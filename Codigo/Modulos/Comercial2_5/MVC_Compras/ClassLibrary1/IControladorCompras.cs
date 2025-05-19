using System;
using System.Collections.Generic;
using System.Data;

namespace Capa_Controlador_Compras
{
    public interface IControladorCompras
    {
        List<Tuple<string, double>> ObtenerProductosConPrecio();
        List<string> ObtenerSucursales2();
        void Pro_RegistrarCompra(int proveedorId, DateTime fecha, int bodegaId, string numeroFactura, string tipoComprobante, string formaPago, double subtotal, double impuestos, double total, string producto, double cantidad, double precio, string desc);
        DataTable Fun_MostrarMovimientosInventario();
    }
}
