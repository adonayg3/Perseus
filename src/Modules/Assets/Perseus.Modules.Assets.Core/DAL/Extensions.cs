using Microsoft.Extensions.DependencyInjection;
using Perseus.Modules.Assets.Core.DAL.Repositories;
using Perseus.Modules.Assets.Core.Repositories;
using Perseus.Shared.Infrastructure.Postgres;

namespace Perseus.Modules.Assets.Core.DAL
{
    public static class Extensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.AddPostgres<AssetsDbContext>();
            services.AddScoped<IAssetRepository, AssetRepository>();
            return services;
        }
    }
}