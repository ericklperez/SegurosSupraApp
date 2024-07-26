using SupraSeguros.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SupraSeguros.Services.Policy.DbContexts
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PolicyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PolicyConnectionString")));
            services.AddScoped(typeof(Persistence.Repositories.Contracts.IRepositoryAsync<>), typeof(BaseRepository<>));
            services.AddScoped<DbContext, PolicyDbContext>();

            return services;
        }
    }
}
