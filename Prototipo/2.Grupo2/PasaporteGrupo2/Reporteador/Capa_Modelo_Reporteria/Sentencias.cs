using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo_Reporteria
{
    public class Sentencias
    {
        string sTabla_reporteria = "tbl_regreporteria";
        Conexion conexion = new Conexion();
        public OdbcDataAdapter DisplayReportes()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT idregistro, ruta, nombre_archivo, aplicacion, estado, fk_id_modulos FROM " + sTabla_reporteria + " WHERE idregistro IS NOT NULL AND idregistro != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_reporteria);
            }
            return dataTable;
        }

        // Realizado por: Wendy Elizabeth Sacayon Fajardo - 0901-21-135
        public void registrarReporte(string id_reporte, string ruta, string nombre_archivo, string aplicacion, string estado, string modulo)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "idregistro, ruta, nombre_archivo, aplicacion, estado, fk_id_aplicacion, fk_id_modulos";
                string sSql = "INSERT INTO " + sTabla_reporteria + " (" + sCampos + ") VALUES ('" + id_reporte + "', '" + ruta + "', '" + nombre_archivo + "', '" + aplicacion + "', '" + estado + "', '" + aplicacion + "', '" + modulo + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_reporteria);
            }
        }
        public void eliminarReporte(string sId_reporte)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + sTabla_reporteria + " where idregistro = " + sId_reporte + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_reporte + " en la tabla " + sTabla_reporteria);
            }
        }

        // Realizado por: Miguel Alexander Crisóstomo Aguilón - 0901-19-20485
        public void ModificarReporte(string sRuta, string sNombre_archivo, string sAplicacion, string sEstado, string sId_reporte, string sModulo)
        {
            //aqui estamos haciendo la comprobación de que si tuvo una conexión con la base de datos
            try
            {
                //aqui con los datos recibidos le mandamos la instruccion a la base de datos, para poderlo modificar lo buscamos por id
                string sql = "UPDATE " + sTabla_reporteria + " SET " + "ruta = '" + sRuta + "'," + " nombre_archivo = '" + sNombre_archivo + "'," + " aplicacion = '" + sAplicacion + "'," + " estado = '" + sEstado + "'," + " fk_id_aplicacion = '" + sAplicacion + "'," + " fk_id_modulos = '" + sModulo + "' " + " WHERE (idregistro = '" + sId_reporte + "');";
                OdbcCommand consulta = new OdbcCommand(sql, conexion.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Modificado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en CapaModeloReporteria --> Sentencias" + e);
            }
        }

        public OdbcDataAdapter queryReportes(string sQuery)
        {
            string sql = "SELECT idregistro, ruta, nombre_archivo, aplicacion, estado, fk_id_modulos FROM " + sTabla_reporteria + " WHERE ruta LIKE '%" + sQuery + "%' OR nombre_archivo LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        // Realizado por: Pedro Alejandro Citalán Herrera - 0901-20-16151
        public string queryRutastring(string sQuery)
        {
            string sql = "SELECT ruta FROM " + sTabla_reporteria + " WHERE aplicacion LIKE '%" + sQuery + "%';";
            string archivoruta;

            OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());

            using (OdbcDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string sRuta = reader["ruta"].ToString();
                    archivoruta = sRuta;
                    return archivoruta;
                }
                else
                {
                    MessageBox.Show("No se pudo hallar el nombre del archivo");
                    return "0";
                }
            }
        }
        public List<string> getAplicaciones()
        {
            string sQuery = "SELECT pk_id_aplicacion, estado_aplicacion FROM tbl_aplicaciones;";
            List<string> applicationCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_aplicacion"].ToString().Equals("1"))
                    {
                        string sCodigoAplicacion = row["pk_id_aplicacion"].ToString();
                        applicationCodes.Add(sCodigoAplicacion);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_reporteria);
            }

            return applicationCodes;
        }

        // Realizado por Ammy Patricia Catún López - 0901-21-4857
        public List<string> getModulos()
        {
            string sQuery = "SELECT pk_id_modulos, estado_modulo FROM tbl_modulos;";
            List<string> moduleCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_modulo"].ToString().Equals("1"))
                    {
                        string sCodigoAplicacion = row["pk_id_modulos"].ToString();
                        moduleCodes.Add(sCodigoAplicacion);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_reporteria);
            }

            return moduleCodes;
        }
        public int getMaxIdReport()
        {
            int iIdRegistro = 0;
            string sSql = "SELECT max(idRegistro) FROM " + sTabla_reporteria + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iIdRegistro = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_reporteria);
            }
            return iIdRegistro;
        }

        public string modRuta(string idAyuda)
        {
            string sRuta = "";
            string sSql = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, conexion.conexion()))
            {
                command.Parameters.AddWithValue("id_ayuda", idAyuda);
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

        public string modIndice(string idAyuda)
        {
            string sIndice = "";
            string sSql = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, conexion.conexion()))
            {
                command.Parameters.AddWithValue("Id_ayuda", idAyuda);
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

    }
}
