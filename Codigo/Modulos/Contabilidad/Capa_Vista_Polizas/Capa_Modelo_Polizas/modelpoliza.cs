using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo_Polizas
{
    
    public class modelpoliza
    {
        //CONEXION CON CLASE CONEXION
        conexion con = new conexion();

        // ---------------------------------- COMBO BOX CUENTAS ----------------------------------
        public string[] llenarCmbCuentas(string stabla, string scampo1, string scampo2)
        {

            string[] sCampos = new string[300];
            string[] sauto = new string[300];
            int ii = 0;
            string ssql = "SELECT " + scampo1 + "," + scampo2 + " FROM " + stabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(ssql, con.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[ii] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    ii++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + stabla + "\n -" + scampo1); }

            return sCampos;
        }

        public DataTable obtenerCuentas(string stabla, string scampo1, string scampo2)
        {
            try
            {
                using (OdbcConnection conexion = con.conectar())
                {
                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open(); // Asegúrate de abrir la conexión
                    }

                    string ssql = "SELECT " + scampo1 + ", " + scampo2 + " FROM " + stabla + " WHERE estado = 1 AND Pk_id_tipocuenta = 2;";
                    OdbcCommand command = new OdbcCommand(ssql, conexion);
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

        public string[] llenarCmbTP(string stabla, string scampo1, string scampo2)
        {

            string[] sCampos = new string[300];
            string[] sauto = new string[300];
            int ii = 0;
            string ssql = "SELECT " + scampo1 + "," + scampo2 + " FROM " + stabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(ssql, con.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[ii] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    ii++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + stabla + "\n -" + scampo1); }

            return sCampos;
        }

        public DataTable obtenerTP(string stabla, string scampo1, string scampo2)
        {
            try
            {
                using (OdbcConnection conexion = con.conectar())
                {
                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open(); // Asegúrate de abrir la conexión
                    }

                    string ssql = "SELECT " + scampo1 + "," + scampo2 + " FROM " + stabla + " where estado = 1  ;";
                    OdbcCommand command = new OdbcCommand(ssql, conexion);
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

        public string[] llenarCmbOP(string stabla, string scampo1, string scampo2)
        {

            string[] sCampos = new string[300];
            string[] sauto = new string[300];
            int ii = 0;
            string ssql = "SELECT " + scampo1 + "," + scampo2 + " FROM " + stabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(ssql, con.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[ii] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    ii++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + stabla + "\n -" + scampo1); }

            return sCampos;
        }

        public DataTable obtenerOP(string stabla, string scampo1, string scampo2)
        {
            try
            {
                using (OdbcConnection conexion = con.conectar())
                {
                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open(); // Asegúrate de abrir la conexión
                    }

                    string ssql = "SELECT " + scampo1 + "," + scampo2 + " FROM " + stabla + " where estado = 1  ;";
                    OdbcCommand command = new OdbcCommand(ssql, conexion);
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

        public void ActulizarCuentas(int iidCuenta, string stipoOperacion, decimal devalor)
        {
            //Obtener las variables a llenar
            decimal decargoMesActual = 0;
            decimal deabonoMesActual = 0;
            decimal desaldoActual = 0;
            int? iidCuentaEnlace = null;  // Aquí se lee la cuanta padre

            string consulta = "SELECT cargo_mes, abono_mes, saldo_act, Pk_id_cuenta_enlace FROM tbl_cuentas WHERE Pk_id_cuenta = ?";
            try
            {
                using (OdbcCommand cmdSelect = new OdbcCommand(consulta, con.conectar()))
                {
                    cmdSelect.Parameters.AddWithValue("@Pk_id_cuenta", iidCuenta);

                    using (OdbcDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener los valores actuales de la base de datos
                            decargoMesActual = Convert.ToDecimal(reader["cargo_mes"]);
                            deabonoMesActual = Convert.ToDecimal(reader["abono_mes"]);
                            desaldoActual = Convert.ToDecimal(reader["saldo_act"]);

                            //Obtiene la cuenta padre 
                            iidCuentaEnlace = reader["Pk_id_cuenta_enlace"] != DBNull.Value
                                ? (int?)Convert.ToInt32(reader["Pk_id_cuenta_enlace"])
                                : null;
                        }
                    }
                }

                //Condicion para sumar cargo o en abono.
                if (stipoOperacion == "Cargo")
                {
                    decargoMesActual += devalor; // Sumar el valor al cargo mensual
                }
                else if (stipoOperacion == "Abono")
                {
                    deabonoMesActual += devalor; // Sumar el valor al abono mensual
                }

                //Calculo del saldo actual
                desaldoActual = decargoMesActual - deabonoMesActual;

                //Integrar los datos dentro de la base de datos.
                string supdateQuery = @"UPDATE tbl_cuentas SET cargo_mes = ?, abono_mes = ?, saldo_act = ? WHERE Pk_id_cuenta = ?";

                using (OdbcCommand cmdUpdate = new OdbcCommand(supdateQuery, con.conectar()))
                {
                    cmdUpdate.Parameters.AddWithValue("@cargo_mes", decargoMesActual);
                    cmdUpdate.Parameters.AddWithValue("@abono_mes", deabonoMesActual);
                    cmdUpdate.Parameters.AddWithValue("@saldo_act", desaldoActual);
                    cmdUpdate.Parameters.AddWithValue("@Pk_id_cuenta", iidCuenta);

                    cmdUpdate.ExecuteNonQuery();
                }

                //AQUI COMIENZA LA MAGIA -  Si en caso la variable idCuentaEnlace no es nulo repite esta función
                if (iidCuentaEnlace.HasValue)
                {
                    ActulizarCuentas(iidCuentaEnlace.Value, stipoOperacion, devalor);
                }

                //ActualizarHistorico(iidCuenta, devalor, stipoOperacion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void LlenarEncabezado(string sfechaSeleccionada, string sconcepto, int itipoPoli)
        {
            int idtipopoliza = itipoPoli; // ID del tipo de póliza
            string fecha = sfechaSeleccionada; // Fecha de la póliza
            string cnp = sconcepto; // Concepto de la póliza

            using (OdbcConnection conexion = con.conectar())
            {
                // Se crea una transacción
                using (OdbcTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Insertar en tbl_polizaencabezado y obtener el ID UNA SOLA VEZ
                        string sinsertEncabezado = @"INSERT INTO tbl_polizaencabezado(fechaPoliza, concepto, Pk_id_tipopoliza) VALUES(?, ?, ?) ON DUPLICATE KEY UPDATE concepto = VALUES(concepto);";

                        using (OdbcCommand cmdEncabezado = new OdbcCommand(sinsertEncabezado, conexion, transaction))
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

        public void LlenarDetalle(string sfechaSeleccionada, string sconcepto, List<object[]> ldetalles)
        {
            int inuevoIdEncabezado;
            string scnp = sconcepto; // Concepto de la póliza

            using (OdbcConnection conexion = con.conectar())
            {
                // Se crea una transacción
                using (OdbcTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Obtener el último ID insertado
                        string slastIdQuery = @"SELECT Pk_id_polizaencabezado FROM tbl_polizaencabezado WHERE concepto = ? ORDER BY Pk_id_polizaencabezado DESC LIMIT 1;";

                        using (OdbcCommand cmdLastId = new OdbcCommand(slastIdQuery, conexion, transaction))
                        {
                            cmdLastId.Parameters.AddWithValue("?", scnp);
                            inuevoIdEncabezado = Convert.ToInt32(cmdLastId.ExecuteScalar());
                        }

                        // Insertar en tbl_polizadetalle usando el ID del encabezado
                        string sinsertDetalle = @"INSERT INTO tbl_polizadetalle (Pk_id_polizaencabezado, Pk_id_cuenta, Pk_id_tipooperacion, valor) VALUES (?, ?, ?, ?)";
                        string scheckDetalleExists = @"SELECT COUNT(*) FROM tbl_polizadetalle WHERE Pk_id_polizaencabezado = ? AND Pk_id_cuenta = ? AND Pk_id_tipooperacion = ?";

                        foreach (var detalle in ldetalles)
                        {
                            // Verificar si ya existe el registro en tbl_polizadetalle
                            using (OdbcCommand cmdCheck = new OdbcCommand(scheckDetalleExists, conexion, transaction))
                            {
                                cmdCheck.Parameters.AddWithValue("?", inuevoIdEncabezado);
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
                            using (OdbcCommand cmdDetalle = new OdbcCommand(sinsertDetalle, conexion, transaction))
                            {
                                cmdDetalle.Parameters.AddWithValue("?", inuevoIdEncabezado);
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

        public void ActualizarHistorico(int iidCuenta, decimal deval, string stipoOperacion)
        {
            int imesActual = DateTime.Now.Month;
            int ianioActual = DateTime.Now.Year;

            int iCuentaID = iidCuenta;
            decimal devalor = deval;

            // Variables para almacenar los valores actuales
            decimal decargoMesHistorico = 0;
            decimal deabonoMesHistorico = 0;
            decimal desaldoHistorico = 0;
            bool bexisteHistorico = false;

            // Paso 1: Consultar los valores actuales del histórico para esa cuenta, mes y año
            string sselectHistorico = @"SELECT cargo_mes, abono_mes, saldo_act 
                               FROM tbl_historico_cuentas 
                               WHERE Pk_id_cuenta = ? AND mes = ? AND anio = ?";

            try
            {
                using (OdbcCommand cmdHistorico = new OdbcCommand(sselectHistorico, con.conectar()))
                {
                    cmdHistorico.Parameters.AddWithValue("@Pk_id_cuenta", iCuentaID);
                    cmdHistorico.Parameters.AddWithValue("@mes", imesActual);
                    cmdHistorico.Parameters.AddWithValue("@anio", ianioActual);

                    using (OdbcDataReader readerHistorico = cmdHistorico.ExecuteReader())
                    {
                        if (readerHistorico.Read())
                        {
                            // Si existe un registro, obtener los valores
                            decargoMesHistorico = Convert.ToDecimal(readerHistorico["cargo_mes"]);
                            deabonoMesHistorico = Convert.ToDecimal(readerHistorico["abono_mes"]);
                            desaldoHistorico = Convert.ToDecimal(readerHistorico["saldo_act"]);
                            bexisteHistorico = true;
                        }
                    }
                }

                // Paso 2: Si existe el registro en tbl_historico_cuentas, lo actualizamos
                if (bexisteHistorico)
                {
                    if (stipoOperacion == "Cargo")
                    {
                        decargoMesHistorico += devalor; // Sumar al cargo del mes
                    }
                    else if (stipoOperacion == "Abono")
                    {
                        deabonoMesHistorico += devalor; // Sumar al abono del mes
                    }

                    desaldoHistorico = decargoMesHistorico - deabonoMesHistorico; // Recalcular saldo

                    // Actualizar el registro existente
                    string supdateHistorico = @"UPDATE tbl_historico_cuentas SET cargo_mes = ?, abono_mes = ?, saldo_act = ? WHERE Pk_id_cuenta = ? AND mes = ? AND anio = ?";

                    using (OdbcCommand cmdUpdateHistorico = new OdbcCommand(supdateHistorico, con.conectar()))
                    {
                        cmdUpdateHistorico.Parameters.AddWithValue("@cargo_mes", decargoMesHistorico);
                        cmdUpdateHistorico.Parameters.AddWithValue("@abono_mes", deabonoMesHistorico);
                        cmdUpdateHistorico.Parameters.AddWithValue("@saldo_act", desaldoHistorico);;
                        cmdUpdateHistorico.Parameters.AddWithValue("@Pk_id_cuenta", iCuentaID);
                        cmdUpdateHistorico.Parameters.AddWithValue("@mes", imesActual);
                        cmdUpdateHistorico.Parameters.AddWithValue("@anio", ianioActual);

                        cmdUpdateHistorico.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Paso 3: Si no existe el registro, lo insertamos como nuevo
                    string sinsertHistorico = @"INSERT INTO tbl_historico_cuentas(Pk_id_cuenta, mes, anio, cargo_mes, abono_mes, saldo_act) VALUES (?, ?, ?, ?, ?, ?)";

                    if (stipoOperacion == "Cargo")
                    {
                        decargoMesHistorico = devalor;  
                    }
                    else if (stipoOperacion == "Abono")
                    {
                        deabonoMesHistorico = devalor;  
                    }

                    desaldoHistorico = decargoMesHistorico - deabonoMesHistorico;  

                    using (OdbcCommand cmdInsertHistorico = new OdbcCommand(sinsertHistorico, con.conectar()))
                    {
                        cmdInsertHistorico.Parameters.AddWithValue("@Pk_id_cuenta", iCuentaID);
                        cmdInsertHistorico.Parameters.AddWithValue("@mes", imesActual);
                        cmdInsertHistorico.Parameters.AddWithValue("@anio", ianioActual);
                        cmdInsertHistorico.Parameters.AddWithValue("@cargo_mes", decargoMesHistorico);
                        cmdInsertHistorico.Parameters.AddWithValue("@abono_mes", deabonoMesHistorico);
                        cmdInsertHistorico.Parameters.AddWithValue("@saldo_act", desaldoHistorico);

                        cmdInsertHistorico.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el histórico: " + ex.Message);
            }
        }

        public string ModRuta(string sIdAyuda)
        {
            string sRuta = "";
            string sQuery = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sQuery, con.conectar()))
            {
                command.Parameters.AddWithValue("id_ayuda", sIdAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sRuta = reader.GetString(0); // Asignamos el valor de la columna Ruta
                    }
                }
            }

            return sRuta;
        }

        public string ModIndice(string sIdAyuda)
        {
            string sIndice = "";
            string sQuery = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sQuery, con.conectar()))
            {
                command.Parameters.AddWithValue("Id_ayuda", sIdAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sIndice = reader.GetString(0); // Asignamos el valor de la columna Indice
                    }
                }
            }
            return sIndice;
        }

        public string ProbarTabla(string sTabla)
        {
            string sError = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM " + sTabla + ";", con.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
            }
            catch (Exception)
            {
                sError = "La tabla " + sTabla.ToUpper() + " no existe.";
            }
            return sError;
        }

        public int ContarReg(string sIdIndice)
        {
            int iCampos = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM ayuda WHERE id_ayuda = " + sIdIndice + ";", con.conectar());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    iCampos++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + sIdIndice.ToUpper() + "\n -");
            }
            return iCampos;
        }
    }
}
