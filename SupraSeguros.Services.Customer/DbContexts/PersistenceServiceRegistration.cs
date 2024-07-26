using SupraSeguros.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Customer.DbContexts
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CustomerDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CustomerConnectionString")));
            services.AddScoped(typeof(Persistence.Repositories.Contracts.IRepositoryAsync<>), typeof(BaseRepository<>));    
            services.AddScoped<DbContext, CustomerDbContext>();
            
            return services;
        }
    }
}
