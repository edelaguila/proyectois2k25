using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

using System.Net;
using System.Data;

namespace Capa_Modelo_CompraVenta
{
    public class Sentencia
    {
        Conexion cn = new Conexion();
        private string idUsuario;

        public Sentencia(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public Sentencia()
        {

        }
    }
}
