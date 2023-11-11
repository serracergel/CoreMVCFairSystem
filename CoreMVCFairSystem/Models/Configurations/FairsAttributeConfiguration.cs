using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class FairsAttributeConfiguration:BaseConfiguration<FairsAttribute>
    {
        public override void Configure(EntityTypeBuilder<FairsAttribute> builder)
        {
            base.Configure(builder);
            builder.ToTable("SiparisDetaylari");
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.FairID,
                x.AttributeID
            });
        }
    }
}
