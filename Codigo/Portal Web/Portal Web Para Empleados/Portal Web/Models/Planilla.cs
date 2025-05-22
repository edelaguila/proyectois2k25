using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("tbl_planilla_Detalle")]
    public class Planilla
    {
        [Key]
        public int pk_registro_planilla_Detalle { get; set; }

        public decimal detalle_total_Percepciones { get; set; }
        public decimal detalle_total_Deducciones { get; set; }
        public decimal detalle_total_liquido { get; set; }

        public int fk_clave_empleado { get; set; }
        public int fk_id_contrato { get; set; }
        public int fk_id_registro_planilla_Encabezado { get; set; }

        public int estado { get; set; }

        // Relaciones (opcional, si las usas)
        // [ForeignKey("fk_clave_empleado")]
        // public virtual tbl_empleados Empleado { get; set; }

        // [ForeignKey("fk_id_contrato")]
        // public virtual tbl_contratos Contrato { get; set; }

        // [ForeignKey("fk_id_registro_planilla_Encabezado")]
        // public virtual tbl_planilla_Encabezado PlanillaEncabezado { get; set; }
    }
}
