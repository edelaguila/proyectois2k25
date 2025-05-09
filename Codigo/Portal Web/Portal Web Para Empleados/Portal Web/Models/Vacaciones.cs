using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("tbl_asignacion_vacaciones")]
    public class Asignacion_Vacaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pk_registro_vaciones { get; set; }

        [StringLength(25)]
        public string asignacion_vacaciones_descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime asignacion_vacaciones_fecha_inicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime asignacion_vacaciones_fecha_fin { get; set; }

        [ForeignKey("Empleado")]
        public int fk_clave_empleado { get; set; }

        public bool estado { get; set; }

        // Relación con empleado
        public virtual Empleado Empleado { get; set; }
    }
}
