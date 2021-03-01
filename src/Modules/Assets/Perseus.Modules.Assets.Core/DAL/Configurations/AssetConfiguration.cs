using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Perseus.Modules.Assets.Core.Entities;

namespace Perseus.Modules.Assets.Core.DAL.Configurations
{
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            //Add Constraints
            //Add indexes
        }
    }
}