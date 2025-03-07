using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Capa_Vista_Pasaporte
{
    public partial class frm_tramite : Form
    {
        public frm_tramite()
        {
            InitializeComponent();

        }

        private void frm_tramite_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;  // Color del texto en negro


            // Crear una ruta para definir la forma del botón
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, button1.Width, button1.Height);  // Botón circular
            button1.Region = new Region(path);

            // Si quieres bordes redondeados en lugar de un círculo:
            int radius = 20; // Radio de la curva
            Rectangle bounds = new Rectangle(0, 0, button1.Width, button1.Height);
            GraphicsPath roundedPath = new GraphicsPath();
            roundedPath.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            roundedPath.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            roundedPath.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            roundedPath.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            roundedPath.CloseFigure();

            button1.Region = new Region(roundedPath);


            // BOTÓN 2 (Bordes redondeados)
            int radius2 = 20; // Radio de la curva
            Rectangle bounds2 = new Rectangle(0, 0, button2.Width, button2.Height);
            GraphicsPath roundedPath2 = new GraphicsPath();
            roundedPath2.AddArc(bounds2.X, bounds2.Y, radius2, radius2, 180, 90);
            roundedPath2.AddArc(bounds2.Right - radius2, bounds2.Y, radius2, radius2, 270, 90);
            roundedPath2.AddArc(bounds2.Right - radius2, bounds2.Bottom - radius2, radius2, radius2, 0, 90);
            roundedPath2.AddArc(bounds2.X, bounds2.Bottom - radius2, radius2, radius2, 90, 90);
            roundedPath2.CloseFigure();

            button2.Region = new Region(roundedPath2);

            // BOTÓN 3 (Bordes redondeados)
            int radius3 = 20; // Radio de la curva
            Rectangle bounds3 = new Rectangle(0, 0, button3.Width, button3.Height);
            GraphicsPath roundedPath3 = new GraphicsPath();
            roundedPath3.AddArc(bounds3.X, bounds3.Y, radius3, radius3, 180, 90);
            roundedPath3.AddArc(bounds3.Right - radius3, bounds3.Y, radius3, radius3, 270, 90);
            roundedPath3.AddArc(bounds3.Right - radius3, bounds3.Bottom - radius3, radius3, radius3, 0, 90);
            roundedPath3.AddArc(bounds3.X, bounds3.Bottom - radius3, radius3, radius3, 90, 90);
            roundedPath3.CloseFigure();

            button3.Region = new Region(roundedPath3);





        }




    }
}

