using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("Tbl_postulante")]
    public class Postulante
    {
        [Key]
        public int Pk_id_postulante { get; set; }

        // Clave foránea al puesto de trabajo
        [ForeignKey("Puesto")]
        [Required(ErrorMessage = "Debe seleccionar un puesto")]
        public int? Fk_puesto_aplica_postulante { get; set; }

        public virtual Puesto Puesto { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string nombre_postulante { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string apellido_postulante { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido")]
        public string email_postulante { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "Debe ingresar un número de teléfono válido")]
        public string telefono_postulante { get; set; }

        [Required(ErrorMessage = "Debe indicar los años de experiencia")]
        [Range(0, 50, ErrorMessage = "Debe estar entre 0 y 50 años")]
        public int anios_experiencia { get; set; }

        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string trabajo_anterior { get; set; }

        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string puesto_anterior { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un nivel educativo")]
        public int Fk_nivel_educativo { get; set; }

        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string titulo_obtenido { get; set; }

        [Required(ErrorMessage = "Debe seleccionar disponibilidad")]
        public int Fk_disponibilidad { get; set; }

        [Range(0, 1000000, ErrorMessage = "Debe ingresar un salario válido")]
        public decimal? salario_pretendido { get; set; }

        public DateTime? fecha_postulacion { get; set; } = DateTime.Now;

        public bool estado { get; set; } = true;
    }
}
