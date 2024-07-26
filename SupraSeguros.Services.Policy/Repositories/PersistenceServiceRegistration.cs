using SupraSeguros.Persistence.Repositories;
using SupraSeguros.Persistence.Repositories.Contracts;
using SupraSeguros.Services.Policy.DbContexts;

namespace SupraSeguros.Services.Policy.Repositories
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PolicyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PolicyConnectionString")));
            services.AddScoped(typeof(IRepositoryAsync), typeof(BaseRepository<>));
            
        }
    }
}
