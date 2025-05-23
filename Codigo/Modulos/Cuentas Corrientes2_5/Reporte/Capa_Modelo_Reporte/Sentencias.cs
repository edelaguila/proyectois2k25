using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Reporte
{
    public class Sentencias
    {
        Conexion conexion = new Conexion();

        public OdbcDataAdapter queryProvConFecha(string idProveedor, DateTime fechaInicio, DateTime fechaFin)
        {
            string sql = "SELECT Pk_id_deuda, Fk_id_proveedor, Efecto_trans, Fk_id_factura, " +
                 "deuda_monto, deuda_fecha_inicio, deuda_fecha_vencimiento, " +
                 "deuda_descripcion, deuda_estado " +
                 "FROM Tbl_Deudas_Proveedores " +
                 "WHERE CAST(Fk_id_proveedor AS CHAR) LIKE '%" + idProveedor + "%' " +
                 "AND deuda_fecha_inicio BETWEEN '" + fechaInicio.ToString("yyyy-MM-dd") + "' AND '" + fechaFin.ToString("yyyy-MM-dd") + "';";

            return new OdbcDataAdapter(sql, conexion.conexion());
        }

        public OdbcDataAdapter queryClienteConFecha(string idCliente, DateTime fechaInicio, DateTime fechaFin)
        {
            string sql = "SELECT Pk_id_deuda, Fk_id_cliente, Fk_id_cobrador, Fk_id_factura, " +
                         "deuda_monto, deuda_fecha_inicio_deuda, deuda_fecha_vencimiento_deuda, " +
                         "deuda_descripcion_deuda, deuda_estado " +
                         "FROM Tbl_Deudas_Clientes " +
                         "WHERE CAST(Fk_id_cliente AS CHAR) LIKE '%" + idCliente + "%' " +
                         "AND deuda_fecha_inicio_deuda BETWEEN '" + fechaInicio.ToString("yyyy-MM-dd") + "' " +
                         "AND '" + fechaFin.ToString("yyyy-MM-dd") + "';";

            return new OdbcDataAdapter(sql, conexion.conexion());
        }
    }
}
