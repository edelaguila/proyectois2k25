using Capa_Modelo_Nominas;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Planilla
{
    //public class ComisionDAO
    //{
    //    private Conexion conexion = new Conexion();

    //    public int? ObtenerClaveEmpleadoDesdeVendedor(int idVendedor)
    //    {
    //        int? claveEmpleado = null;
    //        string query = $"SELECT Fk_id_empleado FROM tbl_vendedores WHERE Pk_id_vendedor = {idVendedor} AND estado = 1";

    //        using (OdbcConnection conn = conexion.conexion())
    //        {
    //            OdbcCommand cmd = new OdbcCommand(query, conn);
    //            var result = cmd.ExecuteScalar();
    //            if (result != null) claveEmpleado = Convert.ToInt32(result);
    //        }

    //        return claveEmpleado;
    //    }

    //    public int? ObtenerIdPercepcionComision()
    //    {
    //        int? id = null;
    //        string query = $"SELECT pk_dedu_perp FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Comision' AND estado = 1";

    //        using (OdbcConnection conn = conexion.conexion())
    //        {
    //            OdbcCommand cmd = new OdbcCommand(query, conn);
    //            var result = cmd.ExecuteScalar();
    //            if (result != null) id = Convert.ToInt32(result);
    //        }

    //        return id;
    //    }

    //    public void InsertarOActualizarDeduccionEmpleado(int claveEmpleado, int idPercepcion, decimal monto, string mes)
    //    {
    //        using (OdbcConnection conn = conexion.conexion())
    //        {
    //            string queryExiste = $@"
    //                SELECT COUNT(*) FROM tbl_dedu_perp_emp
    //                WHERE Fk_clave_empleado = {claveEmpleado}
    //                AND Fk_dedu_perp = {idPercepcion}
    //                AND dedu_perp_emp_mes = '{mes}'";

    //            OdbcCommand cmdExiste = new OdbcCommand(queryExiste, conn);
    //            int existe = Convert.ToInt32(cmdExiste.ExecuteScalar());

    //            string query;
    //            if (existe > 0)
    //            {
    //                query = $@"
    //                    UPDATE tbl_dedu_perp_emp
    //                    SET dedu_perp_emp_cantidad = {monto}
    //                    WHERE Fk_clave_empleado = {claveEmpleado}
    //                    AND Fk_dedu_perp = {idPercepcion}
    //                    AND dedu_perp_emp_mes = '{mes}'";
    //            }
    //            else
    //            {
    //                query = $@"
    //                    INSERT INTO tbl_dedu_perp_emp 
    //                    (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad, dedu_perp_emp_mes, estado)
    //                    VALUES ({claveEmpleado}, {idPercepcion}, {monto}, '{mes}', 1)";
    //            }

    //            OdbcCommand cmd = new OdbcCommand(query, conn);
    //            cmd.ExecuteNonQuery();
    //        }
    //    }
    //}
    public class ComisionDAO
    {
        private Conexion conexion = new Conexion();

        public int? ObtenerClaveEmpleadoDesdeVendedor(int idVendedor)
        {
            int? claveEmpleado = null;
            string query = $"SELECT Fk_id_empleado FROM tbl_vendedores WHERE Pk_id_vendedor = {idVendedor} AND estado = 1";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null) claveEmpleado = Convert.ToInt32(result);
            }

            return claveEmpleado;
        }

        public int? ObtenerIdPercepcionComision()
        {
            int? id = null;
            string query = $"SELECT pk_dedu_perp FROM tbl_dedu_perp WHERE dedu_perp_concepto = 'Comision' AND estado = 1";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null) id = Convert.ToInt32(result);
            }

            return id;
        }

        public void InsertarOActualizarDeduccionEmpleado(int claveEmpleado, int idPercepcion, float monto, string mes)
        {
            //using (OdbcConnection conn = conexion.conexion())
            //{
            //    string queryExiste = $@"
            //        SELECT COUNT(*) FROM tbl_dedu_perp_emp
            //        WHERE Fk_clave_empleado = {claveEmpleado}
            //        AND Fk_dedu_perp = {idPercepcion}
            //        AND dedu_perp_emp_mes = '{mes}'";

            //    OdbcCommand cmdExiste = new OdbcCommand(queryExiste, conn);
            //    int existe = Convert.ToInt32(cmdExiste.ExecuteScalar());

            //    string query;
            //    if (existe > 0)
            //    {
            //        query = $@"
            //            UPDATE tbl_dedu_perp_emp
            //            SET dedu_perp_emp_cantidad = {monto}
            //            WHERE Fk_clave_empleado = {claveEmpleado}
            //            AND Fk_dedu_perp = {idPercepcion}
            //            AND dedu_perp_emp_mes = '{mes}'";
            //    }
            //    else
            //    {
            //        query = $@"
            //            INSERT INTO tbl_dedu_perp_emp 
            //            (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad, dedu_perp_emp_mes, estado)
            //            VALUES ({claveEmpleado}, {idPercepcion}, {monto}, '{mes}', 1)";
            //    }

            //    OdbcCommand cmd = new OdbcCommand(query, conn);
            //    cmd.ExecuteNonQuery();
            //}

            using (OdbcConnection conn = conexion.conexion())
            {
                string queryExiste = $@"
            SELECT COUNT(*) FROM tbl_dedu_perp_emp
            WHERE Fk_clave_empleado = {claveEmpleado}
            AND Fk_dedu_perp = {idPercepcion}
            AND dedu_perp_emp_mes = '{mes}'";

                OdbcCommand cmdExiste = new OdbcCommand(queryExiste, conn);
                int existe = Convert.ToInt32(cmdExiste.ExecuteScalar());

                if (existe > 0)
                {
                    string queryUpdate = $@"
                UPDATE tbl_dedu_perp_emp
                SET dedu_perp_emp_cantidad = {monto}
                WHERE Fk_clave_empleado = {claveEmpleado}
                AND Fk_dedu_perp = {idPercepcion}
                AND dedu_perp_emp_mes = '{mes}'";

                    OdbcCommand cmdUpdate = new OdbcCommand(queryUpdate, conn);
                    cmdUpdate.ExecuteNonQuery();
                }
                // Si no existe, no hace nada.
            }






        }
    }
}
