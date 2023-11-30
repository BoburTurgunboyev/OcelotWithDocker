using Futbol.Entites;
using Microsoft.EntityFrameworkCore;

namespace Futbol.Data
{
    public class FutbolDbContext:DbContext
    {
        public FutbolDbContext(DbContextOptions<FutbolDbContext> options) : base(options)
        {
            
        }

        public DbSet<Futbolist> Futbolists { get; set; }
    }
}
