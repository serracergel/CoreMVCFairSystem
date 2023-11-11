using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class FairConfiguration:BaseConfiguration<Fair>
    {
        public override void Configure(EntityTypeBuilder<Fair> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Price).HasColumnType("money");
        }
    }
}
