using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecucion_EvaluacionDesempenio
{
    static class Program
    {
        /// Punto de entrada principal para la aplicación
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Capa_Vista_Evaluacion.Frm_Resultados_Evaluacion());
            Application.Run(new Capa_Vista_Evaluacion.Frm_Bonos_Promociones());
        }
    }
}
