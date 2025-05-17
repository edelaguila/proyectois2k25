using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Planilla
{
    public class Comision
    {
        public int Pk_id_comisionEnc { get; set; }
        public int Fk_id_vendedor { get; set; }
        public DateTime Comisiones_fecha_ { get; set; }
        public decimal Comisiones_total_venta { get; set; }
        public decimal Comisiones_total_comision { get; set; }
    }
}
