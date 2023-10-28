using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<catAlumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura el nombre de la tabla para catAlumno
            modelBuilder.Entity<catAlumno>().ToTable("catalumnos");
        }
    }
}