using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Carrera;

namespace Capa_Controlador_Carrera
{
    public class Controlador
    {
        /*********************Ismar Leonel Cortez Sanchez -0901-21-560************/
        /***********************Combo box inteligente*****************************/
        Sentencias sn;

        public Controlador(string idUsuario)
        {
            sn = new Sentencias(idUsuario);
        }
        public string[] items(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.funLlenarCmb2(tabla, campo1, campo2);
            /*Este arreglo lo obtiene y retorna de la clase senencias del modelo*/
            return Items;

            /*Aqui viene a parar lo de sentencias*/


        }

        public DataTable enviar(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.obtener2(tabla, campo1, campo2);

            return dt1;
        }
        /**************************************************************************/

        public DataRow ObtenerPuestoYSalario(string idEmpleado)
        {
            return sn.ObtenerDatosEmpleado(idEmpleado);
        }




    }



}
