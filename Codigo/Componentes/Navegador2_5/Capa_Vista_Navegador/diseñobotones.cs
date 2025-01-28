using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Navegador
{
    public static class BiselUtil
    {
        public static void AplicarBisel(Button btn, PaintEventArgs e)
        {
            // Dibujar el bisel
            ControlPaint.DrawBorder(e.Graphics, btn.ClientRectangle,
                                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                                    SystemColors.ControlDark, 2, ButtonBorderStyle.Inset,
                                    SystemColors.ControlDark, 2, ButtonBorderStyle.Inset);
        }
    }
}
