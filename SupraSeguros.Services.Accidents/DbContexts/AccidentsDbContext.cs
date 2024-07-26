using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Accidents.DbContexts
{
    public class AccidentsDbContext:DbContext
    {
        public AccidentsDbContext(DbContextOptions<AccidentsDbContext> options):base(options) 
        {
            
        }

        public DbSet<Siniestro> Siniestro { get; set; }
    }
}
