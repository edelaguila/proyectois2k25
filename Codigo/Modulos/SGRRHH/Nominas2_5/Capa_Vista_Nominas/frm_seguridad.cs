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
    public partial class frm_seguridad : Form
    {
        //Metodos para que se abra solamente una ventana y no multiples
        private static frm_seguridad instancia = null;
        public static frm_seguridad ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_seguridad();
            }
            return instancia;
        }
        public frm_seguridad()
        {
            InitializeComponent();
        }
    }
}
