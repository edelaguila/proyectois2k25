using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_DeudasProveedores
{
    public class Sentencias
    {
        private readonly string connectionString = "Dsn=colchoneria";

        public OdbcDataAdapter ObtenerDeudas()
        {
            try
            {
                string query = @"SELECT 
                                d.Pk_id_deuda, 
                                d.Fk_id_proveedor, 
                                p.Prov_nombre, 
                                d.deuda_monto, 
                                d.deuda_fecha_inicio, 
                                d.deuda_fecha_vencimiento, 
                                d.deuda_descripcion,
                                d.deuda_estado, 
                                d.transaccion_tipo, 
                                d.Fk_id_factura 
                              FROM 
                                tbl_deudas_proveedores d
                              INNER JOIN 
                                tbl_proveedores p ON d.Fk_id_proveedor = p.Pk_prov_id
                              ORDER BY 
                                d.deuda_fecha_vencimiento";

                OdbcConnection conn = new OdbcConnection(connectionString);
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                return adapter;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener deudas: {ex.Message}");
            }
        }

        public int InsertarDeuda(string idDeuda, string idProveedor, string monto,
                         string fechaInicio, string fechaVencimiento, string descripcion,
                         string estado, string tipoTransaccion, string idFactura)
        {
            try
            {
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    // Insertar la deuda
                    string queryInsert = @"INSERT INTO tbl_deudas_proveedores 
                                   (Pk_id_deuda, Fk_id_proveedor, deuda_monto, deuda_fecha_inicio, 
                                    deuda_fecha_vencimiento, deuda_descripcion, deuda_estado, 
                                    transaccion_tipo, Fk_id_factura) 
                                   VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(queryInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idDeuda);
                        cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
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

                    // Si hay una factura relacionada, actualizar el saldo
                    if (!string.IsNullOrEmpty(idFactura) && idFactura != "0")
                    {
                        // Consultar el efecto de la transacción (desde tbl_transaccion_cuentas)
                        string efecto = "";
                        string queryEfecto = "SELECT tran_efecto FROM tbl_transaccion_cuentas WHERE tran_nombre = ?";
                        using (OdbcCommand cmdEfecto = new OdbcCommand(queryEfecto, conn))
                        {
                            cmdEfecto.Parameters.AddWithValue("@nombre", tipoTransaccion);
                            object result = cmdEfecto.ExecuteScalar();
                            if (result != null)
                                efecto = result.ToString();
                        }

                        // Actualizar el saldo según el efecto
                        string queryUpdateSaldo = @"UPDATE tbl_factura_proveedor 
                                            SET saldo = saldo " + (efecto == "Crédito" ? "+" : "-") + @" ? 
                                            WHERE Pk_id_FacturaProv = ?";

                        using (OdbcCommand cmdSaldo = new OdbcCommand(queryUpdateSaldo, conn))
                        {
                            cmdSaldo.Parameters.AddWithValue("@monto", Convert.ToDecimal(monto));
                            cmdSaldo.Parameters.AddWithValue("@idFactura", idFactura);
                            cmdSaldo.ExecuteNonQuery();
                        }

                        // Consultar el nuevo saldo
                        decimal nuevoSaldo = 0;
                        string querySaldo = "SELECT saldo FROM tbl_factura_proveedor WHERE Pk_id_FacturaProv = ?";
                        using (OdbcCommand cmdConsultaSaldo = new OdbcCommand(querySaldo, conn))
                        {
                            cmdConsultaSaldo.Parameters.AddWithValue("@idFactura", idFactura);
                            object result = cmdConsultaSaldo.ExecuteScalar();
                            if (result != null)
                                nuevoSaldo = Convert.ToDecimal(result);
                        }

                        // Si saldo es 0, actualizar estado de la deuda a 0
                        if (nuevoSaldo <= 0)
                        {
                            string updateEstado = "UPDATE tbl_deudas_proveedores SET deuda_estado = 0 WHERE Pk_id_deuda = ?";
                            using (OdbcCommand cmdEstado = new OdbcCommand(updateEstado, conn))
                            {
                                cmdEstado.Parameters.AddWithValue("@idDeuda", idDeuda);
                                cmdEstado.ExecuteNonQuery();
                            }
                        }
                    }

                    return 1; // Se insertó correctamente
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar deuda y actualizar saldo: {ex.Message}");
            }
        }

        //public int ActualizarDeuda(string idDeuda, string idProveedor, string monto,
        //                        string fechaInicio, string fechaVencimiento, string descripcion,
        //                        string estado, string tipoTransaccion, string idFactura)
        //{
        //    try
        //    {
        //        string query = @"UPDATE tbl_deudas_proveedores 
        //                       SET Fk_id_proveedor = ?, 
        //                           deuda_monto = ?, 
        //                           deuda_fecha_inicio = ?, 
        //                           deuda_fecha_vencimiento = ?, 
        //                           deuda_descripcion = ?, 
        //                           deuda_estado = ?, 
        //                           transaccion_tipo = ?, 
        //                           Fk_id_factura = ? 
        //                       WHERE Pk_id_deuda = ?";

        //        using (OdbcConnection conn = new OdbcConnection(connectionString))
        //        using (OdbcCommand cmd = new OdbcCommand(query, conn))
        //        {
        //            conn.Open();

        //            cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
        //            cmd.Parameters.AddWithValue("@monto", monto);
        //            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
        //            cmd.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
        //            cmd.Parameters.AddWithValue("@descripcion", descripcion);
        //            cmd.Parameters.AddWithValue("@estado", estado);
        //            cmd.Parameters.AddWithValue("@tipoTransaccion", tipoTransaccion);

        //            // Manejar el caso de que idFactura sea vacío o "0"
        //            if (string.IsNullOrEmpty(idFactura) || idFactura == "0")
        //            {
        //                cmd.Parameters.AddWithValue("@idFactura", DBNull.Value);
        //            }
        //            else
        //            {
        //                cmd.Parameters.AddWithValue("@idFactura", idFactura);
        //            }

        //            cmd.Parameters.AddWithValue("@id", idDeuda);

        //            return cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Error al actualizar deuda: {ex.Message}");
        //    }
        //}


        public int ActualizarDeuda(string idDeuda, string idProveedor, string monto,
                            string fechaInicio, string fechaVencimiento, string descripcion,
                            string estado, string tipoTransaccion, string idFactura)
        {
            try
            {
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                {
                    conn.Open();

                    // Obtener el monto anterior (y el idFactura anterior si lo deseas comparar)
                    string queryAnterior = "SELECT deuda_monto FROM tbl_deudas_proveedores WHERE Pk_id_deuda = ?";
                    decimal montoAnterior = 0;

                    using (OdbcCommand cmdAnterior = new OdbcCommand(queryAnterior, conn))
                    {
                        cmdAnterior.Parameters.AddWithValue("@idDeuda", idDeuda);
                        object result = cmdAnterior.ExecuteScalar();
                        if (result != null)
                            montoAnterior = Convert.ToDecimal(result);
                    }

                    // Actualizar la deuda
                    string query = @"UPDATE tbl_deudas_proveedores 
                           SET Fk_id_proveedor = ?, 
                               deuda_monto = ?, 
                               deuda_fecha_inicio = ?, 
                               deuda_fecha_vencimiento = ?, 
                               deuda_descripcion = ?, 
                               deuda_estado = ?, 
                               transaccion_tipo = ?, 
                               Fk_id_factura = ? 
                           WHERE Pk_id_deuda = ?";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
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
                        cmd.Parameters.AddWithValue("@id", idDeuda);

                        cmd.ExecuteNonQuery();
                    }

                    // Si hay una factura relacionada, ajustar el saldo
                    if (!string.IsNullOrEmpty(idFactura) && idFactura != "0")
                    {
                        // Obtener efecto del tipo de transacción
                        string efecto = "";
                        string queryEfecto = "SELECT tran_efecto FROM tbl_transaccion_cuentas WHERE tran_nombre = ?";
                        using (OdbcCommand cmdEfecto = new OdbcCommand(queryEfecto, conn))
                        {
                            cmdEfecto.Parameters.AddWithValue("@nombre", tipoTransaccion);
                            object result = cmdEfecto.ExecuteScalar();
                            if (result != null)
                                efecto = result.ToString();
                        }

                        decimal nuevoMonto = Convert.ToDecimal(monto);
                        decimal diferencia = nuevoMonto - montoAnterior;

                        string signo = (efecto == "Crédito") ? "+" : "-";
                        if (diferencia < 0)
                            signo = (efecto == "Crédito") ? "-" : "+";

                        string queryUpdateSaldo = $@"UPDATE tbl_factura_proveedor 
                                        SET saldo = saldo {signo} ? 
                                        WHERE Pk_id_FacturaProv = ?";

                        using (OdbcCommand cmdSaldo = new OdbcCommand(queryUpdateSaldo, conn))
                        {
                            cmdSaldo.Parameters.AddWithValue("@diferencia", Math.Abs(diferencia));
                            cmdSaldo.Parameters.AddWithValue("@idFactura", idFactura);
                            cmdSaldo.ExecuteNonQuery();
                        }

                        // Verificar nuevo saldo para cambiar estado si llega a 0
                        string querySaldo = "SELECT saldo FROM tbl_factura_proveedor WHERE Pk_id_FacturaProv = ?";
                        using (OdbcCommand cmdConsultaSaldo = new OdbcCommand(querySaldo, conn))
                        {
                            cmdConsultaSaldo.Parameters.AddWithValue("@idFactura", idFactura);
                            object result = cmdConsultaSaldo.ExecuteScalar();
                            if (result != null && Convert.ToDecimal(result) <= 0)
                            {
                                string updateEstado = "UPDATE tbl_deudas_proveedores SET deuda_estado = 0 WHERE Pk_id_deuda = ?";
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
                throw new Exception($"Error al actualizar deuda y saldo: {ex.Message}");
            }
        }

        public int EliminarDeuda(string idDeuda)
        {
            try
            {
                string query = "DELETE FROM tbl_deudas_proveedores WHERE Pk_id_deuda = ?";

                using (OdbcConnection conn = new OdbcConnection(connectionString))
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", idDeuda);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar deuda: {ex.Message}");
            }
        }

        public DataTable BuscarDeudas(string idDeuda, string proveedorId, string facturaId, string estado)
        {
            DataTable dt = new DataTable();
            List<string> filtros = new List<string>();

            if (!string.IsNullOrEmpty(idDeuda))
                filtros.Add($"Pk_id_deuda = '{idDeuda}'");
            if (!string.IsNullOrEmpty(proveedorId))
                filtros.Add($"Fk_id_proveedor = '{proveedorId}'");
            if (!string.IsNullOrEmpty(facturaId))
                filtros.Add($"Fk_id_factura = '{facturaId}'");
            if (!string.IsNullOrEmpty(estado))
                filtros.Add($"deuda_estado = '{estado}'");

            string whereClause = filtros.Count > 0 ? "WHERE " + string.Join(" AND ", filtros) : "";

            string sSql = $"SELECT * FROM tbl_deudas_proveedores {whereClause}";

            try
            {
                using (OdbcConnection conn = new OdbcConnection(connectionString))
                using (OdbcDataAdapter da = new OdbcDataAdapter(sSql, conn))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar deudas: {ex.Message}");
            }

            return dt;
        }

        public OdbcDataAdapter ObtenerFacturasPorProveedor(string idProveedor)
        {
            try
            {
                string query = "SELECT Pk_id_FacturaProv, Fk_numero_factura FROM tbl_factura_proveedor WHERE Fk_prov_id = ?";
                OdbcConnection conn = new OdbcConnection(connectionString);
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@idProveedor", idProveedor);

                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                return adapter;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener facturas: {ex.Message}");
            }
        }

        public OdbcDataAdapter ObtenerProveedores()
        {
            try
            {
                string query = "SELECT Pk_prov_id, Prov_nombre FROM tbl_proveedores";
                OdbcConnection conn = new OdbcConnection(connectionString);
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                return adapter;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener proveedores: {ex.Message}");
            }
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
                string query = "SELECT COUNT(*) FROM tbl_deudas_proveedores WHERE Pk_id_deuda = ?";

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

        public DataTable ObtenerDatosFactura(string idFactura)
        {
            try
            {
                string query = "SELECT saldo, Total_a_pagar FROM tbl_factura_proveedor WHERE Pk_id_FacturaProv = ?";
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

    }
}