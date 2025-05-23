using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo_Cuentas_Corrientes
{
    public class Sentencias
    {
        Conexion conexion = new Conexion();


        //DEUDAS CLIENTES
        string sTabla_Deuda = "Tbl_Deudas_Clientes";

        public OdbcDataAdapter DisplayDeudas()// método que obtiene el contenido de la tabla VENDEDORES
        {
            string sSql = "SELECT Pk_id_deuda, Fk_id_cliente, Fk_id_cobrador, Fk_id_factura, deuda_monto, deuda_fecha_inicio_deuda, deuda_fecha_vencimiento_deuda, " +
                "deuda_descripcion_deuda, deuda_estado FROM  " + sTabla_Deuda + " WHERE Pk_id_deuda IS NOT NULL AND Pk_id_deuda != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }
            return dataTable;
        }

        public void registrarDeuda(string Pk_id_deuda, string Fk_id_cliente, string Fk_id_cobrador, string sFk_idfactura,
            string monto_deuda, DateTime fecha_inicio_deuda, DateTime fecha_vencimiento_deuda, string descripcion_deuda, string estado_deuda)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = " Pk_id_deuda, Fk_id_cliente, Fk_id_cobrador, Fk_id_factura, deuda_monto," +
                    "deuda_fecha_inicio_deuda, deuda_fecha_vencimiento_deuda, deuda_descripcion_deuda, deuda_estado";
                string sSql = "INSERT INTO " + sTabla_Deuda + " (" + sCampos + ") VALUES ('" + Pk_id_deuda + "', '" + Fk_id_cliente + "', '"
                    + Fk_id_cobrador + "', '" + sFk_idfactura + "','" + monto_deuda + "', '" + fecha_inicio_deuda + "', '" + fecha_vencimiento_deuda +
                    "', '" + descripcion_deuda + "', '" + estado_deuda + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_Deuda);
            }
        }

        public bool ModificarTransaccion(int idDeuda, int idCliente, int idCobrador, int idFactura, string monto, DateTime fechaI,
            DateTime fechaV, string descripcion, int estado)
        {
            try
            {

                string sql = "UPDATE Tbl_Deudas SET " +
                             "Fk_id_cliente = ?, Fk_id_cobrador = ?, Fk_id_factura = ?, " +
                             "deuda_monto = ?, deuda_fecha_inicio_deuda = ?, deuda_fecha_vencimiento_deuda = ?, " +
                             "deuda_descripcion_deuda = ?, deuda_estado = ? " +
                             "WHERE Pk_id_deuda = ?";

                using (OdbcConnection conn = conexion.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@idCobrador", idCobrador);
                        cmd.Parameters.AddWithValue("@idFactura", idFactura);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.Add(new OdbcParameter("@fechaI", OdbcType.Date)).Value = fechaI;
                        cmd.Parameters.Add(new OdbcParameter("@fechaV", OdbcType.Date)).Value = fechaV;
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@idDeuda", idDeuda);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas == 0)
                        {
                            Console.WriteLine("No se modificó ninguna fila. Verifique si el ID de la deuda existe.");
                            return false;
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ModificarTransaccion: " + ex.Message);
                return false;
            }
        }



        public OdbcDataAdapter queryDeuda(string sQuery)
        {
            string sql = "SELECT Pk_id_deuda, Fk_id_cliente, Fk_id_cobrador, Fk_id_factura, deuda_monto, deuda_fecha_inicio_deuda, deuda_fecha_vencimiento_deuda, " +
                    "deuda_descripcion_deuda, deuda_estado  FROM "
                + sTabla_Deuda + " WHERE Pk_id_deuda LIKE '%" + sQuery + "%' OR Pk_id_deuda LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }
        public int getMaxIdDeudas()
        {
            int iPk_id_deuda = 0;
            string sSql = "SELECT max(Pk_id_deuda) FROM " + sTabla_Deuda + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_deuda = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_Deuda);
            }
            return iPk_id_deuda;
        }
        
       /*public List<string> getEfecto()
        {
            string sQuery = "SELECT tran_efecto, estado FROM Tbl_transaccion_cuentas;";
            List<string> efectoCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado"].ToString().Equals("1"))
                    {
                        string sCodigoCliente = row["tran_efecto"].ToString();
                        efectoCodes.Add(sCodigoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return efectoCodes;
        }*/
        public List<string> getClientesd()
        {
            string sQuery = "SELECT Pk_id_cliente, estado FROM Tbl_clientes;";
            List<string> clientesCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado"].ToString().Equals("1"))
                    {
                        string sCodigoCliente = row["Pk_id_cliente"].ToString();
                        clientesCodes.Add(sCodigoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return clientesCodes;
        }
        public List<string> getCobrador()
        {
            string sQuery = "SELECT Pk_id_cobrador, estado FROM Tbl_cobrador;";
            List<string> cobradorCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado"].ToString().Equals("1"))
                    {
                        string sCodigoCobrador = row["Pk_id_cobrador"].ToString();
                        cobradorCodes.Add(sCodigoCobrador);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return cobradorCodes;
        }
       /* public List<string> getTransaccion()
        {
            string sQuery = "SELECT Pk_id_tran_cue, estado FROM Tbl_transaccion_cuentas;";
            List<string> transaccionCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado"].ToString().Equals("1"))
                    {
                        string sCodigoTrans = row["Pk_id_tran_cue"].ToString();
                        transaccionCodes.Add(sCodigoTrans);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return transaccionCodes;
        }
        public List<string> getTipoTrans()
        {
            string sQuery = "SELECT tran_nombre, estado FROM Tbl_transaccion_cuentas;";
            List<string> transaccionCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado"].ToString().Equals("1"))
                    {
                        string sCodigoTrans = row["tran_nombre"].ToString();
                        transaccionCodes.Add(sCodigoTrans);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return transaccionCodes;
        }*/
        public List<string> getFactura()
        {
            string sQuery = "SELECT Pk_id_factura FROM Tbl_factura;";
            List<string> transaccionCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                        string sCodigoTrans = row["Pk_id_factura"].ToString();
                        transaccionCodes.Add(sCodigoTrans);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return transaccionCodes;
        }

        public void ActualizarDeuda(string Pk_id_deuda, string Fk_id_cliente, string Fk_id_cobrador, string sFk_idfactura,
            string monto_deuda, DateTime fechaI, DateTime fechav, string descripcion, string deuda)
        {
            try
            {
                string sSql = $"UPDATE Tbl_Deudas_Clientes SET " +
                              $"Fk_id_cliente = '{Fk_id_cliente}', Fk_id_cobrador = '{Fk_id_cobrador}', " +
                              
                              $"Fk_id_factura = '{sFk_idfactura}', deuda_monto = '{monto_deuda}', " +
                              $"deuda_fecha_inicio_deuda = '{fechaI}', " +
                              $"deuda_fecha_vencimiento_deuda = '{fechav}', deuda_descripcion_deuda = '{descripcion}', " +
                              $"deuda_estado = '{deuda}',"+
                              $"WHERE Pk_id_deuda = '{Pk_id_deuda}'";

                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo actualizar el registro.");
            }
        }

        public void eliminarDeuda(string sId_deuda)
        {
            try
            {
                string sSql = "delete from " + sTabla_Deuda + " where Pk_id_deuda = " + sId_deuda + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_deuda + " en la tabla " + sTabla_Deuda);
            }
        }
        

        ////PROVEEDOR
        //DEUDAS PROVEEDORES

        string sTabla_Proveedor = "Tbl_Deudas_Proveedores";

        public OdbcDataAdapter DisplayDeudasP()
        {
            string sSql = "SELECT Pk_id_deuda, Fk_id_proveedor, transaccion_tipo, Efecto_trans, Fk_id_factura, deuda_monto, deuda_fecha_inicio, deuda_fecha_vencimiento, " +
                "deuda_descripcion, deuda_estado FROM  "
                + sTabla_Proveedor + " WHERE Pk_id_deuda IS NOT NULL AND Pk_id_deuda != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Proveedor);
            }
            return dataTable;
        }

        public void registrarDeudaProveedor(string Pk_id_deuda, string Fk_id_prov, string sTipo_trans, string sEfecto, string sFk_idfactura,
            string monto_deuda, string fecha_inicio, string fecha_vencimiento, string descripcion_deuda, string estado_deuda)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {

                string sCampos = " Pk_id_deuda, Fk_id_proveedor, transaccion_tipo, Efecto_trans, Fk_id_factura, deuda_monto," +
                    "deuda_fecha_inicio, deuda_fecha_vencimiento, deuda_descripcion, deuda_estado";
                string sSql = "INSERT INTO " + sTabla_Proveedor + " (" + sCampos + ") VALUES ('" + Pk_id_deuda + "', '" + Fk_id_prov + "', '"
                    + sTipo_trans + "','" + sEfecto + "','" + sFk_idfactura + "','" + monto_deuda + "', '" + fecha_inicio + "', '" + fecha_vencimiento +
                    "', '" + descripcion_deuda + "', '" + estado_deuda + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_Proveedor);
            }
        }

        public void ActualizarDeudaP(string Pk_id_deuda, string Fk_id_proveedor, string sTipo_trans, string sEfecto, string sFk_idfactura,
            string monto_deuda, string fechaI, string fechav, string descripcion, string deuda)
        {
            try
            {
                string sSql = $"UPDATE Tbl_Deudas_proveedores SET " +
                              $"Fk_id_proveedor = '{Fk_id_proveedor}', " +
                              $"transaccion_tipo = '{sTipo_trans}', Efecto_trans = '{sEfecto}', " +
                              $"Fk_id_factura = '{sFk_idfactura}', deuda_monto = '{monto_deuda}', " +
                              $"deuda_fecha_inicio = '{fechaI}', " +
                              $"deuda_fecha_vencimiento = '{fechav}', deuda_descripcion = '{descripcion}', " +
                              $"deuda_estado = '{deuda}'" +
                              $"WHERE Pk_id_deuda = '{Pk_id_deuda}'";

                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo actualizar el registro.");
            }
        }

        public OdbcDataAdapter queryProv(string sQuery)
        {
            string sql = "SELECT  Pk_id_deuda, Fk_id_proveedor, transaccion_tipo, Efecto_trans, Fk_id_factura, deuda_monto, deuda_fecha_inicio, deuda_fecha_vencimiento, " +
                    "deuda_descripcion, deuda_estado FROM "
                + sTabla_Proveedor + " WHERE Pk_id_deuda LIKE '%" + sQuery + "%' OR Pk_id_deuda LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public List<string> getEfectoP()
        {
            string sQuery = "SELECT tran_efecto, estado FROM Tbl_transaccion_cuentas;";
            List<string> efectoCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado"].ToString().Equals("1"))
                    {
                        string sCodigoCliente = row["tran_efecto"].ToString();
                        efectoCodes.Add(sCodigoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Proveedor);
            }

            return efectoCodes;
        }
        public List<string> getProveedor()
        {
            string sQuery = "SELECT Pk_prov_id, estado FROM Tbl_proveedores;";
            List<string> proveedorCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado"].ToString().Equals("1"))
                    {
                        string sCodigoProv = row["Pk_prov_id"].ToString();
                        proveedorCodes.Add(sCodigoProv);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Proveedor);
            }

            return proveedorCodes;
        }
        public List<string> getTipoTransP()
        {
            string sQuery = "SELECT tran_nombre, estado FROM Tbl_transaccion_cuentas;";
            List<string> transaccionCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado"].ToString().Equals("1"))
                    {
                        string sCodigoTrans = row["tran_nombre"].ToString();
                        transaccionCodes.Add(sCodigoTrans);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Proveedor);
            }

            return transaccionCodes;
        }
        public List<string> getFacturaP()
        {
            string sQuery = "SELECT Pk_id_factura FROM Tbl_factura;";
            List<string> transaccionCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    string sCodigoTrans = row["Pk_id_factura"].ToString();
                    transaccionCodes.Add(sCodigoTrans);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Proveedor);
            }

            return transaccionCodes;
        }
        public int getMaxIdDeudasP()
        {
            int iPk_id_deuda = 0;
            string sSql = "SELECT max(Pk_id_deuda) FROM " + sTabla_Proveedor + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_deuda = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_Proveedor);
            }
            return iPk_id_deuda;
        }


        public void eliminarProv(string sId_deuda)
        {
            try
            {
                string sSql = "delete from " + sTabla_Proveedor + " where Pk_id_deuda = " + sId_deuda + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_deuda + " en la tabla " + sTabla_Proveedor);
            }
        }

        //////////////POLIZAS///////////////////////

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------
        public string[] llenarCmbCuentas(string tabla, string campo1, string campo2)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }

            return Campos;
        }

        public DataTable obtenerCuentas(string tabla, string campo1, string campo2)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open(); // Asegúrate de abrir la conexión
                    }

                    string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  ;";
                    OdbcCommand command = new OdbcCommand(sql, con);
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // Verificar si la tabla tiene datos
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, muestra el mensaje de error
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                return null;
            }
        }

        // ---------------------------------- COMBO BOX TIPO POLIZA ----------------------------------

        public string[] llenarCmbTP(string tabla, string campo1, string campo2)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }

            return Campos;
        }

        public DataTable obtenerTP(string tabla, string campo1, string campo2)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open(); // Asegúrate de abrir la conexión
                    }

                    string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  ;";
                    OdbcCommand command = new OdbcCommand(sql, con);
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // Verificar si la tabla tiene datos
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, muestra el mensaje de error
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                return null;
            }
        }

        // ---------------------------------- COMBO BOX OPERACION ----------------------------------

        public string[] llenarCmbOP(string tabla, string campo1, string campo2)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }

            return Campos;
        }

        public DataTable obtenerOP(string tabla, string campo1, string campo2)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open(); // Asegúrate de abrir la conexión
                    }

                    string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  ;";
                    OdbcCommand command = new OdbcCommand(sql, con);
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // Verificar si la tabla tiene datos
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Si hay un error, muestra el mensaje de error
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                return null;
            }
        }

        public void ActulizarCuentas(int idCuenta, string tipoOperacion, decimal valor)
        {
            //Obtener las variables a llenar
            decimal cargoMesActual = 0;
            decimal abonoMesActual = 0;
            decimal saldoActual = 0;
            int? idCuentaEnlace = null;  // Aquí se lee la cuanta padre

            string consulta = "SELECT cargo_mes, abono_mes, saldo_act, Pk_id_cuenta_enlace FROM tbl_cuentas WHERE Pk_id_cuenta = ?";
            try
            {
                using (OdbcCommand cmdSelect = new OdbcCommand(consulta, conexion.conexion()))
                {
                    cmdSelect.Parameters.AddWithValue("@Pk_id_cuenta", idCuenta);

                    using (OdbcDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener los valores actuales de la base de datos
                            cargoMesActual = Convert.ToDecimal(reader["cargo_mes"]);
                            abonoMesActual = Convert.ToDecimal(reader["abono_mes"]);
                            saldoActual = Convert.ToDecimal(reader["saldo_act"]);

                            //Obtiene la cuenta padre 
                            idCuentaEnlace = reader["Pk_id_cuenta_enlace"] != DBNull.Value
                                ? (int?)Convert.ToInt32(reader["Pk_id_cuenta_enlace"])
                                : null;
                        }
                    }
                }

                //Condicion para sumar cargo o en abono.
                if (tipoOperacion == "Cargo")
                {
                    cargoMesActual += valor; // Sumar el valor al cargo mensual
                }
                else if (tipoOperacion == "Abono")
                {
                    abonoMesActual += valor; // Sumar el valor al abono mensual
                }

                //Calculo del saldo actual
                saldoActual = cargoMesActual - abonoMesActual;

                //Integrar los datos dentro de la base de datos.
                string updateQuery = @"UPDATE tbl_cuentas SET cargo_mes = ?, abono_mes = ?, saldo_act = ? WHERE Pk_id_cuenta = ?";

                using (OdbcCommand cmdUpdate = new OdbcCommand(updateQuery, conexion.conexion()))
                {
                    cmdUpdate.Parameters.AddWithValue("@cargo_mes", cargoMesActual);
                    cmdUpdate.Parameters.AddWithValue("@abono_mes", abonoMesActual);
                    cmdUpdate.Parameters.AddWithValue("@saldo_act", saldoActual);
                    cmdUpdate.Parameters.AddWithValue("@Pk_id_cuenta", idCuenta);

                    cmdUpdate.ExecuteNonQuery();
                }

                //AQUI COMIENZA LA MAGIA -  Si en caso la variable idCuentaEnlace no es nulo repite esta función
                if (idCuentaEnlace.HasValue)
                {
                    ActulizarCuentas(idCuentaEnlace.Value, tipoOperacion, valor);
                }

                ActualizarHistorico(idCuenta, valor, tipoOperacion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void LlenarEncabezado(string fechaSeleccionada, string concepto, int tipoPoli)
        {
            int idtipopoliza = tipoPoli; // ID del tipo de póliza
            string fecha = fechaSeleccionada; // Fecha de la póliza
            string cnp = concepto; // Concepto de la póliza

            using (OdbcConnection con = conexion.conexion())
            {
                // Se crea una transacción
                using (OdbcTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Insertar en tbl_polizaencabezado y obtener el ID UNA SOLA VEZ
                        string insertEncabezado = @"INSERT INTO tbl_polizaencabezado(fechaPoliza, concepto, Pk_id_tipopoliza) VALUES(?, ?, ?) ON DUPLICATE KEY UPDATE concepto = VALUES(concepto);";

                        using (OdbcCommand cmdEncabezado = new OdbcCommand(insertEncabezado, con, transaction))
                        {
                            /*cmdEncabezado.Parameters.Add("@fechaPoliza", OdbcType.VarChar).Value = fecha;
                            cmdEncabezado.Parameters.Add("@concepto", OdbcType.VarChar).Value = cnp;
                            cmdEncabezado.Parameters.Add("@Pk_id_tipopoliza", OdbcType.Int).Value = idtipopoliza;*/

                            cmdEncabezado.Parameters.AddWithValue("@fechaPoliza", fecha);
                            cmdEncabezado.Parameters.AddWithValue("@concepto", cnp);
                            cmdEncabezado.Parameters.AddWithValue("@Pk_id_tipopoliza", idtipopoliza);

                            // Ejecutar la inserción del encabezado SOLO UNA VEZ
                            cmdEncabezado.ExecuteNonQuery();
                        }

                        // Confirmar la transacción si todo sale bien
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revertir la transacción en caso de error
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                    }
                }
            }

        }

        public void LlenarDetalle(string fechaSeleccionada, string concepto, List<object[]> detalles)
        {
            int nuevoIdEncabezado;
            string cnp = concepto; // Concepto de la póliza

            using (OdbcConnection con = conexion.conexion())
            {
                // Se crea una transacción
                using (OdbcTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Obtener el último ID insertado
                        string lastIdQuery = @"SELECT Pk_id_polizaencabezado FROM tbl_polizaencabezado WHERE concepto = ? ORDER BY Pk_id_polizaencabezado DESC LIMIT 1;";

                        using (OdbcCommand cmdLastId = new OdbcCommand(lastIdQuery, con, transaction))
                        {
                            cmdLastId.Parameters.AddWithValue("?", cnp);
                            nuevoIdEncabezado = Convert.ToInt32(cmdLastId.ExecuteScalar());
                        }

                        // Insertar en tbl_polizadetalle usando el ID del encabezado
                        string insertDetalle = @"INSERT INTO tbl_polizadetalle (Pk_id_polizaencabezado, Pk_id_cuenta, Pk_id_tipooperacion, valor) VALUES (?, ?, ?, ?)";
                        string checkDetalleExists = @"SELECT COUNT(*) FROM tbl_polizadetalle WHERE Pk_id_polizaencabezado = ? AND Pk_id_cuenta = ? AND Pk_id_tipooperacion = ?";

                        foreach (var detalle in detalles)
                        {
                            // Verificar si ya existe el registro en tbl_polizadetalle
                            using (OdbcCommand cmdCheck = new OdbcCommand(checkDetalleExists, con, transaction))
                            {
                                cmdCheck.Parameters.AddWithValue("?", nuevoIdEncabezado);
                                cmdCheck.Parameters.AddWithValue("?", detalle[0]);
                                cmdCheck.Parameters.AddWithValue("?", detalle[1]);

                                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                                if (count > 0)
                                {
                                    // Si ya existe, simplemente continúa a la siguiente iteración
                                    continue; // Salta a la siguiente iteración si ya existe
                                }
                            }

                            // Si no existe, proceder a insertar
                            using (OdbcCommand cmdDetalle = new OdbcCommand(insertDetalle, con, transaction))
                            {
                                cmdDetalle.Parameters.AddWithValue("?", nuevoIdEncabezado);
                                cmdDetalle.Parameters.AddWithValue("?", detalle[0]);
                                cmdDetalle.Parameters.AddWithValue("?", detalle[1]);
                                cmdDetalle.Parameters.AddWithValue("?", detalle[2]);

                                // Ejecutar la inserción
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Revertir la transacción en caso de error
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                    }
                }
            }


        }

        public void ActualizarHistorico(int idCuenta, decimal val, string tipoOperacion)
        {
            int mesActual = DateTime.Now.Month;
            int anioActual = DateTime.Now.Year;

            int CuentaID = idCuenta;
            decimal valor = val;

            // Variables para almacenar los valores actuales
            decimal cargoMesHistorico = 0;
            decimal abonoMesHistorico = 0;
            decimal saldoHistorico = 0;
            bool existeHistorico = false;

            // Paso 1: Consultar los valores actuales del histórico para esa cuenta, mes y año
            string selectHistorico = @"SELECT cargo_mes, abono_mes, saldo_act 
                               FROM tbl_historico_cuentas 
                               WHERE Pk_id_cuenta = ? AND mes = ? AND anio = ?";

            try
            {
                using (OdbcCommand cmdHistorico = new OdbcCommand(selectHistorico, conexion.conexion()))
                {
                    cmdHistorico.Parameters.AddWithValue("@Pk_id_cuenta", CuentaID);
                    cmdHistorico.Parameters.AddWithValue("@mes", mesActual);
                    cmdHistorico.Parameters.AddWithValue("@anio", anioActual);

                    using (OdbcDataReader readerHistorico = cmdHistorico.ExecuteReader())
                    {
                        if (readerHistorico.Read())
                        {
                            // Si existe un registro, obtener los valores
                            cargoMesHistorico = Convert.ToDecimal(readerHistorico["cargo_mes"]);
                            abonoMesHistorico = Convert.ToDecimal(readerHistorico["abono_mes"]);
                            saldoHistorico = Convert.ToDecimal(readerHistorico["saldo_act"]);
                            existeHistorico = true;
                        }
                    }
                }

                // Paso 2: Si existe el registro en tbl_historico_cuentas, lo actualizamos
                if (existeHistorico)
                {
                    if (tipoOperacion == "Cargo")
                    {
                        cargoMesHistorico += valor; // Sumar al cargo del mes
                    }
                    else if (tipoOperacion == "Abono")
                    {
                        abonoMesHistorico += valor; // Sumar al abono del mes
                    }

                    saldoHistorico = cargoMesHistorico - abonoMesHistorico; // Recalcular saldo

                    // Actualizar el registro existente
                    string updateHistorico = @"UPDATE tbl_historico_cuentas SET cargo_mes = ?, abono_mes = ?, saldo_act = ? WHERE Pk_id_cuenta = ? AND mes = ? AND anio = ?";

                    using (OdbcCommand cmdUpdateHistorico = new OdbcCommand(updateHistorico, conexion.conexion()))
                    {
                        cmdUpdateHistorico.Parameters.AddWithValue("@cargo_mes", cargoMesHistorico);
                        cmdUpdateHistorico.Parameters.AddWithValue("@abono_mes", abonoMesHistorico);
                        cmdUpdateHistorico.Parameters.AddWithValue("@saldo_act", saldoHistorico); ;
                        cmdUpdateHistorico.Parameters.AddWithValue("@Pk_id_cuenta", CuentaID);
                        cmdUpdateHistorico.Parameters.AddWithValue("@mes", mesActual);
                        cmdUpdateHistorico.Parameters.AddWithValue("@anio", anioActual);

                        cmdUpdateHistorico.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Paso 3: Si no existe el registro, lo insertamos como nuevo
                    string insertHistorico = @"INSERT INTO tbl_historico_cuentas(Pk_id_cuenta, mes, anio, cargo_mes, abono_mes, saldo_act) VALUES (?, ?, ?, ?, ?, ?)";

                    if (tipoOperacion == "Cargo")
                    {
                        cargoMesHistorico = valor;
                    }
                    else if (tipoOperacion == "Abono")
                    {
                        abonoMesHistorico = valor;
                    }

                    saldoHistorico = cargoMesHistorico - abonoMesHistorico;

                    using (OdbcCommand cmdInsertHistorico = new OdbcCommand(insertHistorico, conexion.conexion()))
                    {
                        cmdInsertHistorico.Parameters.AddWithValue("@Pk_id_cuenta", CuentaID);
                        cmdInsertHistorico.Parameters.AddWithValue("@mes", mesActual);
                        cmdInsertHistorico.Parameters.AddWithValue("@anio", anioActual);
                        cmdInsertHistorico.Parameters.AddWithValue("@cargo_mes", cargoMesHistorico);
                        cmdInsertHistorico.Parameters.AddWithValue("@abono_mes", abonoMesHistorico);
                        cmdInsertHistorico.Parameters.AddWithValue("@saldo_act", saldoHistorico);

                        cmdInsertHistorico.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el histórico: " + ex.Message);
            }
        }
    }
}
