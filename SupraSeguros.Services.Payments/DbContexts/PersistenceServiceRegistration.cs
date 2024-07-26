using SupraSeguros.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Payments.DbContexts
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PaymentsDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PaymentsConnectionString")));
            services.AddScoped(typeof(Persistence.Repositories.Contracts.IRepositoryAsync<>), typeof(BaseRepository<>));
            services.AddScoped<DbContext, PaymentsDbContext>();

            return services;
        }
    }
}
