using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;

namespace SupraSeguros.Services.Payments.Repositories
{
    public class PagoBaseRepository : BaseRepository<Pago>
    {
        public PagoBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
