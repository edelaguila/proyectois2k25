using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NominaAPI.Models
{
    //PEQUEÑO EJEMPLO DE SIMULACION DE LA API
    [Table("tbl_planilla_Detalle")]
    public class PlanillaDetalle
    {
        [Key]
        [Column("pk_registro_planilla_Detalle")]
        public int Id { get; set; }

        [Column("detalle_total_Percepciones")]
        public decimal TotalPercepciones { get; set; }

        [Column("detalle_total_Deducciones")]
        public decimal TotalDeducciones { get; set; }

        [Column("detalle_total_liquido")]
        public decimal TotalLiquido { get; set; }

        [Column("fk_clave_empleado")]
        public int EmpleadoId { get; set; }

        [Column("fk_id_contrato")]
        public int ContratoId { get; set; }

        [Column("fk_id_registro_planilla_Encabezado")]
        public int PlanillaEncabezadoId { get; set; }

        [Column("estado")]
        public bool Estado { get; set; }
    }
} 