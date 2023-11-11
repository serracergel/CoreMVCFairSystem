using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class SpecLocationAttributeConfiguration:BaseConfiguration<SpecLocationAttribute>
    {
        public override void Configure(EntityTypeBuilder<SpecLocationAttribute> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Price).HasColumnType("money");
        }
    }
}
