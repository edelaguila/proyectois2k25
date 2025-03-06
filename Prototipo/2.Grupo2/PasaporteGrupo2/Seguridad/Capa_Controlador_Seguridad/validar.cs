using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Seguridad
{
    public class validar
    {
        public static void CampoAlfanumerico(KeyPressEventArgs v)
        {
            if(Char.IsLetterOrDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if(Char.IsSeparator(v.KeyChar))
            {

                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }
    }
}
