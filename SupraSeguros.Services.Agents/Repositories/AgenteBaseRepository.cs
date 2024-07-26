using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;

namespace SupraSeguros.Services.Agents.Repositories
{
    public class AgenteBaseRepository : BaseRepository<Agente>
    {
        public AgenteBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
