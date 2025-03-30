using System;
using System.Windows.Forms;

namespace Capa_Vista_RRHH
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI_RRHH("Admin")); // Por defecto se ejecuta como Admin
        }
    }
} 