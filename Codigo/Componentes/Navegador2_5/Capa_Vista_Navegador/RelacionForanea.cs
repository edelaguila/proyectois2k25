using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Vista_Navegador
{
    public class RelacionForanea
    {
        public string sTablaPrincipal { get; set; }
        public string sTablaRelacionada { get; set; }
        public string sCampoDescriptivo { get; set; }
        public string sColumnaForanea { get; set; }
        public string sColumnaPrimariaRelacionada { get; set; }

        // Constructor que inicializa las propiedades
        public RelacionForanea(string tabla, string tablarela, string campoDescri, string columnaFora, string columnaPrimaria)
        {
            sTablaPrincipal = tabla;
            sTablaRelacionada = tablarela;
            sCampoDescriptivo = campoDescri;
            sColumnaForanea = columnaFora;
            sColumnaPrimariaRelacionada = columnaPrimaria;
        }
    }
}
