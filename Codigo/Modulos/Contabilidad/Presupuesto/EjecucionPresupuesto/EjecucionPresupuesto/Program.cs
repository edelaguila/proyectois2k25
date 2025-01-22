using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Presupuesto;

namespace EjecucionPresupuesto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            Application.Run(new Capa_Vista_Presupuesto.Presupuesto());
            //Application.Run(new Capa_Vista_Presupuesto.Incremento());
        }
    }
}
