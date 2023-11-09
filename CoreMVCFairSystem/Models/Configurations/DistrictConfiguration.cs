using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class DistrictConfiguration:BaseConfiguration<District>
    {
        public override void Configure(EntityTypeBuilder<District> builder)
        {
            base.Configure(builder);
        }
    }
}
