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
    public partial class frm_reportes : Form
    {
        //Metodos para que se abra solamente una ventana y no multiples
        private static frm_reportes instancia = null;
        public static frm_reportes ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_reportes();
            }
            return instancia;
        }
        public frm_reportes()
        {
            InitializeComponent();
        }
    }
}
