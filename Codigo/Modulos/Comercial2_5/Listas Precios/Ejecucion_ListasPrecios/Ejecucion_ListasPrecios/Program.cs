using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_ListaPrecios;

namespace Ejecucion_ListasPrecios
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
            // Define un valor para idUsuario
            string idUsuario = "1"; // Reemplaza esto con el valor adecuado

            // Pasar el idUsuario al constructor
            //Application.Run(new Capa_Vista_CompraVenta.Frm_MDI_general_CompraVenta(idUsuario));
            Application.Run(new frm_ListadoInicio(idUsuario));
        }
    }
}
