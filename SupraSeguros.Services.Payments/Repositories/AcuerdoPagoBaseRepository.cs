using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;

namespace SupraSeguros.Services.Payments.Repositories
{
    public class AcuerdoPagoBaseRepository : BaseRepository<AcuerdoPago>
    {
        public AcuerdoPagoBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
