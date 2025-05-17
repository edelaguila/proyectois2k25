using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace Portal_Web.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Empleado> tbl_empleados { get; set; }
        public DbSet<Asistencia> tbl_asistencias { get; set; }
        public DbSet<Asignacion_Vacaciones> tbl_asignacion_vacaciones { get; set; }
        public DbSet<Contrato> tbl_contratos { get; set; }
        public DbSet<Planilla> tbl_planilla_Detalle { get; set; }
        public DbSet<QuejasReclamos> tbl_quejas_reclamos { get; set; }
        public DbSet<Postulante> Tbl_postulante { get; set; }
        public DbSet<Puesto> tbl_puestos_trabajo { get; set; }
        public DbSet<Nivel_Educativo> Tbl_nivel_educativo { get; set; }
        public DbSet<Disponibilidad> Tbl_disponibilidad { get; set; }
        public DbSet<Expediente> Tbl_expedientes { get; set; }
    }
}