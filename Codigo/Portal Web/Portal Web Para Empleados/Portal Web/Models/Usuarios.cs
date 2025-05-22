using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("Tbl_usuarios")]

    public class Usuarios
    {
        [Key]
        public int Pk_id_usuario { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50)]
        public string nombre_usuario { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50)]
        public string apellido_usuario { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        [StringLength(20)]
        public string username_usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(100)]
        public string password_usuario { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        [StringLength(50)]
        public string email_usuario { get; set; }

        public DateTime? ultima_conexion_usuario { get; set; }

        public bool estado_usuario { get; set; }

        [Required(ErrorMessage = "La pregunta de seguridad es requerida")]
        [StringLength(50)]
        public string pregunta { get; set; }

        [Required(ErrorMessage = "La respuesta de seguridad es requerida")]
        [StringLength(50)]
        public string respuesta { get; set; }

        [Required(ErrorMessage = "Agregue su id")]
        public int fk_empleado { get; set; }
        [NotMapped]
        public string ruta_foto { get; set; }
    }
    

    [Table("Roles")]
    public class Rol
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}