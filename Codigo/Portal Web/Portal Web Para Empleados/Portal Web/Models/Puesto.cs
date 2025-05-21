using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace Portal_Web.Models
{
    [Table("tbl_puestos_trabajo")]
    public class Puesto
    {
        [Key]
        public int pk_id_puestos { get; set; }
        public string puestos_nombre_puesto { get; set; }
        public string puestos_descripcion { get; set; }
        public bool estado { get; set; } // TRUE para activo, FALSE para inactivo

        public virtual ICollection<Postulante> Postulantes { get; set; }
    }
}