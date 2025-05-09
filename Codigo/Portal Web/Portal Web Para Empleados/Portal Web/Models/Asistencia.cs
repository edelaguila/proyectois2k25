using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("tbl_asistencias")]
    public class Asistencia
    {
        [Key]
        [Column("pk_id_asistencia")]
        public int Id { get; set; }

        [Column("fecha")]
        public DateTime fecha { get; set; }

        [Column("hora_entrada")]
        public TimeSpan? hora_entrada { get; set; }

        [Column("hora_salida")]
        public TimeSpan? hora_salida { get; set; }

        [Column("estado_asistencia")]
        public string estado_asistencia { get; set; }

        [Column("observaciones")]
        public string observaciones { get; set; }

        [Column("fk_clave_empleado")]
        public int fk_clave_empleado { get; set; }

        [ForeignKey("fk_clave_empleado")]
        public virtual Empleado Empleado { get; set; }
    }
}