using Microsoft.Extensions.DependencyInjection;
using Perseus.Modules.Asset.Core.DAL.Repositories;
using Perseus.Modules.Asset.Core.Repositories;
using Perseus.Modules.Asset.Core.Services;

namespace Perseus.Modules.Asset.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddScoped<IAssetService, AssetService>();
            services.AddSingleton<IAssetRepository, InMemoryAssetRepository>();

            return services;
        }
    }
}