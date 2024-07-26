using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;
using SupraSeguros.Services.Policy.Entities;

namespace SupraSeguros.Services.Policy.Repositories
{
    public class PolizaCoberturaBaseRepository : BaseRepository<PolizaCobertura>
    {
        public PolizaCoberturaBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
