using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CierreContable
{
    public class sentencias
    {

        private conexion con = new conexion();


        public OdbcConnection ObtenerConexion()
        {
            return con.Conexion(); // Asegúrate de que este método retorne la conexión
        }

        // Método para llenar la tabla genérico

        public OdbcDataAdapter llenarTbl(string sTabla)
        {
            string sSql = "SELECT * FROM " + sTabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sSql, con.Conexion());
            return dataTable;

        }

        public (decimal deSumaSaldoAnt, decimal deSumaSaldoAct) ObtenerSumasSaldos(int iPeriodo, string sCuenta)
        {
            decimal deSumaSaldoAnt = 0;
            decimal deSumaSaldoAct = 0;


            // Actualiza la consulta para incluir el JOIN con tbl_cuentas

            string sQuery = "SELECT SUM(hc.saldo_ant) AS SumaSaldoAnt, SUM(hc.saldo_act) AS SumaSaldoAct " +
                           "FROM tbl_historico_cuentas hc " +
                           "JOIN tbl_cuentas c ON hc.Pk_id_cuenta = c.Pk_id_cuenta " +
                           "WHERE hc.mes = ? AND c.nombre_cuenta = ?";


            using (OdbcConnection conn = con.Conexion())
            {
                OdbcCommand cmd = new OdbcCommand(sQuery, conn);
                cmd.Parameters.AddWithValue("?", iPeriodo); // Agregar el parámetro del periodo
                cmd.Parameters.AddWithValue("?", sCuenta);   // Agregar el parámetro de cuenta

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Manejo de valores nulos y conversión
                    deSumaSaldoAnt = reader.IsDBNull(0) ? 0 : Convert.ToDecimal(reader["SumaSaldoAnt"]);
                    deSumaSaldoAct = reader.IsDBNull(1) ? 0 : Convert.ToDecimal(reader["SumaSaldoAct"]);
                }

                reader.Close();

            }

            return (deSumaSaldoAnt, deSumaSaldoAct);
        }

        public int VerificarCuentaPorMes(int iMes, int iIdCuenta)
        {
            int iCuentaExistente = 0;

            using (OdbcConnection con = ObtenerConexion())
            {
                string sQuery = "SELECT COUNT(*) FROM tbl_historico_cuentas WHERE mes = ? AND Pk_id_cuenta = ?";
                OdbcCommand cmd = new OdbcCommand(sQuery, con);
                cmd.Parameters.AddWithValue("?", iMes);
                cmd.Parameters.AddWithValue("?", iIdCuenta);

                iCuentaExistente = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return iCuentaExistente;
        }



        public string modRuta(string sIdAyuda)
        {
            string sRuta = "";
            string sSql = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, ObtenerConexion()))
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

        public string modIndice(string sIdAyuda)
        {
            string sIndice = "";
            string sSql = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, ObtenerConexion()))
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

        // Método para ejecutar una consulta específica
        public DataTable EjecutarConsulta(string sQuery)
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = con.Conexion())

            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(sQuery, conn);
                adapter.Fill(dt);
            }
            return dt;
        }


    }

}

