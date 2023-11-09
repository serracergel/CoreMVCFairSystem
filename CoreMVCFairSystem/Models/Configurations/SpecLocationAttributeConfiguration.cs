using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class SpecLocationAttributeConfiguration:BaseConfiguration<SpecLocationAttribute>
    {
        public override void Configure(EntityTypeBuilder<SpecLocationAttribute> builder)
        {
            base.Configure(builder);
        }
    }
}
