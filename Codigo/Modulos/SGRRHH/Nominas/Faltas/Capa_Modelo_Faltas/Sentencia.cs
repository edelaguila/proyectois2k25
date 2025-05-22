using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_Faltas
{
    public class Sentencia
    {
        Conexion cn = new Conexion(); //Conexion con base de datos

        // Método para obtener todos los empleados
        public DataTable ObtenerEmpleados()
        {
            DataTable empleados = new DataTable();
            using (var connection = cn.conexion())
            {
                string query = @"
                    SELECT e.pk_clave, 
                           CONCAT(e.empleados_nombre, ' ', e.empleados_apellido) as empleados_nombre 
                    FROM tbl_empleados e 
                    WHERE e.estado = 1";
                using (var command = new OdbcCommand(query, connection))
                using (var adapter = new OdbcDataAdapter(command))
                {
                    adapter.Fill(empleados);
                }
            }
            return empleados;
        }

        public DataTable ObtenerMesesConFaltas()
        {
            DataTable meses = new DataTable();
            using (var connection = cn.conexion())
            {
                string query = @"
            SELECT DISTINCT faltas_mes 
            FROM tbl_control_faltas
            WHERE estado = 1";

                using (var command = new OdbcCommand(query, connection))
                using (var adapter = new OdbcDataAdapter(command))
                {
                    adapter.Fill(meses);
                }
            }
            return meses;
        }

        // Método para obtener todas las faltas registradas
        public DataTable ObtenerTodasLasFaltas()
        {
            DataTable faltas = new DataTable();
            using (var connection = cn.conexion())
            {
                // Modificamos la consulta para incluir el descuento calculado
                string query = @"
    SELECT f.fk_clave_empleado,
           f.faltas_mes,
           CONCAT(e.empleados_nombre, ' ', e.empleados_apellido) AS empleados_nombre,
           c.contratos_salario,
           (c.contratos_salario / 30) * COUNT(f.pk_registro_faltas) AS descuento
    FROM tbl_control_faltas f
    INNER JOIN tbl_empleados e ON f.fk_clave_empleado = e.pk_clave
    LEFT JOIN tbl_contratos c ON e.pk_clave = c.fk_clave_empleado
    WHERE f.estado = 1 AND c.estado = 1
    GROUP BY f.fk_clave_empleado, f.faltas_mes, e.empleados_nombre, c.contratos_salario";

                using (var command = new OdbcCommand(query, connection))
                using (var adapter = new OdbcDataAdapter(command))
                {
                    adapter.Fill(faltas);
                }
            }

            return faltas;
        }
        public decimal CalcularDescuentoPorFaltas(int idEmpleado, string mes)
        {
            decimal descuento = 0;
            using (var connection = cn.conexion())
            {
                // Primero obtenemos el salario actual del empleado
                string querySalario = @"
                    SELECT c.contratos_salario 
                    FROM tbl_contratos c
                    WHERE c.fk_clave_empleado = ? 
                    AND c.estado = 1
                    ORDER BY c.contratos_fecha_creacion DESC 
                    LIMIT 1";

                decimal salario = 0;
                using (var cmdSalario = new OdbcCommand(querySalario, connection))
                {
                    cmdSalario.Parameters.AddWithValue("@fk_clave_empleado", idEmpleado);
                    object result = cmdSalario.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        salario = Convert.ToDecimal(result);
                    }
                }

                // Luego obtenemos el total de faltas para el mes
                string queryFaltas = @"
                    SELECT COUNT(*) 
                    FROM tbl_control_faltas
                    WHERE fk_clave_empleado = ? 
                    AND faltas_mes = ?
                    AND estado = 1";

                int totalFaltas = 0;
                using (var cmdFaltas = new OdbcCommand(queryFaltas, connection))
                {
                    cmdFaltas.Parameters.AddWithValue("@fk_clave_empleado", idEmpleado);
                    cmdFaltas.Parameters.AddWithValue("@faltas_mes", mes);
                    totalFaltas = Convert.ToInt32(cmdFaltas.ExecuteScalar());
                }

                // Calculamos el descuento
                if (totalFaltas > 0 && salario > 0)
                {
                    descuento = (salario * totalFaltas) / 30;
                }
            }

            return descuento;
        }

        public void GuardarDeduccionPorFaltas(int idEmpleado, string mes)
        {
            // Primero calculamos el descuento
            decimal descuento = CalcularDescuentoPorFaltas(idEmpleado, mes);

            using (var connection = cn.conexion())
            {
                try
                {
                    // Verificamos si ya existe un registro para este empleado
                    string queryDeduccionId = @"
                        SELECT pk_dedu_perp 
                        FROM tbl_dedu_perp
                        WHERE dedu_perp_concepto = 'Faltas' 
                        AND estado = 1
                        LIMIT 1";

                    int? deduccionId = null;
                    using (var cmdDeduccionId = new OdbcCommand(queryDeduccionId, connection))
                    {
                        var result = cmdDeduccionId.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            deduccionId = Convert.ToInt32(result);
                        }
                    }

                    if (!deduccionId.HasValue)
                    {
                        throw new Exception("No se encontró el concepto 'Faltas' en tbl_dedu_perp");
                    }

                    // Verificamos si ya existe un registro para este empleado
                    string queryVerificar = @"
                        SELECT pk_dedu_perp_emp
                        FROM tbl_dedu_perp_emp 
                        WHERE Fk_clave_empleado = ? 
                        AND Fk_dedu_perp = ?";

                    int? registroExistente = null;
                    using (var cmdVerificar = new OdbcCommand(queryVerificar, connection))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Fk_clave_empleado", idEmpleado);
                        cmdVerificar.Parameters.AddWithValue("@Fk_dedu_perp", deduccionId.Value);
                        var result = cmdVerificar.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            registroExistente = Convert.ToInt32(result);
                        }
                    }

                    string query;
                    if (registroExistente.HasValue)
                    {
                        // Actualizamos el registro existente con el nuevo descuento
                        query = @"
                            UPDATE tbl_dedu_perp_emp 
                            SET dedu_perp_emp_cantidad = ?,
                            dedu_perp_emp_mes = ?,
                                estado = 1
                            WHERE pk_dedu_perp_emp = ?";

                        using (var cmd = new OdbcCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@cantidad", descuento);
                            cmd.Parameters.AddWithValue("@cantidad", mes);
                            cmd.Parameters.AddWithValue("@pk", registroExistente.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Insertamos un nuevo registro con el descuento
                        query = @"
                            INSERT INTO tbl_dedu_perp_emp 
                            (Fk_clave_empleado, Fk_dedu_perp, dedu_perp_emp_cantidad,dedu_perp_emp_mes, estado)
                            VALUES (?, ?, ?, ?,1)";

                        using (var cmd = new OdbcCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@empleado", idEmpleado);
                            cmd.Parameters.AddWithValue("@deduccion", deduccionId.Value);
                            cmd.Parameters.AddWithValue("@cantidad", descuento);
                            cmd.Parameters.AddWithValue("@mes", mes);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar la deducción por faltas: " + ex.Message, ex);
                }
            }
        }
    

}

}