using Microsoft.EntityFrameworkCore;
using CrudAspNetMVC.Models;

namespace CrudAspNetMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pais>().HasData(
                new Pais { Id = 1, Nombre = "República Dominicana" },
                new Pais { Id = 2, Nombre = "México" },
                new Pais { Id = 3, Nombre = "Colombia" }
            );

            modelBuilder.Entity<Login>().HasData(
                new Login { Id = 1, Usuario = "admin", Contrasena = "Admin123*", Rol = "Administrador" }
            );
        }
    }
}