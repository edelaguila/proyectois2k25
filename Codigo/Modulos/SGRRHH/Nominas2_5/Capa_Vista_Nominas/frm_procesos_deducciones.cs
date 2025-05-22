using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Nominas
{
    public partial class frm_procesos_deducciones : Form
    {
        String idUsuario;
        //Metodos para que se abra solamente una ventana y no multiples
        //private static frm_procesos_deducciones instancia = null;
        //public static frm_procesos_deducciones ventana_unica()
        //{
        //    if (instancia == null || instancia.IsDisposed)
        //    {
        //        instancia = new frm_procesos_deducciones();
        //    }
        //    return instancia;
        //}
        public frm_procesos_deducciones(String idUsuario)
        {
            InitializeComponent();



        }
    }
}
