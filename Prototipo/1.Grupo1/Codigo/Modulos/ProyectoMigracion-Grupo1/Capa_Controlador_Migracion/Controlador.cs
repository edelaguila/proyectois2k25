using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Migracion;
using System.Data;
using System.Data.Odbc;

namespace Capa_Controlador_Migracion
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        //CODIGO DE EJEMPLO
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
