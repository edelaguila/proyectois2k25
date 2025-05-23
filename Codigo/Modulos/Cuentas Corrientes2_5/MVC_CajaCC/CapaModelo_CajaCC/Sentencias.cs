using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_CajaCC
{
    public class Sentencias
    {
        private Conexion conexion = new Conexion();

        public bool InsertarCaja(int? idCliente, int? idProveedor, int? idDeuda, int? idDeudaProveedor,
            decimal saldoRestante, int estado, string fechaRegistro)
        {
            try
            {
                string sql = @"INSERT INTO Tbl_caja_general 
                    (Fk_id_cliente, Fk_id_proveedor, Fk_id_deuda, Fk_id_deuda_proveedor,
                    saldo_restante, estado, fecha_registro) 
                    VALUES (?, ?, ?, ?, ?, ?, ?)";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Fk_id_cliente", (object)idCliente ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fk_id_proveedor", (object)idProveedor ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fk_id_deuda", (object)idDeuda ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fk_id_deuda_proveedor", (object)idDeudaProveedor ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@saldo_restante", saldoRestante);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    DateTime fechaValida;
                    if (!DateTime.TryParse(fechaRegistro, out fechaValida))
                    {
                        fechaValida = DateTime.Now;
                    }

                    cmd.Parameters.AddWithValue("@fecha_registro", fechaValida.ToString("yyyy-MM-dd"));

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en InsertarCaja: " + ex.Message);
                return false;
            }
        }

        public bool ModificarCaja(int idCaja, int? idCliente, int? idProveedor, int? idDeuda, int? idDeudaProveedor,
            decimal saldoRestante, int estado, string fechaRegistro)
        {
            try
            {
                string sql = @"UPDATE Tbl_caja_general SET 
                    Fk_id_cliente = ?, Fk_id_proveedor = ?, Fk_id_deuda = ?, Fk_id_deuda_proveedor = ?,
                    saldo_restante = ?, estado = ?, fecha_registro = ? 
                    WHERE Pk_id_caja = ?";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Fk_id_cliente", (object)idCliente ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fk_id_proveedor", (object)idProveedor ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fk_id_deuda", (object)idDeuda ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fk_id_deuda_proveedor", (object)idDeudaProveedor ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@saldo_restante", saldoRestante);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    DateTime fechaValida;
                    if (!DateTime.TryParse(fechaRegistro, out fechaValida))
                    {
                        fechaValida = DateTime.Now;
                    }

                    cmd.Parameters.AddWithValue("@fecha_registro", fechaValida.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Pk_id_caja", idCaja);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ModificarCaja: " + ex.Message);
                return false;
            }
        }

        public bool EliminarCaja(int idCaja)
        {
            try
            {
                string sql = "DELETE FROM Tbl_caja_general WHERE Pk_id_caja = ?";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Pk_id_caja", idCaja);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en EliminarCaja: " + ex.Message);
                return false;
            }
        }

        public DataTable ObtenerCajas()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Tbl_caja_general";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerCajas: " + ex.Message);
            }
            return dt;
        }

        public DataTable ObtenerCajaPorId(int idCaja)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Tbl_caja_general WHERE Pk_id_caja = ?";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Pk_id_caja", idCaja);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerCajaPorId: " + ex.Message);
            }
            return dt;
        }

        public DataTable MostrarCaja()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT c.Pk_id_caja as idCaja, 
                             c.Fk_id_cliente as idCliente, 
                             c.Fk_id_proveedor as idProveedor,
                             c.Fk_id_deuda as idDeuda,
                             c.Fk_id_deuda_proveedor as idDeudaProveedor,
                             c.saldo_restante as saldoRestante, 
                             c.estado, 
                             c.fecha_registro as fechaRegistro
                      FROM Tbl_caja_general c";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en MostrarCaja: " + ex.Message);
            }
            return dt;
        }

        public DataTable ObtenerClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT Pk_id_cliente AS id_cliente, Clientes_nombre AS nombre_cliente FROM Tbl_clientes";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerClientes: " + ex.Message);
            }
            return dt;
        }

        public DataTable ObtenerProveedores()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Pk_prov_id AS id_proveedor, Prov_nombre AS nombre_proveedor FROM Tbl_proveedores";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerProveedores: " + ex.Message);
            }
            return dt;
        }

        // Método para obtener deudas de clientes
        public DataTable ObtenerDeudas()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Pk_id_deuda AS id_deuda, deuda_descripcion_deuda AS descripcion_deuda FROM Tbl_Deudas_Clientes";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerDeudas: " + ex.Message);
            }
            return dt;
        }

        // Nuevo método para obtener deudas de proveedores
        public DataTable ObtenerDeudasProveedores()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Pk_id_deuda AS id_deuda, deuda_descripcion AS deuda_descripcion FROM Tbl_deudas_proveedores";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerDeudasProveedores: " + ex.Message);
            }
            return dt;
        }

        public DataTable BuscarCaja(string cliente, string proveedor, string estado, string fecha)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT * FROM Tbl_caja_general c
                           LEFT JOIN Tbl_clientes cl ON c.Fk_id_cliente = cl.Pk_id_cliente 
                           LEFT JOIN Tbl_proveedores p ON c.Fk_id_proveedor = p.Pk_prov_id
                           WHERE (cl.Clientes_nombre LIKE ? OR ? = '' OR c.Fk_id_cliente IS NULL) 
                             AND (p.Prov_nombre LIKE ? OR ? = '' OR c.Fk_id_proveedor IS NULL) 
                             AND (c.estado = ? OR ? = '') 
                             AND (c.fecha_registro LIKE ? OR ? = '')";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cliente1", "%" + cliente + "%");
                    cmd.Parameters.AddWithValue("@cliente2", cliente);
                    cmd.Parameters.AddWithValue("@proveedor1", "%" + proveedor + "%");
                    cmd.Parameters.AddWithValue("@proveedor2", proveedor);
                    cmd.Parameters.AddWithValue("@estado1", estado);
                    cmd.Parameters.AddWithValue("@estado2", estado);
                    cmd.Parameters.AddWithValue("@fecha1", "%" + fecha + "%");
                    cmd.Parameters.AddWithValue("@fecha2", fecha);

                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BuscarCaja: " + ex.Message);
            }
            return dt;
        }
    }
}
