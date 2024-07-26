using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Payments.DbContexts
{
    public class PaymentsDbContext:DbContext
    {
        public PaymentsDbContext(DbContextOptions<PaymentsDbContext> options):base(options) { }
        public DbSet<AcuerdoPago> AcuerdoPago{ get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<ServicioPago> ServicioPago { get; set; }
    }
}
