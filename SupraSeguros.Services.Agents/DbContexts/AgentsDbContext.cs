using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Agents.DbContexts
{
    public class AgentsDbContext:DbContext
    {
        public AgentsDbContext(DbContextOptions<AgentsDbContext> options):base(options) { }
        public DbSet<PolizaAgente> PolizaAgente { get; set; }
        public DbSet<Agente> Agente { get; set; }
    }
}
