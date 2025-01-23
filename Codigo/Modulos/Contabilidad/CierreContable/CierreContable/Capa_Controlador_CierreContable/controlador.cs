using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Modelo_CierreContable;
using System.Collections.Generic;


namespace Capa_Controlador_CierreContable
{
    public class Controlador
    {
        sentencias sn = new sentencias();

        // Método para llenar una tabla
        public DataTable llenarTbl(string sTabla)
        {

            OdbcDataAdapter dt = sn.llenarTbl(sTabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public int ObtenerPeriodoPorMes(string sMes)
        {
            sMes = sMes.ToUpper(); // Convertir el mes a mayúsculas para la comparación

            switch (sMes)
            {
                case "ENERO": return 1;
                case "FEBRERO": return 2;
                case "MARZO": return 3;
                case "ABRIL": return 4;
                case "MAYO": return 5;
                case "JUNIO": return 6;
                case "JULIO": return 7;
                case "AGOSTO": return 8;
                case "SEPTIEMBRE": return 9;
                case "OCTUBRE": return 10;
                case "NOVIEMBRE": return 11;
                case "DICIEMBRE": return 12;
                default: return 0; // En caso de mes inválido
            }
        }

        public DataTable ObtenerMesesSinDatos(int iUltimoMesConDatos, HashSet<int> idsCuentas)
        {
            DataTable mesesSinDatos = new DataTable();
            mesesSinDatos.Columns.Add("Mes");

            // Revisar cada mes a partir del último con datos hasta diciembre
            for (int iMes = iUltimoMesConDatos + 1; iMes <= 12; iMes++)
            {
                bool datosFaltantes = false;

                foreach (int iIdCuenta in idsCuentas)
                {
                    // Verifica si falta alguna cuenta en este mes
                    if (sn.VerificarCuentaPorMes(iMes, iIdCuenta) == 0)
                    {
                        datosFaltantes = true;
                        break; // Si falta al menos una cuenta, detener la verificación
                    }
                }

                // Si falta alguna cuenta en este mes, añadirlo a la lista de meses sin datos
                if (datosFaltantes)
                {
                    DataRow row = mesesSinDatos.NewRow();
                    row["Mes"] = new DateTime(2024, iMes, 1).ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
                    mesesSinDatos.Rows.Add(row);
                }
            }

            return mesesSinDatos;
        }






        public DataTable ObtenerCuentas()
        {

            DataTable cuentas = new DataTable();
            try
            {
                string sQuery = "SELECT pk_id_cuenta, nombre_cuenta FROM tbl_cuentas"; // Ajusta la consulta según tu tabla
                using (OdbcConnection con = sn.ObtenerConexion())
                {
                    OdbcDataAdapter adapter = new OdbcDataAdapter(sQuery, con);
                    adapter.Fill(cuentas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener cuentas: {ex.Message}");
            }

            return cuentas;
        }

        public void ConsultarCierreG(string sCuentaSeleccionada, TextBox txt_cargomes, TextBox txt_abonomes, TextBox txt_saldoantmes, TextBox txt_saldoactmes)
        {
            // Consulta para traer las sumas de cargo_mes, abono_mes, saldo_ant y saldo_act
            string sQuery = "SELECT COALESCE(SUM(cargo_mes), 0) AS SumaCargoMes, " +
                           "COALESCE(SUM(abono_mes), 0) AS SumaAbonoMes, " +
                           "COALESCE(SUM(saldo_ant), 0) AS SumaSaldoAnt, " +
                           "COALESCE(SUM(saldo_act), 0) AS SumaSaldoAct " +
                           "FROM tbl_cuentas " +
                           "WHERE nombre_cuenta = ?";

            using (OdbcConnection con = sn.ObtenerConexion())
            {
                try
                {

                    using (OdbcCommand cmd = new OdbcCommand(sQuery, con))
                    {
                        // Asignar el parámetro de cuenta seleccionada
                        cmd.Parameters.AddWithValue("?", sCuentaSeleccionada);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Asignar valores sumados a los TextBox
                                // Asignar valores formateados a dos decimales a los TextBox
                                txt_cargomes.Text = reader["SumaCargoMes"] != DBNull.Value ? Convert.ToDecimal(reader["SumaCargoMes"]).ToString("F2") : "0.00";
                                txt_abonomes.Text = reader["SumaAbonoMes"] != DBNull.Value ? Convert.ToDecimal(reader["SumaAbonoMes"]).ToString("F2") : "0.00";
                                txt_saldoantmes.Text = reader["SumaSaldoAnt"] != DBNull.Value ? Convert.ToDecimal(reader["SumaSaldoAnt"]).ToString("F2") : "0.00";
                                txt_saldoactmes.Text = reader["SumaSaldoAct"] != DBNull.Value ? Convert.ToDecimal(reader["SumaSaldoAct"]).ToString("F2") : "0.00";

                            }
                            else
                            {
                                // Limpiar TextBox si no hay resultados
                                txt_cargomes.Clear();
                                txt_abonomes.Clear();
                                txt_saldoantmes.Clear();
                                txt_saldoactmes.Clear();
                                MessageBox.Show("No se encontraron datos para la cuenta especificada.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la consulta: " + ex.Message);
                }
            }
        }

        public void GenerarNuevoCierre(int iMes, int iAnio)
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                using (OdbcTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Seleccionar todos los IDs de cuentas
                        string sSelectQuery = "SELECT Pk_id_cuenta, cargo_mes, abono_mes, saldo_ant, saldo_act, cargo_acumulado, abono_acumulado FROM tbl_cuentas";
                        OdbcCommand selectCmd = new OdbcCommand(sSelectQuery, con, transaction);

                        using (OdbcDataReader reader = selectCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int iCuentaId = reader.GetInt32(0);
                                decimal deCargoMes = reader.GetDecimal(1);
                                decimal deAbonoMes = reader.GetDecimal(2);
                                decimal deSaldoAnt = reader.GetDecimal(3);
                                decimal deSaldoAct = reader.GetDecimal(4);
                                decimal deCargoAcumulado = reader.GetDecimal(5);
                                decimal deAbonoAcumulado = reader.GetDecimal(6);

                                // Obtener el saldoanual del mes anterior, si existe
                                decimal deSaldoAnualPrevio = 0;
                                string sSaldoAnualQuery = "SELECT saldoanual FROM tbl_historico_cuentas WHERE Pk_id_cuenta = ? AND mes = ? AND anio = ?";
                                using (OdbcCommand saldoAnualCmd = new OdbcCommand(sSaldoAnualQuery, con, transaction))
                                {
                                    saldoAnualCmd.Parameters.AddWithValue("?", iCuentaId);
                                    saldoAnualCmd.Parameters.AddWithValue("?", iMes - 1); // Mes anterior
                                    saldoAnualCmd.Parameters.AddWithValue("?", iAnio);

                                    object result = saldoAnualCmd.ExecuteScalar();
                                    if (result != null)
                                    {
                                        deSaldoAnualPrevio = Convert.ToDecimal(result);
                                    }
                                }

                                // Sumar el saldo_act actual al saldoanual del mes anterior
                                decimal deNuevoSaldoAnual = deSaldoAnualPrevio + deSaldoAct;

                                // Guardar el historial en tbl_historico_cuentas
                                string sInsertQuery = @"
                        INSERT INTO tbl_historico_cuentas 
                            (Pk_id_cuenta, mes, anio, cargo_mes, abono_mes, saldo_ant, saldo_act, cargo_acumulado, abono_acumulado, saldoanual)
                        VALUES 
                            (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                                using (OdbcCommand insertCmd = new OdbcCommand(sInsertQuery, con, transaction))
                                {
                                    insertCmd.Parameters.AddWithValue("?", iCuentaId);
                                    insertCmd.Parameters.AddWithValue("?", iMes);
                                    insertCmd.Parameters.AddWithValue("?", iAnio);
                                    insertCmd.Parameters.AddWithValue("?", deCargoMes);
                                    insertCmd.Parameters.AddWithValue("?", deAbonoMes);
                                    insertCmd.Parameters.AddWithValue("?", deSaldoAnt);
                                    insertCmd.Parameters.AddWithValue("?", deSaldoAct);
                                    insertCmd.Parameters.AddWithValue("?", deCargoAcumulado + deCargoMes);
                                    insertCmd.Parameters.AddWithValue("?", deAbonoAcumulado + deAbonoMes);
                                    insertCmd.Parameters.AddWithValue("?", deNuevoSaldoAnual);

                                    insertCmd.ExecuteNonQuery();
                                }

                                // Actualizar los valores en tbl_cuentas
                                string sUpdateQuery = @"
                        UPDATE tbl_cuentas
                        SET 
                            cargo_mes = 0, 
                            abono_mes = 0, 
                            saldo_ant = saldo_act, 
                            saldo_act = 0,
                            cargo_acumulado = cargo_acumulado + ?,
                            abono_acumulado = abono_acumulado + ?
                        WHERE Pk_id_cuenta = ?";

                                using (OdbcCommand updateCmd = new OdbcCommand(sUpdateQuery, con, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("?", deCargoMes);
                                    updateCmd.Parameters.AddWithValue("?", deAbonoMes);
                                    updateCmd.Parameters.AddWithValue("?", iCuentaId);

                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                        MessageBox.Show("Cierre mensual guardado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        // Revertir cambios en caso de error
                        transaction.Rollback();
                        MessageBox.Show($"Error al guardar el cierre: {ex.Message}");
                    }
                }
            }
        }

        public void VerificarYActualizarAnoCompleto(int iAnio)
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                string sQuery = "SELECT COUNT(DISTINCT mes) FROM tbl_historico_cuentas WHERE anio = ?";
                OdbcCommand cmd = new OdbcCommand(sQuery, con);
                cmd.Parameters.AddWithValue("?", iAnio);

                int iMesesConCierre = Convert.ToInt32(cmd.ExecuteScalar());

                // Verificar si ya se completaron los 12 meses
                if (iMesesConCierre == 12)
                {
                    int iNuevoAnio = iAnio + 1;
                    MessageBox.Show($"Año actualizado a {iNuevoAnio}.");
                    ActualizarSaldoAntYResetearCuentas(iNuevoAnio); // Llamar a la función del paso 2 con el nuevo año
                }
            }
        }
        public void ActualizarSaldoAntYResetearCuentas(int iAnio)
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                using (OdbcTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Actualizar saldo_ant en tbl_cuentas con saldoanual de tbl_historico_cuentas
                        string sUpdatesaldoantquery = @"
                    UPDATE tbl_cuentas c
                    JOIN tbl_historico_cuentas h ON c.Pk_id_cuenta = h.Pk_id_cuenta
                    SET c.saldo_ant = h.saldoanual
                    WHERE h.mes = 12 AND h.anio = ?";

                        OdbcCommand updateSaldoAntCmd = new OdbcCommand(sUpdatesaldoantquery, con, transaction);
                        updateSaldoAntCmd.Parameters.AddWithValue("?", iAnio - 1);
                        updateSaldoAntCmd.ExecuteNonQuery();

                        // Reiniciar los valores de columnas flotantes en tbl_cuentas a 0
                        string sResetCuentasQuery = @"
                    UPDATE tbl_cuentas
                    SET 
                        cargo_mes = 0, 
                        abono_mes = 0, 
                        saldo_act = 0, 
                        cargo_acumulado = 0, 
                        abono_acumulado = 0";

                        OdbcCommand resetCuentasCmd = new OdbcCommand(sResetCuentasQuery, con, transaction);
                        resetCuentasCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Saldo anual transferido y valores reiniciados para el nuevo año.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error al actualizar el saldo y reiniciar cuentas: {ex.Message}");
                    }
                }
            }
        }

        public bool VerificarMesConDatos(int iAnio, int iMes)
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                string sQuery = "SELECT COUNT(*) FROM tbl_historico_cuentas WHERE anio = ? AND mes = ?";
                OdbcCommand cmd = new OdbcCommand(sQuery, con);
                cmd.Parameters.AddWithValue("?", iAnio);
                cmd.Parameters.AddWithValue("?", iMes);

                int iCount = Convert.ToInt32(cmd.ExecuteScalar());
                return iCount > 0;  // Retorna true si hay datos, false si no
            }
        }






        // Método para actualizar el ComboBox de meses, asegurando que el último mes no aparezca


        // Método para actualizar el ComboBox de meses, asegurando que el último mes no aparezca
        // Método para actualizar la lista de meses, asegurando que el último mes no aparezca
        public void ActualizarComboBoxMeses()
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                string sQuery = "SELECT DISTINCT mes FROM tbl_historico_cuentas";
                OdbcCommand cmd = new OdbcCommand(sQuery, con);
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    // Clear the list of months and repopulate it, excluding the last entered month
                    List<string> meses = new List<string>();
                    List<int> mesesExistentes = new List<int>();

                    while (reader.Read())
                    {
                        mesesExistentes.Add(reader.GetInt32(0));
                    }

                    // Add months to the list, skipping the last entered month
                    for (int i = 1; i <= 12; i++)
                    {
                        if (!mesesExistentes.Contains(i))
                        {
                            meses.Add(i.ToString()); // Convertir a string y agregar a la lista
                        }
                    }
                }
            }
        }



        public DataTable ObtenerDatosCierre(string sNombreCuenta)
        {
            DataTable datosCierre = new DataTable();
            try
            {
                // Ajustar la consulta para obtener los datos necesarios
                string sQuery;

                if (string.IsNullOrEmpty(sNombreCuenta)) // Si nombreCuenta es null o vacío, selecciona todas las cuentas
                {
                    sQuery = @"SELECT c.Pk_id_cuenta, 
                     tc.nombre_tipocuenta AS nombre_tipo_cuenta, 
                     ec.nombre_tipocuenta AS nombre_encabezado, 
                     c.nombre_cuenta, 
                     c.cargo_mes, 
                     c.abono_mes, 
                     c.saldo_ant, 
                     c.saldo_act, 
                     c.cargo_acumulado, 
                     c.abono_acumulado 
              FROM tbl_cuentas c
              JOIN tbl_tipocuenta tc ON c.Pk_id_tipocuenta = tc.Pk_id_tipocuenta
              JOIN tbl_encabezadoclasecuenta ec ON c.Pk_id_encabezadocuenta = ec.Pk_id_encabezadocuenta"; // Obtener todas las cuentas
                }
                else
                {
                    sQuery = @"SELECT c.Pk_id_cuenta, 
                     tc.nombre_tipocuenta AS nombre_tipo_cuenta, 
                     ec.nombre_tipocuenta AS nombre_encabezado, 
                     c.nombre_cuenta, 
                     c.cargo_mes, 
                     c.abono_mes, 
                     c.saldo_ant, 
                     c.saldo_act, 
                     c.cargo_acumulado, 
                     c.abono_acumulado 
              FROM tbl_cuentas c
              JOIN tbl_tipocuenta tc ON c.Pk_id_tipocuenta = tc.Pk_id_tipocuenta
              JOIN tbl_encabezadoclasecuenta ec ON c.Pk_id_encabezadocuenta = ec.Pk_id_encabezadocuenta
              WHERE c.nombre_cuenta = ?"; // Filtrar por cuenta seleccionada
                }


                using (OdbcConnection con = sn.ObtenerConexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, con))
                    {
                        if (!string.IsNullOrEmpty(sNombreCuenta))
                        {
                            cmd.Parameters.AddWithValue("nombre_cuenta", sNombreCuenta); // Asignar el valor del parámetro
                        }

                        OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                        adapter.Fill(datosCierre);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de cierre: {ex.Message}");
            }

            return datosCierre;
        }

        public int ObtenerUltimoMesConDatos(int iAnio)
        {
            int iUltimoMes = 0;

            using (OdbcConnection con = sn.ObtenerConexion())
            {
                string sQuery = "SELECT MAX(mes) FROM tbl_historico_cuentas WHERE anio = ?";
                OdbcCommand cmd = new OdbcCommand(sQuery, con);
                cmd.Parameters.AddWithValue("?", iAnio);

                var resultado = cmd.ExecuteScalar();
                if (resultado != DBNull.Value && resultado != null)
                {
                    iUltimoMes = Convert.ToInt32(resultado);
                }
            }

            return iUltimoMes; // Retorna 0 si no hay meses con datos
        }



        public bool VerificarCierresCompletos(int iAnio)
        {
            string sQuery = @"
                SELECT COUNT(DISTINCT Mes) AS MesesRegistrados
                FROM tbl_historico_cuentas
                WHERE Anio = ?";

            using (OdbcConnection conn = sn.ObtenerConexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", iAnio);
                    int iMesesRegistrados = Convert.ToInt32(cmd.ExecuteScalar());

                    // Verificar si existen registros para todos los meses (1 a 12)
                    return iMesesRegistrados == 12;
                }
            }
        }





        // Método para actualizar el año en la tabla `tbl_historico_cuentas`
        public void ActualizarAnioHistorico(int iAnioActual, int iAño)
        {
            string sQueryActualizarSaldoAnt = @"
                UPDATE tbl_cuentas c
                INNER JOIN tbl_historico_cuentas h ON c.Pk_id_cuenta = h.Pk_id_cuenta
                SET c.saldo_ant = h.saldoanual
                WHERE h.Anio = ? AND h.Mes = 12";

            string sQueryReiniciarSaldos = @"
                UPDATE tbl_cuentas
                SET cargo_mes = 0, abono_mes = 0, saldo_act = 0, 
                    cargo_acumulado = 0, abono_acumulado = 0";

            using (OdbcConnection conn = sn.ObtenerConexion())
            {
                // Ejecutar la primera consulta para actualizar saldo_ant
                using (OdbcCommand cmd1 = new OdbcCommand(sQueryActualizarSaldoAnt, conn))
                {
                    cmd1.Parameters.AddWithValue("?", iAnioActual);
                    cmd1.ExecuteNonQuery();
                }

                // Ejecutar la segunda consulta para reiniciar saldos
                using (OdbcCommand cmd2 = new OdbcCommand(sQueryReiniciarSaldos, conn))
                {
                    cmd2.ExecuteNonQuery();
                }
            }
        }


        // Modifica el método ActualizarSumasSaldos para incluir la cuenta
        public void ActualizarSumasSaldos(TextBox txt_saldoant, TextBox txt_saldofinal, int iPeriodo, string sCuenta)
        {
            try
            {
                // Llama a ObtenerSumasSaldos pasando periodo y cuenta
                (decimal deSumaSaldoAnt, decimal deSumaSaldoAct) = sn.ObtenerSumasSaldos(iPeriodo, sCuenta);

                txt_saldoant.Text = deSumaSaldoAnt.ToString("N2");
                txt_saldofinal.Text = deSumaSaldoAct.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener sumas de saldos: {ex.Message}");
            }
        }



        public string MRuta(string Ruta1)
        {
            string ruta = sn.modRuta(Ruta1);

            return ruta;
        }

        public string MIndice(string Indice1)
        {
            string indice = sn.modIndice(Indice1);

            return indice;
        }

        public bool VerificarRegistrosVacios(string sMes, string sAnio)
        {
            // Obtener el periodo correspondiente al mes
            int iPeriodo = ObtenerPeriodoPorMes(sMes);
            if (iPeriodo < 1 || iPeriodo > 12) // Si el mes no es válido, retorna false
            {
                MessageBox.Show("Mes inválido.");
                return false;
            }

            // Obtener todas las cuentas
            DataTable cuentas = ObtenerCuentas();

            // Recorrer cada cuenta y verificar si hay registros para el mes y año especificados
            foreach (DataRow cuenta in cuentas.Rows)
            {
                string sNombreCuenta = cuenta["nombre_cuenta"].ToString();

                // Consulta para verificar si hay registros para el mes y año con un JOIN
                string sQuery = @"
            SELECT COUNT(*) 
            FROM tbl_historico_cuentas hc
            INNER JOIN tbl_cuentas c ON hc.Pk_id_cuenta = c.Pk_id_cuenta
            WHERE c.nombre_cuenta = ? AND hc.mes = ? AND hc.anio = ?";

                using (OdbcConnection con = sn.ObtenerConexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, con))
                    {
                        cmd.Parameters.AddWithValue("?", sNombreCuenta);
                        cmd.Parameters.AddWithValue("?", iPeriodo);
                        cmd.Parameters.AddWithValue("?", sAnio);

                        int iRegistros = Convert.ToInt32(cmd.ExecuteScalar());

                        // Si no hay registros para este mes, retorna false
                        if (iRegistros == 0)
                        {
                            MessageBox.Show($"No existe cierre para la cuenta '{sNombreCuenta}' en el mes {sMes} del año {sAnio}.");
                            return false;
                        }
                    }
                }
            }

            // Si todas las cuentas tienen registros, retorna true
            return true;
        }

        public void ConsultaCG(int iPeriodo, string sAnio, string sCuenta, DataTable dt1, DataTable dt2)
        {
            // Define the SQL query for dt1 with cargo_mes
            string sConsultaCargo = @"
        SELECT 
            c.Pk_id_cuenta AS 'ID de Cuenta', 
            c.nombre_cuenta AS 'Nombre de Cuenta', 
            e.nombre_tipocuenta AS 'Encabezado Cuenta', 
            t.nombre_tipocuenta AS 'Tipo de Cuenta', 
            h.cargo_mes AS 'Cargo del Mes'
        FROM 
            tbl_cuentas AS c
        LEFT JOIN 
            tbl_historico_cuentas AS h ON c.Pk_id_cuenta = h.Pk_id_cuenta
        LEFT JOIN 
            tbl_encabezadoclasecuenta AS e ON c.Pk_id_encabezadocuenta = e.Pk_id_encabezadocuenta
        LEFT JOIN 
            tbl_tipocuenta AS t ON c.Pk_id_tipocuenta = t.PK_id_tipocuenta
        WHERE 
            (h.mes = ? AND h.anio = ?) 
            AND (c.nombre_cuenta = ? OR ? IS NULL)
            OR h.Pk_id_cuenta IS NULL";

            // Define the SQL query for dt2 with abono_mes
            string sConsultaAbono = @"
        SELECT 
            c.Pk_id_cuenta AS 'ID de Cuenta', 
            c.nombre_cuenta AS 'Nombre de Cuenta', 
            e.nombre_tipocuenta AS 'Encabezado Cuenta', 
            t.nombre_tipocuenta AS 'Tipo de Cuenta', 
            h.abono_mes AS 'Abono del Mes'
        FROM 
            tbl_cuentas AS c
        LEFT JOIN 
            tbl_historico_cuentas AS h ON c.Pk_id_cuenta = h.Pk_id_cuenta
        LEFT JOIN 
            tbl_encabezadoclasecuenta AS e ON c.Pk_id_encabezadocuenta = e.Pk_id_encabezadocuenta
        LEFT JOIN 
            tbl_tipocuenta AS t ON c.Pk_id_tipocuenta = t.PK_id_tipocuenta
        WHERE 
            (h.mes = ? AND h.anio = ?) 
            AND (c.nombre_cuenta = ? OR ? IS NULL)
            OR h.Pk_id_cuenta IS NULL";

            using (OdbcConnection con = sn.ObtenerConexion())
            {
                // Fill dt1 with cargo_mes data
                OdbcDataAdapter datosCargo = new OdbcDataAdapter(sConsultaCargo, con);
                datosCargo.SelectCommand.Parameters.AddWithValue("?", iPeriodo);
                datosCargo.SelectCommand.Parameters.AddWithValue("?", sAnio);

                if (!string.IsNullOrEmpty(sCuenta))
                {
                    datosCargo.SelectCommand.Parameters.AddWithValue("?", sCuenta);
                    datosCargo.SelectCommand.Parameters.AddWithValue("?", sCuenta);
                }
                else
                {
                    datosCargo.SelectCommand.Parameters.AddWithValue("?", DBNull.Value);
                    datosCargo.SelectCommand.Parameters.AddWithValue("?", DBNull.Value);
                }
                datosCargo.Fill(dt1);

                // Fill dt2 with abono_mes data
                OdbcDataAdapter datosAbono = new OdbcDataAdapter(sConsultaAbono, con);
                datosAbono.SelectCommand.Parameters.AddWithValue("?", iPeriodo);
                datosAbono.SelectCommand.Parameters.AddWithValue("?", sAnio);

                if (!string.IsNullOrEmpty(sCuenta))
                {
                    datosAbono.SelectCommand.Parameters.AddWithValue("?", sCuenta);
                    datosAbono.SelectCommand.Parameters.AddWithValue("?", sCuenta);
                }
                else
                {
                    datosAbono.SelectCommand.Parameters.AddWithValue("?", DBNull.Value);
                    datosAbono.SelectCommand.Parameters.AddWithValue("?", DBNull.Value);
                }
                datosAbono.Fill(dt2);
            }
        }





    }
}
