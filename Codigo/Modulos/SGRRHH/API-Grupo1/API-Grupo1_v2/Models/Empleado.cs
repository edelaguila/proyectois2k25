using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NominaAPI.Models
{
    [Table("tbl_empleados")]

    //Campos de la tabla empleado
    public class Empleado
    {
        [Key]
        [Column("pk_clave")]
        public int Id { get; set; }

        [Required]
        [Column("empleados_nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column("empleados_apellido")]
        [StringLength(50)]
        public string? Apellido { get; set; }

        [Column("empleados_fecha_nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Required]
        [Column("empleados_no_identificacion")]
        [StringLength(50)]
        public string NoIdentificacion { get; set; }

        [Column("empleados_codigo_postal")]
        [StringLength(50)]
        public string? CodigoPostal { get; set; }

        [Column("empleados_fecha_alta")]
        public DateTime? FechaAlta { get; set; }

        [Column("empleados_fecha_baja")]
        public DateTime? FechaBaja { get; set; }

        [Column("empleados_causa_baja")]
        [StringLength(50)]
        public string? CausaBaja { get; set; }

        [Required]
        [Column("fk_id_departamento")]
        public int DepartamentoId { get; set; }

        [Required]
        [Column("fk_id_puestos")]
        public int PuestoId { get; set; }

        [Column("estado")]
        public bool Estado { get; set; } = true;
    }
} 