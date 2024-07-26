using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;

namespace SupraSeguros.Services.Payments.Repositories
{
    public class ServicioPagoBaseRepository : BaseRepository<ServicioPago>
    {
        public ServicioPagoBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
