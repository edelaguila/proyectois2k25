using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_PercepcionesDeducciones
{
    public class Sentencias
    {
        Conexion cn = new Conexion(); //Conexion con base de datos

        //// Método para obtener las deducciones calculadas
        public OdbcDataAdapter ObtenerPercepciones()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"
         SELECT 
             emp.empleados_nombre AS Nombre, 
             emp.empleados_apellido AS Apellido, 
             ded.dedu_perp_concepto AS Concepto, 
             ded.dedu_perp_tipo AS Tipo, 
             dp.dedu_perp_emp_cantidad AS Cantidad
         FROM 
             tbl_dedu_perp_emp dp
         INNER JOIN 
             tbl_empleados emp ON dp.Fk_clave_empleado = emp.pk_clave
         INNER JOIN 
             tbl_dedu_perp ded ON dp.fk_dedu_perp = ded.pk_dedu_perp
         WHERE 
             dp.estado = 1
             AND ded.dedu_perp_clase = 'Percepcion';";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                // Lanzar la excepción para que sea manejada en capas superiores
                throw new Exception("Error al obtener las percepciones: " + ex.Message, ex);
            }
        }

        public OdbcDataAdapter ObtenerDeducciones()
        {
            // Consulta con JOIN para obtener el nombre del empleado y el tipo de deducción
            string query = @"
          SELECT 
              emp.empleados_nombre AS Nombre, 
              emp.empleados_apellido AS Apellido, 
              ded.dedu_perp_concepto AS Concepto, 
              ded.dedu_perp_tipo AS Tipo, 
              dp.dedu_perp_emp_cantidad AS Cantidad
          FROM 
              tbl_dedu_perp_emp dp
          INNER JOIN 
              tbl_empleados emp ON dp.Fk_clave_empleado = emp.pk_clave
          INNER JOIN 
              tbl_dedu_perp ded ON dp.fk_dedu_perp = ded.pk_dedu_perp
          WHERE 
              dp.estado = 1
              AND ded.dedu_perp_clase = 'Deduccion';";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());

                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                // Lanzar la excepción para que sea manejada en capas superiores
                throw new Exception("Error al obtener las deducciones: " + ex.Message, ex);
            }
        }

        public OdbcDataAdapter ObtenerDepartamentos()
        {
            // Consulta para obtener los departamentos activos únicos por nombre
            string query = @"
            SELECT 
                MIN(pk_id_departamento) AS pk_id_departamento, 
                departamentos_nombre_departamento, 
                MIN(departamentos_descripcion) AS departamentos_descripcion
            FROM 
                tbl_departamentos 
            WHERE 
                estado = 1
            GROUP BY 
                departamentos_nombre_departamento;";

            try
            {
                // Crear el adaptador con la consulta
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, cn.conexion());
                // Retornar el adaptador con los datos obtenidos
                return adapter;
            }
            catch (OdbcException ex)
            {
                // Lanzar la excepción para que sea manejada en capas superiores
                throw new Exception("Error al obtener los departamentos: " + ex.Message, ex);
            }
        }






        ///*************************************************************************/
    }
}
