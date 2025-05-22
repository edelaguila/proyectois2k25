using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("tbl_asistencias")]
    public class Asistencia : IValidatableObject
    {
        [Key]
        [Column("pk_id_asistencia")]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date)]
        [Column("fecha")]
        public DateTime fecha { get; set; }

        [DataType(DataType.Time)]
        [Column("hora_entrada")]
        public TimeSpan? hora_entrada { get; set; }

        [DataType(DataType.Time)]
        [Column("hora_salida")]
        public TimeSpan? hora_salida { get; set; }

        [Required(ErrorMessage = "El estado de asistencia es obligatorio.")]
        [StringLength(20, ErrorMessage = "El estado no puede tener más de 20 caracteres.")]
        [Column("estado_asistencia")]
        public string estado_asistencia { get; set; }

        [StringLength(250, ErrorMessage = "Las observaciones no pueden tener más de 250 caracteres.")]
        [Column("observaciones")]
        public string observaciones { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un empleado.")]
        [Column("fk_clave_empleado")]
        public int fk_clave_empleado { get; set; }

        [ForeignKey("fk_clave_empleado")]
        public virtual Empleado Empleado { get; set; }

        // Validación personalizada
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Si una hora se ingresa, la otra también debe estar
            if (hora_entrada.HasValue && !hora_salida.HasValue)
            {
                yield return new ValidationResult(
                    "Debe ingresar la hora de salida.",
                    new[] { nameof(hora_salida) });
            }

            if (!hora_entrada.HasValue && hora_salida.HasValue)
            {
                yield return new ValidationResult(
                    "Debe ingresar la hora de entrada.",
                    new[] { nameof(hora_entrada) });
            }

            // Si ambas existen, entrada debe ser menor que salida
            if (hora_entrada.HasValue && hora_salida.HasValue)
            {
                if (hora_entrada.Value >= hora_salida.Value)
                {
                    yield return new ValidationResult(
                        "La hora de entrada debe ser anterior a la hora de salida.",
                        new[] { nameof(hora_entrada), nameof(hora_salida) });
                }
            }
        }
    }
}
