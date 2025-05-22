using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_DeudasClientes
{
    public class Sentencias
    {
        private readonly string connectionString = "Dsn=colchoneria";

        public OdbcDataAdapter ObtenerDeudas()
        {
            var sql = @"
                SELECT dc.Pk_id_deuda,
                       dc.Fk_id_cliente,
                       c.Clientes_nombre   AS Cliente,
                       dc.Fk_id_cobrador,
                       cb.cobrador_nombre  AS Cobrador,
                       dc.deuda_monto,
                       dc.deuda_fecha_inicio_deuda,
                       dc.deuda_fecha_vencimiento_deuda,
                       dc.deuda_descripcion_deuda,
                       dc.deuda_estado,
                       dc.Fk_id_pago,
                       dc.Fk_id_factura
                FROM tbl_deudas_clientes dc
                INNER JOIN tbl_clientes          c  ON dc.Fk_id_cliente  = c.Pk_id_cliente
                INNER JOIN tbl_cobrador          cb ON dc.Fk_id_cobrador = cb.Pk_id_cobrador
                LEFT  JOIN tbl_transaccion_cuentas tc ON dc.Fk_id_pago     = tc.Pk_id_tran_cue
                ORDER BY dc.deuda_fecha_vencimiento_deuda";
            return new OdbcDataAdapter(sql, new OdbcConnection(connectionString));
        }

        public OdbcDataAdapter ObtenerClientes()
        {
            string query = "SELECT Pk_id_cliente, Clientes_nombre FROM tbl_clientes";
            return new OdbcDataAdapter(query, new OdbcConnection(connectionString));
        }

        public OdbcDataAdapter ObtenerCobradores()
        {
            string query = "SELECT Pk_id_cobrador, cobrador_nombre FROM tbl_cobrador WHERE estado = 1";
            return new OdbcDataAdapter(query, new OdbcConnection(connectionString));
        }

        public OdbcDataAdapter ObtenerFacturasPorCliente(string idCliente)
        {
            string query = @"SELECT Pk_id_FacturaCli, Fk_No_de_facV
                         FROM tbl_factura_cliente
                         WHERE id_clienteFact = ?";
            OdbcConnection conn = new OdbcConnection(connectionString);
            OdbcCommand cmd = new OdbcCommand(query, conn);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            return new OdbcDataAdapter(cmd);
        }

        public DataTable ObtenerDatosFactura(string idFactura)
        {
            try
            {
                string query = "SELECT saldo, Total_a_pagar FROM tbl_factura_cliente WHERE Pk_id_FacturaCli = ?";
                OdbcConnection conn = new OdbcConnection(connectionString);
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idFactura);

                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos de factura: {ex.Message}");
            }
        }

        public int InsertarDeuda(string idDeuda, string idCliente, string idCobrador, string monto,
                               string fechaInicio, string fechaVencimiento, string descripcion,
                               string estado, string tipoTransaccion, string idFactura)
        {
            try
            {
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    // 1) Insertar la deuda cliente
                    string queryInsert = @"
            INSERT INTO tbl_deudas_clientes
            (Pk_id_deuda, Fk_id_cliente, Fk_id_cobrador, deuda_monto, deuda_fecha_inicio_deuda,
             deuda_fecha_vencimiento_deuda, deuda_descripcion_deuda, deuda_estado,
             Fk_id_pago, Fk_id_factura)
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (var cmd = new OdbcCommand(queryInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idDeuda);
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@idCobrador", idCobrador);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@tipoTransaccion", tipoTransaccion);
                        if (string.IsNullOrEmpty(idFactura) || idFactura == "0")
                            cmd.Parameters.AddWithValue("@idFactura", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@idFactura", idFactura);
                        cmd.ExecuteNonQuery();
                    }

                    // 2) Si hay factura, ajustar su saldo según el efecto ('+' o '-')
                    if (!string.IsNullOrEmpty(idFactura) && idFactura != "0")
                    {
                        // Obtener el símbolo de efecto: '+' o '-'
                        string efecto = "";
                        string sqlEfecto = "SELECT tran_efecto FROM tbl_transaccion_cuentas WHERE tran_nombre = ?";
                        using (var cmdE = new OdbcCommand(sqlEfecto, conn))
                        {
                            cmdE.Parameters.AddWithValue("@nombre", tipoTransaccion);
                            var r = cmdE.ExecuteScalar();
                            if (r != null) efecto = r.ToString();
                        }

                        // Actualizar saldo en factura cliente
                        string sqlUpdate = $@"
                UPDATE tbl_factura_cliente
                SET saldo = saldo {efecto} ?
                WHERE Pk_id_FacturaCli = ?";
                        using (var cmdU = new OdbcCommand(sqlUpdate, conn))
                        {
                            cmdU.Parameters.AddWithValue("@monto", Convert.ToDecimal(monto));
                            cmdU.Parameters.AddWithValue("@idFactura", idFactura);
                            cmdU.ExecuteNonQuery();
                        }

                        // Verificar saldo para inactivar deuda si es 0 o menos
                        string sqlSaldo = "SELECT saldo FROM tbl_factura_cliente WHERE Pk_id_FacturaCli = ?";
                        decimal nuevoSaldo = 0;
                        using (var cmdS = new OdbcCommand(sqlSaldo, conn))
                        {
                            cmdS.Parameters.AddWithValue("@idFactura", idFactura);
                            var r2 = cmdS.ExecuteScalar();
                            if (r2 != null) nuevoSaldo = Convert.ToDecimal(r2);
                        }

                        if (nuevoSaldo <= 0)
                        {
                            string sqlEstado = @"
                    UPDATE tbl_deudas_clientes
                    SET deuda_estado = 0
                    WHERE Pk_id_deuda = ?";
                            using (var cmdE2 = new OdbcCommand(sqlEstado, conn))
                            {
                                cmdE2.Parameters.AddWithValue("@idDeuda", idDeuda);
                                cmdE2.ExecuteNonQuery();
                            }
                        }
                    }

                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar deuda cliente y actualizar saldo: {ex.Message}");
            }
        }

        public int ActualizarDeuda(string idDeuda, string idCliente, string idCobrador, string monto,
                                 string fechaInicio, string fechaVencimiento, string descripcion,
                                 string estado, string tipoTransaccion, string idFactura)
        {
            try
            {
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    // Obtener el monto anterior de la deuda cliente
                    string queryAnterior = "SELECT deuda_monto FROM tbl_deudas_clientes WHERE Pk_id_deuda = ?";
                    decimal montoAnterior = 0;
                    using (OdbcCommand cmdAnterior = new OdbcCommand(queryAnterior, conn))
                    {
                        cmdAnterior.Parameters.AddWithValue("@idDeuda", idDeuda);
                        object result = cmdAnterior.ExecuteScalar();
                        if (result != null)
                            montoAnterior = Convert.ToDecimal(result);
                    }

                    // Actualizar la deuda en la tabla
                    string query = @"UPDATE tbl_deudas_clientes 
                             SET Fk_id_cliente = ?, 
                                 Fk_id_cobrador = ?,
                                 deuda_monto = ?, 
                                 deuda_fecha_inicio_deuda = ?, 
                                 deuda_fecha_vencimiento_deuda = ?, 
                                 deuda_descripcion_deuda = ?, 
                                 deuda_estado = ?, 
                                 Fk_id_pago = ?, 
                                 Fk_id_factura = ? 
                             WHERE Pk_id_deuda = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@idCobrador", idCobrador);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@tipoTransaccion", tipoTransaccion);
                        if (string.IsNullOrEmpty(idFactura) || idFactura == "0")
                            cmd.Parameters.AddWithValue("@idFactura", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@idFactura", idFactura);
                        cmd.Parameters.AddWithValue("@idDeuda", idDeuda);
                        cmd.ExecuteNonQuery();
                    }

                    // Ajustar saldo de la factura relacionada si existe
                    if (!string.IsNullOrEmpty(idFactura) && idFactura != "0")
                    {
                        // Obtener el efecto real desde la tabla (esperado '+' o '-')
                        string efecto = "";
                        string queryEfecto = "SELECT tran_efecto FROM tbl_transaccion_cuentas WHERE tran_nombre = ?";
                        using (OdbcCommand cmdEfecto = new OdbcCommand(queryEfecto, conn))
                        {
                            cmdEfecto.Parameters.AddWithValue("@nombre", tipoTransaccion);
                            object result = cmdEfecto.ExecuteScalar();
                            if (result != null)
                                efecto = result.ToString();  // '+' o '-'
                        }

                        // Calcular diferencia de monto (nuevo - anterior)
                        decimal nuevoMonto = Convert.ToDecimal(monto);
                        decimal diferencia = nuevoMonto - montoAnterior;

                        // Si no hay diferencia, no actualices nada
                        if (diferencia != 0)
                        {
                            // Determinar signo real a aplicar
                            string signo = efecto;
                            if (diferencia < 0)
                                signo = (efecto == "+") ? "-" : "+";

                            string queryUpdateSaldo = $@"UPDATE tbl_factura_cliente 
                                                 SET saldo = saldo {signo} ? 
                                                 WHERE Pk_id_FacturaCli = ?";
                            using (OdbcCommand cmdSaldo = new OdbcCommand(queryUpdateSaldo, conn))
                            {
                                cmdSaldo.Parameters.AddWithValue("@diferencia", Math.Abs(diferencia));
                                cmdSaldo.Parameters.AddWithValue("@idFactura", idFactura);
                                cmdSaldo.ExecuteNonQuery();
                            }
                        }

                        // Consultar el nuevo saldo para verificar si es 0 o menos
                        string querySaldo = "SELECT saldo FROM tbl_factura_cliente WHERE Pk_id_FacturaCli = ?";
                        using (OdbcCommand cmdConsultaSaldo = new OdbcCommand(querySaldo, conn))
                        {
                            cmdConsultaSaldo.Parameters.AddWithValue("@idFactura", idFactura);
                            object result = cmdConsultaSaldo.ExecuteScalar();
                            if (result != null && Convert.ToDecimal(result) <= 0)
                            {
                                string updateEstado = "UPDATE tbl_deudas_clientes SET deuda_estado = 0 WHERE Pk_id_deuda = ?";
                                using (OdbcCommand cmdEstado = new OdbcCommand(updateEstado, conn))
                                {
                                    cmdEstado.Parameters.AddWithValue("@idDeuda", idDeuda);
                                    cmdEstado.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar deuda cliente y saldo: {ex.Message}");
            }
        }

        public int EliminarDeuda(string idDeuda)
        {
            try
            {
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    // 1. Obtener info de la deuda
                    string queryInfo = @"SELECT deuda_monto, Fk_id_pago, Fk_id_factura 
                                 FROM tbl_deudas_clientes 
                                 WHERE Pk_id_deuda = ?";
                    decimal monto = 0;
                    string tipoTrans = "";
                    string idFactura = "";

                    using (OdbcCommand cmd = new OdbcCommand(queryInfo, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idDeuda);
                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                monto = reader["deuda_monto"] != DBNull.Value ? Convert.ToDecimal(reader["deuda_monto"]) : 0;
                                tipoTrans = reader["Fk_id_pago"]?.ToString() ?? "";
                                idFactura = reader["Fk_id_factura"]?.ToString() ?? "";
                            }
                        }
                    }

                    // 2. Obtener el efecto de la transacción (esperado '+' o '-')
                    string efecto = "";
                    if (!string.IsNullOrEmpty(tipoTrans))
                    {
                        string queryEfecto = "SELECT tran_efecto FROM tbl_transaccion_cuentas WHERE tran_nombre = ?";
                        using (OdbcCommand cmd = new OdbcCommand(queryEfecto, conn))
                        {
                            cmd.Parameters.AddWithValue("?", tipoTrans);
                            object result = cmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                                efecto = result.ToString();
                        }
                    }

                    // 3. Revertir el saldo si hay factura asociada
                    if (!string.IsNullOrEmpty(idFactura) && monto != 0 && (efecto == "+" || efecto == "-"))
                    {
                        string signoReverso = (efecto == "+") ? "-" : "+";
                        string updateSaldo = $"UPDATE tbl_factura_cliente SET saldo = saldo {signoReverso} ? WHERE Pk_id_FacturaCli = ?";
                        using (OdbcCommand cmd = new OdbcCommand(updateSaldo, conn))
                        {
                            cmd.Parameters.AddWithValue("?", monto);
                            cmd.Parameters.AddWithValue("?", idFactura);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 4. Eliminar la deuda
                    string deleteQuery = "DELETE FROM tbl_deudas_clientes WHERE Pk_id_deuda = ?";
                    using (OdbcCommand cmd = new OdbcCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idDeuda);
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar deuda y ajustar saldo: {ex.Message}");
            }
        }

        public DataTable BuscarDeudas(string idDeuda, string idCliente, string idFactura, string estado)
        {
            string query = "SELECT * FROM tbl_deudas_clientes WHERE 1=1";
            if (!string.IsNullOrEmpty(idDeuda)) query += $" AND Pk_id_deuda = '{idDeuda}'";
            if (!string.IsNullOrEmpty(idCliente)) query += $" AND Fk_id_cliente = '{idCliente}'";
            if (!string.IsNullOrEmpty(idFactura)) query += $" AND Fk_id_factura = '{idFactura}'";
            if (!string.IsNullOrEmpty(estado)) query += $" AND deuda_estado = '{estado}'";

            DataTable dt = new DataTable();
            using (var conn = new OdbcConnection(connectionString))
            using (var adapter = new OdbcDataAdapter(query, conn))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public OdbcDataAdapter ObtenerTiposTransaccion()
        {
            try
            {
                string query = "SELECT tran_nombre FROM tbl_transaccion_cuentas WHERE estado = 1";
                OdbcConnection conn = new OdbcConnection(connectionString);
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                return adapter;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener tipos de transacción: {ex.Message}");
            }
        }

        public bool ExisteDeuda(string idDeuda)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tbl_deudas_clientes WHERE Pk_id_deuda = ?";

                using (OdbcConnection conn = new OdbcConnection(connectionString))
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", idDeuda);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar existencia de deuda: {ex.Message}");
            }
        }
    }
}
