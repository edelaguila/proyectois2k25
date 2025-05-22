using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("Users")]  // Esto asegura que use la tabla "Users" y no "Usuarios"

    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public int? RoleId { get; set; }  // Nullable en caso de que algunos usuarios no tengan rol

        [ForeignKey("RoleId")]
        public virtual Rol Rol { get; set; }  // Relación con la tabla Roles

    }
    [Table("Roles")]
    public class Rol
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}