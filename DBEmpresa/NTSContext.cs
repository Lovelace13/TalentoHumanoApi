using Microsoft.EntityFrameworkCore;
using DBEmpresa.Models;
using System.Security.Cryptography.X509Certificates;

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
                b.HasKey(x => x.DepartamentoID);
                b.Property(x => x.Nombre).HasMaxLength(128)
                    .IsRequired();

            });

            modelBuilder.Entity<SubDepartamento>(b =>
            {
                b.HasKey(x => x.SubDepartamentoID);
                b.Property(x => x.Nombre).HasMaxLength(128)
                    .IsRequired();

            });


            modelBuilder.Entity<RolEmpleado>(b =>
            {
                b.HasKey(x => x.RolEmpleadoID);
                b.Property(x => x.Nombre).HasMaxLength(128)
                    .IsRequired();

            });
            modelBuilder.Entity<Empleado>(b =>
            {
                b.HasKey(x => x.EmpleadoID);
                b.Property(x => x.Nombre).HasMaxLength(128)
                    .IsRequired();


                //b.HasOne<SubDepartamento>().WithMany().HasForeignKey(x => x.SubDepartamentoID).IsRequired()
                //    .OnDelete(DeleteBehavior.Restrict);
                //b.HasOne<RolEmpleado>().WithMany().HasForeignKey(x => x.RolID).IsRequired()
                //    .OnDelete(DeleteBehavior.Restrict); 
            });





        }

    }
}
