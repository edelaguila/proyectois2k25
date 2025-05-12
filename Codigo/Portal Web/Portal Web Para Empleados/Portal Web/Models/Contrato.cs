using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("tbl_contratos")]
    public class Contrato
    {
        [Key]
        public int pk_id_contrato { get; set; }
        public DateTime contratos_fecha_creacion { get; set; }
        public decimal contratos_salario { get; set; }
        public string contratos_tipo_contrato { get; set; }
        public int fk_clave_empleado { get; set; }
        public int estado { get; set; }
    }
}