using System.ComponentModel.DataAnnotations;

namespace NominaAPI.Models
{
    //PEQUEÑO EJEMPLO DE SIMULACION DE LA API
    public class Nomina
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }
        
        [Required]
        [StringLength(50)]
        public string EmpleadoId { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string? NombreEmpleado { get; set; }
        
        [Required]
        public decimal Monto { get; set; }
        
        [StringLength(50)]
        public string? Estado { get; set; }
        
        [StringLength(100)]
        public string? Departamento { get; set; }
        
        [StringLength(50)]
        public string? TipoNomina { get; set; }
        
        public string? Observaciones { get; set; }
        
        [StringLength(50)]
        public string? CodigoNomina { get; set; }
        
        [StringLength(50)]
        public string? Periodo { get; set; }
        
        public decimal MontoNeto { get; set; }
        
        public decimal MontoBruto { get; set; }
        
        [StringLength(50)]
        public string? TipoPago { get; set; }
        
        [StringLength(100)]
        public string? Banco { get; set; }
        
        [StringLength(50)]
        public string? NumeroCuenta { get; set; }
        
        [StringLength(10)]
        public string? Moneda { get; set; }
        
        [StringLength(50)]
        public string? EstadoPago { get; set; }
        
        public DateTime? FechaPago { get; set; }
        
        [StringLength(50)]
        public string? UsuarioCreacion { get; set; }
        
        public DateTime? FechaCreacion { get; set; }
        
        [StringLength(50)]
        public string? UsuarioModificacion { get; set; }
        
        public DateTime? FechaModificacion { get; set; }
    }
} 