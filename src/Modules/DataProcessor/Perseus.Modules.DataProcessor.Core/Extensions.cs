using Microsoft.Extensions.DependencyInjection;
using Perseus.Modules.DataProcessor.Core.DAL.Repositories;
using Perseus.Modules.DataProcessor.Core.Repositories;
using Perseus.Modules.DataProcessor.Core.Services;

namespace Perseus.Modules.DataProcessor.Core
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