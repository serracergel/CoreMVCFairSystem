using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class FairConfiguration:BaseConfiguration<Fair>
    {
        public override void Configure(EntityTypeBuilder<Fair> builder)
        {
            base.Configure(builder);
        }
    }
}
