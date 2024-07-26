using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;
using SupraSeguros.Services.Policy.Entities;

namespace SupraSeguros.Services.Policy.Repositories
{
    public class PolicyBaseRepository : BaseRepository<Poliza>
    {
        public PolicyBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
