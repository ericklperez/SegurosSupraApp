using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;

namespace SupraSeguros.Services.Agents.Repositories
{
    public class PolizaAgenteBaseRepository : BaseRepository<PolizaAgente>
    {
        public PolizaAgenteBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
