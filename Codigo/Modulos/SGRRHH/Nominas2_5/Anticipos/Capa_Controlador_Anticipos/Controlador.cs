using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Anticipo;

namespace Capa_Controlador_Anticipos
{
   public class Controlador
    {
        Sentencias sn = new Sentencias(); //Conexion con capa modelo



        public void Pro_CalcularAnticipo(string mes)
        {
            if (!string.IsNullOrEmpty(mes))
            {
                sn.Fun_CalcularAnticipo(mes); // Llama al método de la clase Sentencias
            }
            else
            {
                throw new ArgumentException("El mes no puede estar vacío.");
            }
        }
    }
}
