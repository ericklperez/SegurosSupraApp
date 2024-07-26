using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;
using SupraSeguros.Services.Policy.Entities;

namespace SupraSeguros.Services.Policy.Repositories
{
    public class CoberturaBaseRepository : BaseRepository<Cobertura>
    {
        public CoberturaBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
