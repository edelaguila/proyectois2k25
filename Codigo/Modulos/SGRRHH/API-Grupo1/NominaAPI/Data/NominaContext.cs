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

        public DbSet<Nomina> Nominas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nomina>()
                .ToTable("nominas");
        }
    }
} 