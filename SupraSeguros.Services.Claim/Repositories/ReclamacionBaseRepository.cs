using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;

namespace SupraSeguros.Services.Claim.Repositories
{
    public class ReclamacionBaseRepository : BaseRepository<Reclamacion>
    {
        public ReclamacionBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
