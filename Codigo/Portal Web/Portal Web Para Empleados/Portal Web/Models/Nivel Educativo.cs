using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Portal_Web.Models
{
    [Table("Tbl_nivel_educativo")]
    public class Nivel_Educativo
    {
        [Key]
        public int Pk_id_nivel { get; set; }
        public string nivel { get; set; }
        public bool estado { get; set; } // TRUE para activo, FALSE para inactivo
    }
}