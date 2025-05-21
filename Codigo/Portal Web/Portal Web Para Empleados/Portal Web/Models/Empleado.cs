using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_Web.Models
{
    [Table("tbl_empleados")]
    public class Empleado
    {
        [Key]
        public int pk_clave { get; set; }
        public string empleados_nombre { get; set; }
        public string empleados_apellido { get; set; }
        public DateTime? empleados_fecha_nacimiento { get; set; }
        public string empleados_no_identificacion { get; set; }
        public string empleados_codigo_postal { get; set; }
        public DateTime? empleados_fecha_alta { get; set; }
        public DateTime? empleados_fecha_baja { get; set; }
        public string empleados_causa_baja { get; set; }
        public int fk_id_departamento { get; set; }
        public int fk_id_puestos { get; set; }
        public bool estado { get; set; }

        // Relación inversa
        public virtual ICollection<Asistencia> Asistencias { get; set; }
        public virtual ICollection<Asignacion_Vacaciones> VacacionesAsignadas { get; set; }

    }
}