using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Perseus.Modules.DataProcessor.Api
{
    public static class DataProcessorModule
    {
        public static IServiceCollection AddDataProcessorModule(this IServiceCollection services)
        {
            return services;
        }

        public static IApplicationBuilder UseDataProcessorModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}