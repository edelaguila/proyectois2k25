using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace Capa_Modelo_JDSC
{
    public class Sentencias
    {
        private readonly Conexion cn = new Conexion();

        // Método para cargar las existencias de una bodega en particular (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            OdbcDataReader dr = null;
            OdbcConnection conn = null; // Mover la conexión aquí para poder cerrarla manualmente
            try
            {
                conn = cn.conexion();
                string query = $"SELECT * FROM TBL_EXISTENCIAS_BODEGA WHERE Fk_ID_BODEGA = '{idBodega}'";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener existencias: " + ex.Message);
                dr = null; // Asegurarse de que dr sea null en caso de error
            }
            finally
            {
                // Cerramos la conexión después de que se haya leído el DataReader
                if (dr != null && dr.IsClosed)
                {
                    conn?.Close();
                }
            }
            return dr;
        }


        public void GenerarPDFAuditoria(int idAuditoria)
        {
            OdbcConnection conn = cn.conexion();
            OdbcDataReader dr = null;
            try
            {
                // Consulta de la tabla de auditorías
                string query = "SELECT * FROM TBL_AUDITORIAS WHERE Pk_ID_AUDITORIA = ?";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idAuditoria);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Obtener los datos de la auditoría
                    string ID_Auditoria = Convert.ToString(dr["Pk_ID_AUDITORIA"]);
                    string ID_Bodega = Convert.ToString(dr["Fk_ID_BODEGA"]);
                    string ID_Producto = Convert.ToString(dr["Fk_ID_PRODUCTO"]);
                    string FechaAuditoria = Convert.ToString(dr["FECHA_AUDITORIA"]);
                    string DiscrepanciaDetectada = Convert.ToBoolean(dr["DISCREPANCIA_DETECTADA"]) ? "Sí" : "No";
                    string CantidadRegistrada = Convert.ToString(dr["CANTIDAD_REGISTRADA"]);
                    string CantidadFisica = Convert.ToString(dr["CANTIDAD_FISICA"]);
                    string Observaciones = Convert.ToString(dr["OBSERVACIONES"]);

                    // Crear el PDF
                    Document doc = new Document();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "auditoria_" + idAuditoria + ".pdf");
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // Añadir los datos al PDF
                    doc.Add(new Paragraph("INFORME DE AUDITORÍA DE EXISTENCIAS"));
                    doc.Add(new Paragraph("ID de Auditoría: " + ID_Auditoria));
                    doc.Add(new Paragraph("ID de Bodega: " + ID_Bodega));
                    doc.Add(new Paragraph("ID de Producto: " + ID_Producto));
                    doc.Add(new Paragraph("Fecha de Auditoría: " + FechaAuditoria));
                    doc.Add(new Paragraph("Discrepancia Detectada: " + DiscrepanciaDetectada));
                    doc.Add(new Paragraph("Cantidad Registrada: " + CantidadRegistrada));
                    doc.Add(new Paragraph("Cantidad Física: " + CantidadFisica));
                    doc.Add(new Paragraph("Observaciones: " + Observaciones));
                    doc.Add(new Paragraph("Firma del Responsable: _______________________"));

                    // Cerrar el documento
                    doc.Close();
                    MessageBox.Show("PDF generado con éxito: " + filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la auditoría ingresada: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Cerrar la conexión
                }
            }
        }





        public string InsertarAuditoria(int idBodega, int idProducto, DateTime fechaAuditoria, string observaciones, int cantidadRegistrada, int cantidadFisica, bool discrepancia)
        {
            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = @"INSERT INTO TBL_AUDITORIAS (Fk_ID_BODEGA, Fk_ID_PRODUCTO, FECHA_AUDITORIA, OBSERVACIONES, CANTIDAD_REGISTRADA, CANTIDAD_FISICA, DISCREPANCIA_DETECTADA)
                                     VALUES (?, ?, ?, ?, ?, ?, ?);";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.Add("?", OdbcType.Int).Value = idBodega;
                        cmd.Parameters.Add("?", OdbcType.Int).Value = idProducto;
                        cmd.Parameters.Add("?", OdbcType.DateTime).Value = fechaAuditoria;
                        cmd.Parameters.Add("?", OdbcType.VarChar).Value = observaciones;
                        cmd.Parameters.Add("?", OdbcType.Int).Value = cantidadRegistrada;
                        cmd.Parameters.Add("?", OdbcType.Int).Value = cantidadFisica;
                        cmd.Parameters.Add("?", OdbcType.Bit).Value = discrepancia;

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Auditoría realizada con éxito";
            }
            catch (Exception ex)
            {
                return "Error al realizar auditoría: " + ex.Message;
            }
        }

        public List<KeyValuePair<int, string>> GetBodegas()
        {
            List<KeyValuePair<int, string>> bodegas = new List<KeyValuePair<int, string>>();
            string sQuery = "SELECT Pk_ID_BODEGA, NOMBRE_BODEGA FROM TBL_BODEGAS;";

            using (OdbcConnection conn = cn.conexion())
            {
                try
                {
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conn);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        int idBodega = Convert.ToInt32(row["Pk_ID_BODEGA"]);
                        string nombreBodega = row["NOMBRE_BODEGA"].ToString();
                        bodegas.Add(new KeyValuePair<int, string>(idBodega, nombreBodega));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " \nNo se pudo consultar la tabla TBL_BODEGAS");
                }
            }

            return bodegas;
        }

        public List<KeyValuePair<int, string>> GetProductos()
        {
            List<KeyValuePair<int, string>> productos = new List<KeyValuePair<int, string>>();
            string sQuery = "SELECT Pk_id_Producto, nombreProducto FROM Tbl_Productos;";

            using (OdbcConnection conn = cn.conexion())
            {
                try
                {
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conn);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        int idProducto = Convert.ToInt32(row["Pk_id_Producto"]);
                        string nombreProducto = row["nombreProducto"].ToString();
                        productos.Add(new KeyValuePair<int, string>(idProducto, nombreProducto));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " \nNo se pudo consultar la tabla Tbl_Productos");
                }
            }

            return productos;
        }

        public List<string> GetProductosPorBodega(string idBodega)
        {
            List<string> productos = new List<string>();
            string sQuery = @"
        SELECT p.nombreProducto 
        FROM TBL_EXISTENCIAS_BODEGA e
        JOIN Tbl_Productos p ON e.Fk_ID_PRODUCTO = p.Pk_id_Producto
        WHERE e.Fk_ID_BODEGA = ?";

            using (OdbcConnection conn = cn.conexion())
            {
                try
                {
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.Add("?", OdbcType.Int).Value = int.Parse(idBodega);
                        OdbcDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            productos.Add(reader["nombreProducto"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " \nNo se pudo consultar la tabla Tbl_Productos");
                }
            }

            return productos;
        }


        public DataTable ObtenerAuditorias()
        {
            DataTable dtAuditorias = new DataTable();

            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = "SELECT * FROM TBL_AUDITORIAS";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(dtAuditorias);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener auditorías: " + ex.Message);
            }

            return dtAuditorias;
        }

        public string modRuta(string idAyuda)
        {
            string sRuta = "";
            string sSql = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, cn.conexion()))
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

            using (OdbcCommand command = new OdbcCommand(sSql, cn.conexion()))
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