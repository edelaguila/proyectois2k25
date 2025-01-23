using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_EstadosFinancieros;

namespace Capa_Controlador_EstadosFinancieros
{
    public class controlador
    {
        // LLenar una tabla CAPA CONTROLADOR

        sentencias sn = new sentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        
    }
}
