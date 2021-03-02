using Microsoft.Extensions.DependencyInjection;
using Perseus.Modules.Assets.Core.DAL;
using Perseus.Modules.Assets.Core.Services;

namespace Perseus.Modules.Assets.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddScoped<IAssetService, AssetService>();
            // services.AddSingleton<IAssetRepository, InMemoryAssetRepository>();
            services.AddDatabase();
            return services;
        }
    }
}