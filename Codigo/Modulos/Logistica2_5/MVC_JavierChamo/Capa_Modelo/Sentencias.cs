using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;

namespace Capa_Modelo
{
    public class Cls_Sentencias
    {
        private Conexion cn = new Conexion();

        // Lógica del módulo de mantenimiento de vehículos
        // (métodos de mantenimiento ya estandarizados previamente)

        // Lógica del módulo de movimiento de inventario
        public void Pro_InsertarMovimientoInventario(int i_estado, int i_fkIdProducto, int i_fkIdStock, int i_fkIdLocales)
        {
            OdbcConnection o_cn = cn.conexion();
            if (o_cn == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string s_query = "INSERT INTO tbl_movimiento_de_inventario (estado, fk_id_producto, fk_id_stock, fk_id_locales) VALUES (?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(s_query, o_cn);
                cmd.Parameters.AddWithValue("@estado", i_estado);
                cmd.Parameters.AddWithValue("@fk_id_producto", i_fkIdProducto);
                cmd.Parameters.AddWithValue("@fk_id_stock", i_fkIdStock);
                cmd.Parameters.AddWithValue("@fk_id_locales", i_fkIdLocales);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Movimiento de inventario agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el movimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.conexion();
            }
        }
        public void Pro_InsertarSolicitudMantenimiento(string s_nombreSolicitante, string s_tipoMantenimiento, string s_componenteAfectado, string d_fecha, string s_responsableAsignado, string s_codigoErrorProblema, string s_estadoMantenimiento, string s_tiempoEstimado, int i_idVehiculo)
        {
            OdbcConnection o_conn = cn.conexion();
            try
            {
                string s_query = "INSERT INTO tbl_mantenimiento (nombre_solicitante, tipo_de_mantenimiento, componente_afectado, fecha, responsable_asignado, codigo_error_problema, estado_del_mantenimiento, tiempo_estimado, fk_id_vehiculo) " +
                                "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);
                cmd.Parameters.AddWithValue("@nombre_solicitante", s_nombreSolicitante);
                cmd.Parameters.AddWithValue("@tipo_de_mantenimiento", s_tipoMantenimiento);
                cmd.Parameters.AddWithValue("@componente_afectado", s_componenteAfectado);
                cmd.Parameters.AddWithValue("@fecha", d_fecha);
                cmd.Parameters.AddWithValue("@responsable_asignado", s_responsableAsignado);
                cmd.Parameters.AddWithValue("@codigo_error_problema", s_codigoErrorProblema);
                cmd.Parameters.AddWithValue("@estado_del_mantenimiento", s_estadoMantenimiento);
                cmd.Parameters.AddWithValue("@tiempo_estimado", s_tiempoEstimado);
                cmd.Parameters.AddWithValue("@fk_id_vehiculo", i_idVehiculo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha ingresado de forma exitosa la solicitud");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar solicitud de mantenimiento: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                {
                    o_conn.Close();
                }
            }
        }

        public DataTable Fun_LlenarCmb(string s_tabla, string s_campoID)
        {
            OdbcConnection o_cn = cn.conexion();
            DataTable dt = new DataTable();

            try
            {
                if (o_cn.State == ConnectionState.Closed)
                {
                    o_cn.Open();
                }

                string s_queryComboBox = $"SELECT {s_campoID} FROM {s_tabla}";
                OdbcCommand cmd = new OdbcCommand(s_queryComboBox, o_cn);
                OdbcDataAdapter data = new OdbcDataAdapter(cmd);
                data.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (o_cn.State == ConnectionState.Open)
                {
                    cn.conexion();
                }
            }

            return dt;
        }

        public OdbcDataAdapter Fun_DisplayMovimientos()
        {
            string s_tablaMovimientoInventario = "tbl_movimiento_de_inventario";
            string s_sql = "SELECT * FROM " + s_tablaMovimientoInventario;
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(s_sql, cn.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + s_tablaMovimientoInventario);
            }
            return dataTable;
        }
        public OdbcDataAdapter Fun_DisplaySolicitudesMantenimiento()
        {
            string s_tablaMantenimiento = "tbl_mantenimiento";
            string s_sql = "SELECT * FROM " + s_tablaMantenimiento;
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(s_sql, cn.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + s_tablaMantenimiento);
            }
            return dataTable;
        }

        public void Pro_ModificarMovimientoInventario(int i_idMovimiento, int i_estado, int i_fkIdProducto, int i_fkIdStock, int i_fkIdLocales)
        {
            OdbcConnection o_cn = cn.conexion();
            if (o_cn == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string s_query = "UPDATE tbl_movimiento_de_inventario SET estado = ?, fk_id_producto = ?, fk_id_stock = ?, fk_id_locales = ? WHERE pk_id_movimiento = ?";
                OdbcCommand cmd = new OdbcCommand(s_query, o_cn);
                cmd.Parameters.AddWithValue("@estado", i_estado);
                cmd.Parameters.AddWithValue("@fk_id_producto", i_fkIdProducto);
                cmd.Parameters.AddWithValue("@fk_id_stock", i_fkIdStock);
                cmd.Parameters.AddWithValue("@fk_id_locales", i_fkIdLocales);
                cmd.Parameters.AddWithValue("@pk_id_movimiento", i_idMovimiento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha modificado de forma exitosa la solicitud");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo en la edición del movimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.conexion();
            }
        }

        public void Pro_EliminarMovimientoInventario(int i_idMovimiento)
        {
            OdbcConnection o_cn = cn.conexion();
            if (o_cn == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string s_query = "DELETE FROM tbl_movimiento_de_inventario WHERE pk_id_movimiento = ?";
                OdbcCommand cmd = new OdbcCommand(s_query, o_cn);
                cmd.Parameters.AddWithValue("@pk_id_movimiento", i_idMovimiento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Solicitud eliminada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la solicitud: " + ex.Message);
            }
            finally
            {
                cn.conexion();
            }
        }
        public void Pro_ModificarSolicitudMantenimiento(int i_idMantenimiento, string s_nombreSolicitante, string s_tipoMantenimiento, string s_componenteAfectado, string d_fecha, string s_responsableAsignado, string s_codigoErrorProblema, string s_estadoMantenimiento, string s_tiempoEstimado, int i_idVehiculo)
        {
            OdbcConnection o_conn = cn.conexion();
            try
            {
                string s_query = "UPDATE tbl_mantenimiento SET nombre_solicitante = ?, tipo_de_mantenimiento = ?, componente_afectado = ?, fecha = ?, responsable_asignado = ?, codigo_error_problema = ?, estado_del_mantenimiento = ?, tiempo_estimado = ?, fk_id_vehiculo = ? " +
                                 "WHERE pk_id_mantenimiento = ?";
                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);
                cmd.Parameters.AddWithValue("@nombre_solicitante", s_nombreSolicitante);
                cmd.Parameters.AddWithValue("@tipo_de_mantenimiento", s_tipoMantenimiento);
                cmd.Parameters.AddWithValue("@componente_afectado", s_componenteAfectado);
                cmd.Parameters.AddWithValue("@fecha", d_fecha);
                cmd.Parameters.AddWithValue("@responsable_asignado", s_responsableAsignado);
                cmd.Parameters.AddWithValue("@codigo_error_problema", s_codigoErrorProblema);
                cmd.Parameters.AddWithValue("@estado_del_mantenimiento", s_estadoMantenimiento);
                cmd.Parameters.AddWithValue("@tiempo_estimado", s_tiempoEstimado);
                cmd.Parameters.AddWithValue("@fk_id_vehiculo", i_idVehiculo);
                cmd.Parameters.AddWithValue("@pk_id_mantenimiento", i_idMantenimiento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha modificado de forma exitosa la solicitud");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar solicitud de mantenimiento: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                {
                    o_conn.Close();
                }
            }
        }
        public void Pro_EliminarSolicitudMantenimiento(int i_idMantenimiento)
        {
            OdbcConnection o_conn = cn.conexion();
            try
            {
                string s_query = "DELETE FROM tbl_mantenimiento WHERE pk_id_mantenimiento = ?";
                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);
                cmd.Parameters.AddWithValue("@pk_id_mantenimiento", i_idMantenimiento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Solicitud eliminada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la solicitud: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                {
                    o_conn.Close();
                }
            }
        }
        public void Pro_GenerarPDFMovimiento(int i_idMovimiento)
        {
            OdbcConnection o_conn = cn.conexion();
            OdbcDataReader dr = null;
            try
            {
                string s_query = "SELECT * FROM tbl_movimiento_de_inventario WHERE pk_id_movimiento = ?";
                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);
                cmd.Parameters.AddWithValue("@pk_id_movimiento", i_idMovimiento);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string s_idMovimiento = dr["pk_id_movimiento"].ToString();
                    string s_estado = dr["estado"].ToString();
                    string s_fkIdProducto = dr["fk_id_producto"].ToString();
                    string s_fkIdStock = dr["fk_id_stock"].ToString();
                    string s_fkIdLocales = dr["fk_id_locales"].ToString();

                    Document doc = new Document();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string s_filePath = Path.Combine(desktopPath, "movimiento_" + i_idMovimiento + ".pdf");
                    PdfWriter.GetInstance(doc, new FileStream(s_filePath, FileMode.Create));
                    doc.Open();

                    // Título Principal
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    doc.Add(new Paragraph("Informe de Movimiento de Inventario", titleFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph(" "));

                    // Información General
                    var sectionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                    doc.Add(new Paragraph("Datos del Movimiento", sectionFont));
                    doc.Add(new Paragraph(" "));

                    var contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    doc.Add(new Paragraph("ID de Movimiento: " + s_idMovimiento, contentFont));
                    doc.Add(new Paragraph("Estado del Movimiento: " + s_estado, contentFont));
                    doc.Add(new Paragraph("ID de Producto: " + s_fkIdProducto, contentFont));
                    doc.Add(new Paragraph("ID de Stock: " + s_fkIdStock, contentFont));
                    doc.Add(new Paragraph("ID de Local: " + s_fkIdLocales, contentFont));
                    doc.Add(new Paragraph(" "));

                    // Firma
                    doc.Add(new Paragraph("Firma del Responsable: _______________________", sectionFont));
                    doc.Add(new Paragraph(" "));

                    // Pie de página con fecha y hora
                    var footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8);
                    doc.Add(new Paragraph("Documento generado automáticamente - Fecha y Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), footerFont) { Alignment = Element.ALIGN_RIGHT });

                    doc.Close();

                    MessageBox.Show("PDF generado con éxito: " + s_filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la solicitud ingresada: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                {
                    o_conn.Close();
                }
            }
        }
        public void Pro_GenerarPDFMantenimiento(int i_idMantenimiento)
        {
            OdbcConnection o_conn = cn.conexion();
            OdbcDataReader dr = null;
            try
            {
                string s_query = "SELECT * FROM tbl_mantenimiento WHERE pk_id_mantenimiento = ?";
                OdbcCommand cmd = new OdbcCommand(s_query, o_conn);
                cmd.Parameters.AddWithValue("@pk_id_mantenimiento", i_idMantenimiento);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string s_idMantenimiento = dr["pk_id_mantenimiento"].ToString();
                    string s_nombreSolicitante = dr["nombre_solicitante"].ToString();
                    string s_tipoMantenimiento = dr["tipo_de_mantenimiento"].ToString();
                    string s_componenteAfectado = dr["componente_afectado"].ToString();
                    string s_fecha = dr["fecha"].ToString();
                    string s_responsableAsignado = dr["responsable_asignado"].ToString();
                    string s_codigoErrorProblema = dr["codigo_error_problema"].ToString();
                    string s_estado = dr["estado_del_mantenimiento"].ToString();
                    string s_tiempoEstimado = dr["tiempo_estimado"].ToString();
                    string s_fkIdVehiculo = dr["fk_id_vehiculo"].ToString();

                    Document doc = new Document();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string s_filePath = Path.Combine(desktopPath, "mantenimiento_" + i_idMantenimiento + ".pdf");
                    PdfWriter.GetInstance(doc, new FileStream(s_filePath, FileMode.Create));
                    doc.Open();

                    // Título Principal
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    doc.Add(new Paragraph("Datos del Mantenimiento a Realizar al Vehículo", titleFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph(" "));

                    // Información de la Solicitud
                    var sectionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    doc.Add(new Paragraph("Información de la Solicitud", sectionFont));
                    doc.Add(new Paragraph("ID de la solicitud: " + s_idMantenimiento));
                    doc.Add(new Paragraph("Nombre del solicitante: " + s_nombreSolicitante));
                    doc.Add(new Paragraph("Fecha de solicitud: " + s_fecha));
                    doc.Add(new Paragraph(" "));

                    // Detalles del Mantenimiento
                    doc.Add(new Paragraph("Detalles del Mantenimiento Solicitado", sectionFont));
                    doc.Add(new Paragraph("Tipo de Mantenimiento: " + s_tipoMantenimiento));
                    doc.Add(new Paragraph("Componente del vehículo: " + s_componenteAfectado));
                    doc.Add(new Paragraph("Mecánico Asignado: " + s_responsableAsignado));
                    doc.Add(new Paragraph("Problema Reportado: " + s_codigoErrorProblema));
                    doc.Add(new Paragraph("Estado de la Solicitud: " + s_estado));
                    doc.Add(new Paragraph("Tiempo Estimado: " + s_tiempoEstimado));
                    doc.Add(new Paragraph("ID del Vehículo en taller: " + s_fkIdVehiculo));
                    doc.Add(new Paragraph(" "));

                    // Firma
                    doc.Add(new Paragraph("Firma del Mecánico a Cargo: _______________________", sectionFont));
                    doc.Add(new Paragraph(" "));

                    // Pie de Página
                    var footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 8);
                    doc.Add(new Paragraph("Documento generado automáticamente - Fecha y Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), footerFont) { Alignment = Element.ALIGN_RIGHT });

                    doc.Close();

                    MessageBox.Show("PDF generado con éxito: " + s_filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la solicitud ingresada: " + ex.Message);
            }
            finally
            {
                if (o_conn != null && o_conn.State == ConnectionState.Open)
                {
                    o_conn.Close();
                }
            }
        }
    }
}



