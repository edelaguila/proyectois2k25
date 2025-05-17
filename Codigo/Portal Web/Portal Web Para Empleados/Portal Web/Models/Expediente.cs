using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Portal_Web.Models
{
    [Table("Tbl_expedientes")]
    public class Expediente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pk_id_expediente { get; set; }

        public int? Fk_id_postulante { get; set; }

        public byte[] curriculum { get; set; }

        public bool estado { get; set; } = true;
    }
}