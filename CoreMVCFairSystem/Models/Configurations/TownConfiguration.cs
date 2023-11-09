using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class TownConfiguration:BaseConfiguration<Town>
    {
        public override void Configure(EntityTypeBuilder<Town> builder)
        {
            base.Configure(builder);
        }
    }
}
