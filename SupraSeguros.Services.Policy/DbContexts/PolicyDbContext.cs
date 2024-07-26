using Microsoft.EntityFrameworkCore;
using SupraSeguros.Services.Policy.Entities;

namespace SupraSeguros.Services.Policy.DbContexts
{
    public class PolicyDbContext:DbContext
    {
        public PolicyDbContext(DbContextOptions<PolicyDbContext> options):base(options) { }

        public DbSet<Cobertura> Cobertura { get; set; }
        public DbSet<Poliza> Poliza { get; set; }
        public DbSet<PolizaCobertura> PolizaCobertura { get; set; }

    }
}
