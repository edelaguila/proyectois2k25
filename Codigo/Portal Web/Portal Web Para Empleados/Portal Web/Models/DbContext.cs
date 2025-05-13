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

    }
}