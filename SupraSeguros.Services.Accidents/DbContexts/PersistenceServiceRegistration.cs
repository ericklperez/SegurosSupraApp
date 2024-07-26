using SupraSeguros.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Accidents.DbContexts
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AccidentsDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AccidentsConnectionString")));
            services.AddScoped(typeof(Persistence.Repositories.Contracts.IRepositoryAsync<>), typeof(BaseRepository<>));
            services.AddScoped<DbContext, AccidentsDbContext>();

            return services;
        }
    }
}
