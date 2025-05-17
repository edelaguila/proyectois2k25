using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("Tbl_disponibilidad")]

    public class Disponibilidad
    {
        [Key]
        public int Pk_id_disponibilidad { get; set; }
        public string disponibilidad { get; set; }
        public bool estado { get; set; } // TRUE para activo, FALSE para inactivo
    }
}