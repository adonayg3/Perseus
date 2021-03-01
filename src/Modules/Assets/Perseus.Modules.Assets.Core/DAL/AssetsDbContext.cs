using Microsoft.EntityFrameworkCore;
using Perseus.Modules.Assets.Core.Entities;

namespace Perseus.Modules.Assets.Core.DAL
{
    public class AssetsDbContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        
        public AssetsDbContext(DbContextOptions<AssetsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("assets");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}