using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Perseus.Modules.Assets.Core;

namespace Perseus.Modules.Assets.Api
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