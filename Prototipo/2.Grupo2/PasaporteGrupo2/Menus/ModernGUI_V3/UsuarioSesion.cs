using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfac_V3
{
    public class UsuarioSesion
    {
        public static string idUsuario;

        // Métodos para setear y obtener el idUsuario
        public static void SetIdUsuario(string id)
        {
            idUsuario = id;
        }

        public static string GetIdUsuario()
        {
            return idUsuario;
        }
    }
}
