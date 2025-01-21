using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc; // Para OdbcDataReader
using Capa_Modelo_JDSC; // Para Sentencias
using System.Data;
using System.Windows.Forms;

namespace Capa_Controlador_JDSC
{
    public class Controlador
    {
        private Sentencias sentencias; // Instancia de la clase Sentencias

        public Controlador()
        {
            // Inicializa la instancia de Sentencias
            sentencias = new Sentencias();
        }

     

        // Método para obtener existencias de una bodega (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            return sentencias.ObtenerExistenciasBodega(idBodega);
        }

        
        // Método para cargar existencias (puede agregar más lógica si es necesario) (Realizado por Daniel Sierra 0901-21-12740)
       

        public void CargarExistencias(string idBodega, DataTable dtExistencias)
        {
            using (OdbcDataReader dr = ObtenerExistenciasBodega(idBodega))
            {
                if (dr != null)
                {
                    try
                    {
                        if (!dr.HasRows) // Verifica si hay filas
                        {
                            throw new Exception("No hay existencias en esta bodega.");
                        }
                        dtExistencias.Load(dr); // Carga los datos en el DataTable
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al cargar las existencias: " + ex.Message);
                    }
                    finally
                    {
                        dr.Close(); // Asegúrate de cerrar el DataReader
                    }
                }
                else
                {
                    throw new Exception("No se pudieron obtener existencias para la bodega seleccionada.");
                }
            }
        }






        // Método para obtener las bodegas
        public List<KeyValuePair<int, string>> listadoBodegas()
        {
            return sentencias.GetBodegas(); // Llama al método actualizado
        }

        // Método para obtener productos
        public List<KeyValuePair<int, string>> listadoProductos()
        {
            return sentencias.GetProductos(); // Llama al método actualizado
        }

        // Método para realizar auditoría
        public void RealizarAuditoria(int idBodega, int idProducto, DateTime fechaAuditoria, string observaciones, int cantidadRegistrada, int cantidadFisica, bool discrepancia, DataGridView dgvAuditorias)

        {
            try
            {
                // Llamar al método para insertar auditoría
                string resultado = sentencias.InsertarAuditoria(idBodega, idProducto, fechaAuditoria, observaciones, cantidadRegistrada, cantidadFisica, discrepancia);

                // Comprobar el resultado de la inserción
                if (resultado == "Auditoría realizada con éxito")
                {
                    MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAuditorias(dgvAuditorias); // Actualizar DataGridView
                }
                else
                {
                    MessageBox.Show("Error al realizar auditoría: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar el reporte en el controlador
        public void CargarReporte(int pk_id_auditoria)
        {
            // Llama al método GenerarReporte de la clase Sentencias
            sentencias.GenerarPDFAuditoria(pk_id_auditoria);
        }


        // Método para cargar auditorías
        public void CargarAuditorias(DataGridView dgvAuditorias)
        {
            try
            {
                DataTable dtAuditorias = sentencias.ObtenerAuditorias();
                dgvAuditorias.DataSource = dtAuditorias;

                // Configura las columnas según sea necesario
                if (dtAuditorias.Columns.Count > 0)
                {
                    dgvAuditorias.Columns[0].HeaderText = "ID Auditoría"; // Pk_ID_AUDITORIA
                    dgvAuditorias.Columns[1].HeaderText = "Bodega"; // Fk_ID_BODEGA
                    dgvAuditorias.Columns[2].HeaderText = "Producto"; // Fk_ID_PRODUCTO
                    dgvAuditorias.Columns[3].HeaderText = "Fecha Auditoría"; // FECHA_AUDITORIA
                    dgvAuditorias.Columns[4].HeaderText = "Discrepancia"; // DISCREPANCIA_DETECTADA
                    dgvAuditorias.Columns[5].HeaderText = "Cantidad Registrada"; // CANTIDAD_REGISTRADA
                    dgvAuditorias.Columns[6].HeaderText = "Cantidad Física"; // CANTIDAD_FISICA
                    dgvAuditorias.Columns[7].HeaderText = "Observaciones"; // OBSERVACIONES
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string MIndice(string Indice1)
        {
            string indice = sentencias.modIndice(Indice1);

            return indice;
        }

        public string MRuta(string Ruta1)
        {
            string ruta = sentencias.modRuta(Ruta1);

            return ruta;
        }
    }
}
