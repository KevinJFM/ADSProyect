using ADSProyect.Models;
using Microsoft.EntityFrameworkCore;

namespace ADSProyect.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiante { get; set; }
    }
}
