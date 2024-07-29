using Microsoft.EntityFrameworkCore;
using SupraSeguros.Persistence.Repositories;
using SupraSeguros.Services.Customer.Entities;

namespace SupraSeguros.Services.Customer.Repositories
{
    public class CustomerBaseRepository : BaseRepository<Customer.Entities.Customer>
    {
        public CustomerBaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
