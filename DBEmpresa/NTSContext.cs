using Microsoft.EntityFrameworkCore;
using DBEmpresa.Models;

namespace DBEmpresa
{
    public class NTSContext : DbContext
    {
        public NTSContext(DbContextOptions<NTSContext> options) : base(options) 
        { 
        
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<SubDepartamento> Subdepartamentos { get; set; }
        public DbSet<RolEmpleado> RolesEmpleados { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Sueldo> Sueldos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Departamento>().ToTable("Departamento");
            modelBuilder.Entity<Departamento>(b =>
            {
                b.Property(x => x.Nombre).HasMaxLength(128)
                    .IsRequired();
            });

            modelBuilder.Entity<Empleado>(b =>
            {
                b.Property(x => x.Nombre).HasMaxLength(128)
                    .IsRequired();
                b.HasOne<Departamento>().WithMany().HasForeignKey(x => x.DepartamentoID).IsRequired();
                b.HasOne<SubDepartamento>().WithMany().HasForeignKey(x => x.SubdepartamentoID).IsRequired();
                b.HasOne<RolEmpleado>().WithMany().HasForeignKey(x => x.RolID).IsRequired();
            });
        }

    }
}
