using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_GD;

namespace Capa_Controlador_GD
{
    public class Controlador
    {
        Sentencia Sn;
        public Controlador(string idUsuario)
        {
            Sn = new Sentencia(idUsuario);
        }

        public DataTable funconsultalogicafaltas()
        {
            try
            {
                OdbcDataAdapter dtFaltas = Sn.funconsultarfaltas();
                DataTable tableFaltas = new DataTable();
                dtFaltas.Fill(tableFaltas);
                return tableFaltas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool funInsertarEvidencia(int ifalta, string stipo, string sarchivo, int iestado)
        {
            return Sn.funInsertarEvidencia(ifalta, stipo, sarchivo, iestado);
        }
    }
}
