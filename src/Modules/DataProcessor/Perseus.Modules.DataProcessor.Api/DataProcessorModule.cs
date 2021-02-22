using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Perseus.Modules.DataProcessor.Core;

namespace Perseus.Modules.DataProcessor.Api
{
    public static class DataProcessorModule
    {
        public static IServiceCollection AddDataProcessorModule(this IServiceCollection services)
        {
            services.AddCore();
            return services;
        }

        public static IApplicationBuilder UseDataProcessorModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}