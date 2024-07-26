using Microsoft.EntityFrameworkCore;
namespace SupraSeguros.Services.Customer.DbContexts
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options):base(options) { }
        public DbSet<Entities.Customer> Customer { get; set; }

    }
}
