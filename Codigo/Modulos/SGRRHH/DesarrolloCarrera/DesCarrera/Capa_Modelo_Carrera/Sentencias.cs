using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo_Carrera
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        private string idUsuario;
        /*******************Ismar Leonel Cortez Sanchez  -0901-21-560*******************************************************/
        /****************************Combo box inteligente 2******************************************************************/
        public Sentencias(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public string[] funLlenarCmb2(string sTabla, string sCampo1, string sCampo2)
        {
            Conexion cn = new Conexion();
            string[] sCampos = new string[300];
            int iI = 0;

            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            /* La sentencia consulta el modelo de la base de datos con cada campo */
            try
            {
                // Muestra la consulta SQL antes de ejecutarla
                Console.Write(sql);
                MessageBox.Show(sql);

                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sCampos[iI] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    iI++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError en asignarCombo, revise los parámetros \n -" + sTabla + "\n -" + sCampo1);
            }

            return sCampos;
        }


        public DataTable obtener2(string sTabla, string sCampo1, string sCampo2)
        {
            Conexion cn = new Conexion();
            string sql = "SELECT DISTINCT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla;

            OdbcCommand command = new OdbcCommand(sql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        /****************************************************************************************************************/

        public DataRow ObtenerDatosEmpleado(string idEmpleado)
        {
            string sql = $@"
        SELECT 
            pt.puestos_nombre_puesto AS puesto,
            c.contratos_salario AS salario
        FROM tbl_empleados e
        INNER JOIN tbl_puestos_trabajo pt ON e.fk_id_puestos = pt.pk_id_puestos
        INNER JOIN tbl_contratos c ON e.pk_clave = c.fk_clave_empleado
        WHERE e.pk_clave = {idEmpleado} AND e.estado = 1 AND c.estado = 1
        ORDER BY c.pk_id_contrato DESC
        LIMIT 1;
    ";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, cn.conectar());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener puesto y salario: " + ex.Message);
            }

            return null;
        }


    }
}
