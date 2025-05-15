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
        [Display(Name = "ID Registro Vacaciones")]
        public int pk_registro_vaciones { get; set; }

        [StringLength(25, ErrorMessage = "La descripción no debe exceder los 25 caracteres")]
        [Display(Name = "Descripción")]
        public string asignacion_vacaciones_descripcion { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "Debe ingresar una fecha válida")]
        [Display(Name = "Fecha de Inicio")]
        public DateTime asignacion_vacaciones_fecha_inicio { get; set; }

        [Required(ErrorMessage = "La fecha de fin es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "Debe ingresar una fecha válida")]
        [Display(Name = "Fecha de Fin")]
        public DateTime asignacion_vacaciones_fecha_fin { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un empleado")]
        [ForeignKey("Empleado")]
        [Display(Name = "Empleado")]
        public int fk_clave_empleado { get; set; }

        [Display(Name = "Activo")]
        public bool estado { get; set; }
        // Relación con empleado
        public virtual Empleado Empleado { get; set; }
    }
}
