using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo_CPP
{
    public class Sentencias
    {
        //private string sTabla_transacciones = "tbl_transaccion_proveedor";
        //private Conexion conexion = new Conexion();

        //public OdbcDataAdapter DisplayTransaccion()
        //{
        //    string sSql = $"SELECT * FROM {sTabla_transacciones};";
        //    OdbcDataAdapter dataTable = new OdbcDataAdapter();
        //    try
        //    {
        //        dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al consultar la tabla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return dataTable;
        //}

        //public void registrarTransaccion(string id_transaccion, string id_proveedor, string id_pais, string fecha_transaccion,
        //                                 string tansaccion_cuenta, string tansaccion_cuotas, string transaccion_monto,
        //                                 string Fk_id_pago, string transaccion_tipo_moneda, string transaccion_serie,
        //                                 string transaccion_estado)
        //{
        //    string sCampos = "Pk_id_transaccion, Fk_id_proveedor, Fk_id_pais, fecha_transaccion, tansaccion_cuenta, tansaccion_cuotas, " +
        //                     "transaccion_monto, Fk_id_pago, transaccion_tipo_moneda, transaccion_serie, transaccion_estado";

        //    string sSql = $"INSERT INTO {sTabla_transacciones} ({sCampos}) VALUES " +
        //                  $"('{id_transaccion}', '{id_proveedor}', '{id_pais}', '{fecha_transaccion}', '{tansaccion_cuenta}', " +
        //                  $"'{tansaccion_cuotas}', '{transaccion_monto}', '{Fk_id_pago}', '{transaccion_tipo_moneda}', " +
        //                  $"'{transaccion_serie}', '{transaccion_estado}')";

        //    try
        //    {
        //        using (OdbcConnection conn = conexion.conexion())
        //        using (OdbcCommand cmd = new OdbcCommand(sSql, conn))
        //        {
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Transacción guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al guardar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void ActualizarTransaccion(string id_transaccion, string id_proveedor, string id_pais,
        //                          string fecha_transaccion, string cuenta, string cuotas,
        //                          string monto, string id_pago, string moneda,
        //                          string serie, string estado)
        //{
        //    try
        //    {
        //        string sSql = $"UPDATE tbl_transaccion_proveedor SET " +
        //                      $"Fk_id_proveedor = '{id_proveedor}', Fk_id_pais = '{id_pais}', " +
        //                      $"fecha_transaccion = '{fecha_transaccion}', tansaccion_cuenta = '{cuenta}', " +
        //                      $"tansaccion_cuotas = '{cuotas}', transaccion_monto = '{monto}', " +
        //                      $"Fk_id_pago = '{id_pago}', transaccion_tipo_moneda = '{moneda}', " +
        //                      $"transaccion_serie = '{serie}', transaccion_estado = '{estado}' " +
        //                      $"WHERE Pk_id_transaccion = '{id_transaccion}'";

        //        OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message + " \nNo se pudo actualizar el registro.");
        //    }
        //}

        //public void eliminarTransaccion(string idTransaccion)
        //{
        //    try
        //    {
        //        string sSql = "DELETE FROM tbl_transaccion_proveedor WHERE Pk_id_transaccion = ?;";
        //        using (OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion()))
        //        {
        //            cmd.Parameters.AddWithValue("@id", idTransaccion);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error al eliminar el registro: " + ex.Message);
        //    }
        //}

        //public OdbcDataAdapter buscarTransaccion(string campo, string valor)
        //{
        //    string sSql = $"SELECT * FROM tbl_transaccion_proveedor WHERE {campo} = ?;";
        //    OdbcDataAdapter dataAdapter = null;

        //    try
        //    {
        //        OdbcConnection conn = conexion.conexion(); // Conexión abierta aquí

        //        if (conn.State == System.Data.ConnectionState.Closed)
        //            conn.Open(); // Aseguramos que esté abierta

        //        OdbcCommand cmd = new OdbcCommand(sSql, conn);
        //        cmd.Parameters.AddWithValue("@valor", valor);

        //        dataAdapter = new OdbcDataAdapter(cmd); // Inicializamos el DataAdapter correctamente
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error en la búsqueda: " + ex.Message);
        //    }

        //    return dataAdapter;
        //}

        //// -----------------------------------------------------------------------------------------------------------------------------------------------------------



        //private string sTabla_deudas = "tbl_deudas_proveedores";

        //public OdbcDataAdapter DisplayDeudas()
        //{
        //    string sSql = $"SELECT * FROM {sTabla_deudas};";
        //    OdbcDataAdapter dataTable = new OdbcDataAdapter();
        //    try
        //    {
        //        dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al consultar la tabla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return dataTable;
        //}

        //public void RegistrarDeuda(string id_deuda, string id_proveedor, string id_pago,
        //                           string monto, string fecha_inicio,
        //                           string fecha_vencimiento, string descripcion, string estado)
        //{
        //    string sCampos = "Pk_id_deuda, Fk_id_proveedor, Fk_id_pago, deuda_monto, " +
        //                     "deuda_fecha_inicio, deuda_fecha_vencimiento, deuda_descripcion, deuda_estado";

        //    string sSql = $"INSERT INTO {sTabla_deudas} ({sCampos}) VALUES " +
        //                  $"('{id_deuda}', '{id_proveedor}', '{id_pago}', '{monto}', " +
        //                  $"'{fecha_inicio}', '{fecha_vencimiento}', " +
        //                  $"'{descripcion}', '{estado}')";

        //    try
        //    {
        //        using (OdbcConnection conn = conexion.conexion())
        //        using (OdbcCommand cmd = new OdbcCommand(sSql, conn))
        //        {
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Deuda guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al guardar la deuda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void ActualizarDeuda(string id_deuda, string id_proveedor, string id_pago,
        //                             string monto, string fecha_inicio,
        //                             string fecha_vencimiento, string descripcion, string estado)
        //{
        //    try
        //    {
        //        string sSql = $"UPDATE {sTabla_deudas} SET " +
        //                      $"Fk_id_proveedor = '{id_proveedor}', Fk_id_pago = '{id_pago}', " +
        //                      $"deuda_monto = '{monto}', deuda_fecha_inicio = '{fecha_inicio}', " +
        //                      $"deuda_fecha_vencimiento = '{fecha_vencimiento}', " +
        //                      $"deuda_descripcion = '{descripcion}', deuda_estado = '{estado}' " +
        //                      $"WHERE Pk_id_deuda = '{id_deuda}'";

        //        OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message + " \nNo se pudo actualizar el registro.");
        //    }
        //}

        //public void EliminarDeuda(string idDeuda)
        //{
        //    try
        //    {
        //        string sSql = "DELETE FROM tbl_deudas_proveedores WHERE Pk_id_deuda = ?;";
        //        using (OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion()))
        //        {
        //            cmd.Parameters.AddWithValue("@id", idDeuda);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error al eliminar el registro: " + ex.Message);
        //    }
        //}

        //public OdbcDataAdapter BuscarDeuda(string campo, string valor)
        //{
        //    string sSql = $"SELECT * FROM {sTabla_deudas} WHERE {campo} = ?;";
        //    OdbcDataAdapter dataAdapter = null;

        //    try
        //    {
        //        OdbcConnection conn = conexion.conexion(); // Conexión abierta aquí

        //        if (conn.State == System.Data.ConnectionState.Closed)
        //            conn.Open(); // Aseguramos que esté abierta

        //        OdbcCommand cmd = new OdbcCommand(sSql, conn);
        //        cmd.Parameters.AddWithValue("@valor", valor);

        //        dataAdapter = new OdbcDataAdapter(cmd); // Inicializamos el DataAdapter correctamente
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error en la búsqueda: " + ex.Message);
        //    }

        //    return dataAdapter;
        //}
    }
}
