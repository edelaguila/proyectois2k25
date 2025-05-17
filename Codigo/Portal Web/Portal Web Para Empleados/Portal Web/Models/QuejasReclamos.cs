using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("tbl_quejas_reclamos")]
    public class QuejasReclamos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no debe exceder los 100 caracteres")]
        [Display(Name = "Nombre completo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar el ID del empleado")]
        [StringLength(50, ErrorMessage = "El ID del empleado no debe exceder los 50 caracteres")]
        [Display(Name = "ID del Empleado")]
        public string IdEmpleado { get; set; }

        [StringLength(100, ErrorMessage = "El nombre del departamento no debe exceder los 100 caracteres")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }

        [Required(ErrorMessage = "Debe ingresar un correo electrónico")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo electrónico válido")]
        [StringLength(100, ErrorMessage = "El correo no debe exceder los 100 caracteres")]
        [Display(Name = "Correo electrónico")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe especificar el tipo de queja o reclamo")]
        [StringLength(100, ErrorMessage = "El tipo no debe exceder los 100 caracteres")]
        [Display(Name = "Tipo de Queja o Reclamo")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Debe describir el problema")]
        [Display(Name = "Descripción del Problema")]
        public string Descripcion { get; set; }

        [Display(Name = "Nivel de Urgencia")]
        public string Urgencia { get; set; }

        [Display(Name = "¿Desea mantener confidencialidad?")]
        public bool Confidencial { get; set; }

        [Required(ErrorMessage = "Debe aceptar los términos y condiciones")]
        [Display(Name = "Acepta Términos y Condiciones")]
        public bool Terminos { get; set; }

        [Display(Name = "Fecha de Envío")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Display(Name = "Archivos Adjuntos")]
        public string ArchivosAdjuntos { get; set; }
    }
}
