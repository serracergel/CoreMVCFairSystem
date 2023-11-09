using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class SpecFairAttributeConfiguration:BaseConfiguration<SpecFairAttribute>
    {
        public override void Configure(EntityTypeBuilder<SpecFairAttribute> builder)
        {
            base.Configure(builder);
        }
    }
}
