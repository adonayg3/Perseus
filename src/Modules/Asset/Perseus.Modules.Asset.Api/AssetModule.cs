using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Perseus.Modules.Asset.Core;

namespace Perseus.Modules.Asset.Api
{
    public static class AssetModule
    {
        public static IServiceCollection AddAssetModule(this IServiceCollection services)
        {
            services.AddCore();
            return services;
        }

        public static IApplicationBuilder UseAssetModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}