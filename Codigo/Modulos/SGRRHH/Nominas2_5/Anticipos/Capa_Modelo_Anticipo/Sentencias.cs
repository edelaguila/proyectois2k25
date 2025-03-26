using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_Anticipo
{
    public class Sentencias
    {
        Conexion cn = new Conexion();

        public void Fun_CalcularAnticipo(string mes)
        {
            using (OdbcConnection connection = cn.conexion())
            {
                // Definir las variables necesarias
                int v_fk_dedu_perp;
                float v_monto;
                float v_cantidad_deduccion;
                int v_fk_clave_empleado;
                float v_total_anticipos;

                // Obtener el ID y monto de deducción del concepto 'Anticipo'
                string queryDeduccion = "SELECT pk_dedu_perp, dedu_perp_monto FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Anticipo' LIMIT 1";
                OdbcCommand cmdDeduccion = new OdbcCommand(queryDeduccion, connection);
                OdbcDataReader readerDeduccion = cmdDeduccion.ExecuteReader();

                if (readerDeduccion.Read())
                {
                    v_fk_dedu_perp = readerDeduccion.GetInt32(0);
                    v_monto = readerDeduccion.GetFloat(1);
                }
                else
                {
                    throw new Exception("No se encontró el concepto 'Anticipo'");
                }

                // Consulta para obtener los anticipos por empleado
                string queryAnticipos = "SELECT fk_clave_empleado, SUM(anticipos_cantidad) AS total_anticipos FROM tbl_control_anticipos WHERE anticipos_mes = ? GROUP BY fk_clave_empleado";
                OdbcCommand cmdAnticipos = new OdbcCommand(queryAnticipos, connection);
                cmdAnticipos.Parameters.AddWithValue("?", mes);
                OdbcDataReader readerAnticipos = cmdAnticipos.ExecuteReader();

                bool hayAnticipos = false; // Variable para verificar si se encontraron anticipos

                while (readerAnticipos.Read())
                {
                    hayAnticipos = true; // Se encontraron anticipos
                    v_fk_clave_empleado = readerAnticipos.GetInt32(0);
                    v_total_anticipos = readerAnticipos.GetFloat(1);

                    // Calcular la cantidad de deducción
                    v_cantidad_deduccion = v_total_anticipos * v_monto;

                    // Insertar o actualizar la deducción en tbl_dedu_perp_emp
                    string queryInsert = "INSERT INTO tbl_dedu_perp_emp (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad,dedu_perp_emp_mes, estado) VALUES (?, ?, ?,?, 1) ON DUPLICATE KEY UPDATE dedu_perp_emp_cantidad = VALUES(dedu_perp_emp_cantidad), estado = 1;";
                    OdbcCommand cmdInsert = new OdbcCommand(queryInsert, connection);
                    cmdInsert.Parameters.AddWithValue("?", v_fk_clave_empleado);
                    cmdInsert.Parameters.AddWithValue("?", v_fk_dedu_perp);
                    cmdInsert.Parameters.AddWithValue("?", v_cantidad_deduccion);
                    cmdInsert.Parameters.AddWithValue("?", mes);

                    cmdInsert.ExecuteNonQuery();
                }

                if (!hayAnticipos) // Si no se encontraron anticipos
                {
                    throw new Exception($"No hubo anticipos registrados para el mes de {mes}.");
                }
            }
        }


    }
}
