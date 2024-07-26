using SupraSeguros.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SupraSeguros.Services.Claim.DbContexts
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ClaimDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ClaimConnectionString")));
            services.AddScoped(typeof(Persistence.Repositories.Contracts.IRepositoryAsync<>), typeof(BaseRepository<>));
            services.AddScoped<DbContext, ClaimDbContext>();

            return services;
        }
    }
}
