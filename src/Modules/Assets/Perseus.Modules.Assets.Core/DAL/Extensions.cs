using Microsoft.Extensions.DependencyInjection;
using Perseus.Shared.Infrastructure.Postgres;

namespace Perseus.Modules.Assets.Core.DAL
{
    public static class Extensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.AddPostgres<AssetsDbContext>();
            return services;
        }
    }
}