using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using Capa_Modelo_Compras;

namespace Capa_Controlador_Compras
{
    public class ControladorCompras
    {
        private Sentencias _sentencias = new Sentencias();

        public List<string> ObtenerSucursales()
        {
            return _sentencias.ObtenerSucursales();
        }

        public List<Tuple<string, double>> ObtenerProductosConPrecio()
        {
            return _sentencias.ObtenerProductosConPrecio();
        }


        public List<string> ObtenerSucursales2()
        {
            return _sentencias.ObtenerSucursal();
        }




        public void Pro_RegistrarCompra(int proveedor, DateTime fechaCompra, int bod, string factura, string compro, string pago, double sub, double imp, double total, string prod, double cant, double pre, string desc)
        {
            // Llamada al método InsertarCompra con los parámetros que recibe el controlador
            _sentencias.InsertarCompra(proveedor, fechaCompra, bod, factura, compro, pago,sub , imp, total, prod,cant , pre,desc);
        }
        public DataTable Fun_MostrarMovimientosInventario()
        {
            OdbcDataAdapter o_dataAdapter = _sentencias.Fun_DisplayMovimientos();
            DataTable dt_tablaMovimientos = new DataTable();
            o_dataAdapter.Fill(dt_tablaMovimientos);
            return dt_tablaMovimientos;
        }




    }
}
