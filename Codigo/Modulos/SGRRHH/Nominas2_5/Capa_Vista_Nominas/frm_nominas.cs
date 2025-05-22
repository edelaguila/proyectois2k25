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
    public partial class frm_nominas : Form
    {
        //Metodos para que se abra solamente una ventana y no multiples
        private static frm_nominas instancia = null;
        public static frm_nominas ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_nominas();
            }
            return instancia;
        }
        public frm_nominas()
        {
            InitializeComponent();
        }
    }
}
