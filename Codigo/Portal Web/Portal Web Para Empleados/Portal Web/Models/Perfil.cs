using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{    public class Perfil
    {
        public int Pk_id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellido_usuario { get; set; }
        public string username_usuario { get; set; }
        public string email_usuario { get; set; }
        public DateTime? ultima_conexion_usuario { get; set; }
        public bool estado_usuario { get; set; }
        [NotMapped]
        public string ruta_foto { get; set; }
    }
}