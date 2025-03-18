using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;
using System.Data.Odbc;
using System.Data;

namespace Capa_Controlador
{
    public class Cls_Controlador
    {
        private Cls_Sentencias g_pSentencias;

        public Cls_Controlador()
        {
            g_pSentencias = new Cls_Sentencias();
        }

        // Lógica del módulo de mantenimiento de vehículo
        public void Pro_RealizarSolicitudMantenimiento(string s_nombreSolicitante, string s_tipoMantenimiento, string s_componenteAfectado, string d_fecha, string s_responsableAsignado, string s_codigoErrorProblema, string s_estadoMantenimiento, string s_tiempoEstimado, int i_idMovimiento)
        {
            g_pSentencias.Pro_InsertarSolicitudMantenimiento(s_nombreSolicitante, s_tipoMantenimiento, s_componenteAfectado, d_fecha, s_responsableAsignado, s_codigoErrorProblema, s_estadoMantenimiento, s_tiempoEstimado, i_idMovimiento);
        }

        public DataTable Fun_MostrarSolicitudesMantenimiento()
        {
            OdbcDataAdapter o_dataAdapter = g_pSentencias.Fun_DisplaySolicitudesMantenimiento();
            DataTable dt_tablaSolicitudes = new DataTable();
            o_dataAdapter.Fill(dt_tablaSolicitudes);
            return dt_tablaSolicitudes;
        }

        public void Pro_ModificarSolicitudMantenimiento(int i_idMantenimiento, string s_nombreSolicitante, string s_tipoMantenimiento, string s_componenteAfectado, string d_fecha, string s_responsableAsignado, string s_codigoErrorProblema, string s_estadoMantenimiento, string s_tiempoEstimado, int i_idMovimiento)
        {
            g_pSentencias.Pro_ModificarSolicitudMantenimiento(i_idMantenimiento, s_nombreSolicitante, s_tipoMantenimiento, s_componenteAfectado, d_fecha, s_responsableAsignado, s_codigoErrorProblema, s_estadoMantenimiento, s_tiempoEstimado, i_idMantenimiento);
        }

        public void Pro_EliminarSolicitudMantenimiento(int i_idMantenimiento)
        {
            g_pSentencias.Pro_EliminarSolicitudMantenimiento(i_idMantenimiento);
        }

        public void Pro_CrearPDFMantenimiento(int i_idMantenimiento)
        {
            g_pSentencias.Pro_GenerarPDFMantenimiento(i_idMantenimiento);
        }

        // Lógica del módulo de movimiento de inventario
        public void Pro_RealizarMovimientoInventario(int i_estado, int i_fkIdProducto, int i_fkIdStock, int i_fkIdLocales)
        {
            g_pSentencias.Pro_InsertarMovimientoInventario(i_estado, i_fkIdProducto, i_fkIdStock, i_fkIdLocales);
        }

        public DataTable Fun_ObtenerProductos()
        {
            return g_pSentencias.Fun_LlenarCmb("tbl_productos", "pk_id_producto");
        }

        public DataTable Fun_ObtenerStocks()
        {
            return g_pSentencias.Fun_LlenarCmb("Tbl_TrasladoProductos", "Pk_id_TrasladoProductos");
        }

        public DataTable Fun_ObtenerLocales()
        {
            return g_pSentencias.Fun_LlenarCmb("tbl_locales", "pk_id_local");
        }

        public DataTable Fun_MostrarMovimientosInventario()
        {
            OdbcDataAdapter o_dataAdapter = g_pSentencias.Fun_DisplayMovimientos();
            DataTable dt_tablaMovimientos = new DataTable();
            o_dataAdapter.Fill(dt_tablaMovimientos);
            return dt_tablaMovimientos;
        }

        public void Pro_ModificarMovimientoInventario(int i_idMovimiento, int i_estado, int i_fkIdProducto, int i_fkIdStock, int i_fkIdLocales)
        {
            g_pSentencias.Pro_ModificarMovimientoInventario(i_idMovimiento, i_estado, i_fkIdProducto, i_fkIdStock, i_fkIdLocales);
        }

        public void Pro_EliminarMovimiento(int i_idMovimiento)
        {
            g_pSentencias.Pro_EliminarMovimientoInventario(i_idMovimiento);
        }

        public void Pro_GenerarPDFMovimientoInventario(int i_idMovimiento)
        {
            g_pSentencias.Pro_GenerarPDFMovimiento(i_idMovimiento);
        }
    }
}
