using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Claim.DbContexts
{
    public class ClaimDbContext:DbContext
    {
        public ClaimDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Reclamacion> Reclamacion { get; set; }
    }
}
