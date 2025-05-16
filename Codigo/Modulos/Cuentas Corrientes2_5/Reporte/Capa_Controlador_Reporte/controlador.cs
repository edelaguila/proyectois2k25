using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Reporte
{
    public class controlador
    {
        Capa_Modelo_Reporte.Sentencias sentencias = new Capa_Modelo_Reporte.Sentencias();

        public DataTable queryDeudaP(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryProv(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public DataTable queryDeudaC(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryCliente(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public DataTable queryDeudaPConFecha(string idProveedor, DateTime fechaInicio, DateTime fechaFin)
        {
            OdbcDataAdapter data2 = sentencias.queryProvConFecha(idProveedor, fechaInicio, fechaFin);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

    }
}
