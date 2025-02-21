using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Reporteria
{
    public class Controlador
    {
        Capa_Modelo_Reporteria.Sentencias sentencias = new Capa_Modelo_Reporteria.Sentencias();

        public DataTable MostrarReportes()
        {
            OdbcDataAdapter data = sentencias.DisplayReportes();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        // Realizado por: Angel Gerardo Ajanel Tol - 0901-21-10584
        public int guardarReporte(TextBox idReporte, string sRuta, string sNombre_archivo, string sAplicacion, string sEstado, string sModulo)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text) || string.IsNullOrEmpty(sRuta) || string.IsNullOrEmpty(sNombre_archivo) ||
                string.IsNullOrEmpty(sAplicacion) || string.IsNullOrEmpty(sEstado) || string.IsNullOrEmpty(sModulo))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarReporte(idReporte.Text, sRuta, sNombre_archivo, sAplicacion, sEstado, sModulo);
                return 1;
            }
        }

        public int borrar_reporte(TextBox idReporte)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar el reporte #" + idReporte.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarReporte(idReporte.Text);
                    return 1;
                }
            }
        }

        // Realizado por: Francisco Javier Chamo Morales - 0901-21-17951
        public int ModReporteria(string sRuta, string sNombre_archivo, string sAplicacion, string sEstado, TextBox idReporte, string sModulo)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text) || string.IsNullOrEmpty(sRuta) || string.IsNullOrEmpty(sNombre_archivo) ||
                string.IsNullOrEmpty(sAplicacion) || string.IsNullOrEmpty(sEstado) || string.IsNullOrEmpty(sModulo))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere barrar el reporte
                DialogResult result = MessageBox.Show("¿Desea Modificar el reporte #" + idReporte.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se modifico el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    //aqui con los datos que recibimos de la capavista a hora la mandamos a la funicon ModificarReporte en sentencias.cs
                    sentencias.ModificarReporte(sRuta, sNombre_archivo, sAplicacion, sEstado, idReporte.Text, sModulo);
                    return 1;
                }
            }
        }

        public DataTable queryReporteria(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryReportes(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        // Realizado por: José Andrés Verón Canel - 0901-21-9780
        public string queryRuta(string aplicacion)
        {
            string sRuta;
            if (string.IsNullOrEmpty(aplicacion))
            {
                MessageBox.Show("No existe una aplicación valida");
                return "0";
            }
            else
            {
                sRuta = sentencias.queryRutastring(aplicacion);
                if (sRuta != "")
                {
                    return sRuta;
                }
                else
                {
                    return "0";
                }
            }
        }

        public List<string> listadoAplicaciones()
        {
            List<string> applicationCodes = sentencias.getAplicaciones();
            return applicationCodes;
        }

        // Realizado por: Elvir Amarildo Sandoval Pleitez - 0901-21-5538
        public List<string> listadoModulos()
        {
            List<string> moduleCodes = sentencias.getModulos();
            return moduleCodes;
        }

        public String getNextId()
        {
            int nextId = sentencias.getMaxIdReport();
            nextId = nextId + 1;
            return nextId.ToString();
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
