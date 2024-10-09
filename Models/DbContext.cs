using Microsoft.EntityFrameworkCore;
using MiPrimeraWeb.Models;

namespace MiAppWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define aquí tus entidades (tablas)
        public DbSet<ModeloEstudiante> Estudiantes { get; set; }
    }
}