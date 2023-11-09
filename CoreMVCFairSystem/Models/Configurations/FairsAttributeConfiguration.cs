using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class FairsAttributeConfiguration:BaseConfiguration<FairsAttribute>
    {
        public override void Configure(EntityTypeBuilder<FairsAttribute> builder)
        {
            base.Configure(builder);
        }
    }
}
