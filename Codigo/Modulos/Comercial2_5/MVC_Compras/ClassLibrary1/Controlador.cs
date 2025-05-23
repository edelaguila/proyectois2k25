using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using Capa_Modelo_Compras;
using System.Reflection;

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

        public DataTable Fun_MostrarMovimientosInventario2()
        {
            OdbcDataAdapter o_dataAdapter = _sentencias.Fun_DisplayMovimientos2();
            DataTable dt_tablaMovimientos = new DataTable();
            o_dataAdapter.Fill(dt_tablaMovimientos);
            return dt_tablaMovimientos;
        }

        public void Pro_EliminarCompra(int idCompra)
        {
            _sentencias.EliminarCompra(idCompra);
        }


        public void Pro_EditarCompra(int idCompra, int proveedor, DateTime fechaCompra, int bod, string factura, string compro, string pago, double sub, double imp, double total, string prod, double cant, double pre, string desc)
        {
            // Llamada al método EditarCompra con los parámetros que recibe el controlador
            _sentencias.ActualizarCompra(idCompra, proveedor, fechaCompra, bod, factura, compro, pago, sub, imp, total, prod, cant, pre, desc);
        }

        public void Pro_InsertarVendedor(int idVendedor, string nombre, string apellido, double sueldo, string direccion, string telefono, int fkEmpleado)
        {
            // Llama al método del modelo para insertar el vendedor
            _sentencias.InsertarVendedor(idVendedor, nombre, apellido, sueldo, direccion, telefono, fkEmpleado);
        }


        public void Pro_EliminarVendedor(int idVendedor)
        {
            _sentencias.EliminarVendedor(idVendedor);
        }


    }
}
