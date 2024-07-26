using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;

namespace SupraSeguros.Services.Accidents.Repositories
{
    public class SiniestroBaseRepository : BaseRepository<Siniestro>
    {
        public SiniestroBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
