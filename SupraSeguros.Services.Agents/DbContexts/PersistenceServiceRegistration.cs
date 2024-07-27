using SupraSeguros.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Agents.DbContexts
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AgentsDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AgentsConnectionString")));
            services.AddScoped(typeof(Persistence.Repositories.Contracts.IRepositoryAsync<>), typeof(BaseRepository<>));
            services.AddScoped<DbContext, AgentsDbContext>();

            return services;
        }
    }
}
