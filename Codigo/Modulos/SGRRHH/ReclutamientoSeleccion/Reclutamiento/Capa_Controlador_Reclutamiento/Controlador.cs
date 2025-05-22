using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Reclutamiento;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Capa_Controlador_Reclutamiento
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();
        public void Pro_guardar(int Fk_id_postulante, string curriculum, string doc_entrevista, int logica, int numerica, int verbal, int razonamiento, int tecnologica, string personalidad, string pruebas_completas)
        {

            if (Fk_id_postulante != 0)
            {
                sn.Fun_guardar(Fk_id_postulante, curriculum, doc_entrevista, logica, numerica, verbal, razonamiento, tecnologica, personalidad, pruebas_completas); // Llama al método de la clase Sentencias
            }
            else
            {
                throw new ArgumentException("El Id del expediente no puede estar vacío.");
            }
        }

        public bool Pro_expedienteExiste(int idPostulante)
        {
            return sn.ExpedienteExiste(idPostulante);
        }

        public void Pro_actualizar(int idExpediente, int Fk_id_postulante, string curriculum, string doc_entrevista, int logica, int numerica, int verbal, int razonamiento, int tecnologica, string personalidad, string pruebas_completas)
        {
            if (idExpediente != 0)
            {
                sn.Fun_actualizar(idExpediente, Fk_id_postulante, curriculum, doc_entrevista, logica, numerica, verbal, razonamiento, tecnologica, personalidad, pruebas_completas);
            }
            else
            {
                throw new ArgumentException("El ID del expediente no puede estar vacío.");
            }
        }

        public void Pro_eliminarExpediente(int id)
        {
            
            sn.Fun_Eliminar(id);
        }



        public DataTable Pro_obtenerExpedientes()
        {
            return sn.ObtenerExpedientes();
        }

        public List<KeyValuePair<int, string>> ObtenerListaPostulantes()
        {
            return sn.ObtenerPostulantes();
        }

        public void VerArchivoPDF(string campo, int idPostulante)
        {
            string rutaBase = Path.Combine(Path.GetTempPath(), $"{campo}_{idPostulante}");

            // para revisar si se recupero el archivo
            bool archivoGuardado = sn.GuardarArchivoRecuperado(campo, idPostulante, rutaBase);

            if (!archivoGuardado)
            {
                MessageBox.Show("No se encontró ningún archivo para este postulante.");
                return;
            }

            string[] posiblesExtensiones = { ".pdf", ".docx", ".bin" };
            foreach (var ext in posiblesExtensiones)
            {
                string rutaFinal = rutaBase + ext;
                if (File.Exists(rutaFinal))
                {
                    System.Diagnostics.Process.Start(rutaFinal);
                    return;
                }
            }

            MessageBox.Show("No se pudo abrir el archivo recuperado.");
        }



        public DataRow Pro_ObtenerExpedientePorId(int id)
        {
            DataTable dt = sn.ObtenerExpedientePorId(id);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }



    }
}
