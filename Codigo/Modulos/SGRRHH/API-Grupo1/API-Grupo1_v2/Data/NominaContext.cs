using Microsoft.EntityFrameworkCore;
using NominaAPI.Models;

namespace NominaAPI.Data
{
    public class NominaContext : DbContext
    {
        public NominaContext(DbContextOptions<NominaContext> options)
            : base(options)
        {
        }
        public DbSet<PlanillaDetalle> PlanillaDetalles { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanillaDetalle>()
                .ToTable("tbl_planilla_Detalle");

            modelBuilder.Entity<Empleado>()
                .ToTable("tbl_empleados");
        }
    }
} 