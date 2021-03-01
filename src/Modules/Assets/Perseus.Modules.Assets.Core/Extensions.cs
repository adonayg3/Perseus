using Microsoft.Extensions.DependencyInjection;
using Perseus.Modules.Assets.Core.DAL.Repositories;
using Perseus.Modules.Assets.Core.Repositories;
using Perseus.Modules.Assets.Core.Services;

namespace Perseus.Modules.Assets.Core
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