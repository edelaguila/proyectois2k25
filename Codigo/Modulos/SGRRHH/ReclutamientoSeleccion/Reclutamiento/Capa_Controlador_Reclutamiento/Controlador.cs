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
        Sentencias sn = new Sentencias(); //Conexion con capa modelo
        public void Pro_guardar(int Pk_id_postulante, string curriculum, string doc_entrevista, int logica, int numerica, int verbal, int razonamiento, int tecnologica, string personalidad, string pruebas_completas)
        {

            if (Pk_id_postulante != 0)
            {
                sn.Fun_guardar(Pk_id_postulante, curriculum, doc_entrevista, logica, numerica, verbal, razonamiento, tecnologica, personalidad, pruebas_completas); // Llama al método de la clase Sentencias
            }
            else
            {
                throw new ArgumentException("El mes no puede estar vacío.");
            }
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
            var bytes = sn.ObtenerArchivo(campo, idPostulante);

            if (bytes != null)
            {
                string rutaTemp = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"{campo}_{idPostulante}.pdf");
                File.WriteAllBytes(rutaTemp, bytes);
                System.Diagnostics.Process.Start(rutaTemp); // Abre el PDF con el visor por defecto
            }
            else
            {
                MessageBox.Show("El archivo no está disponible.");
            }
        }
    }
}
