using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class FloorConfiguration:BaseConfiguration<Floor>
    {
        public override void Configure(EntityTypeBuilder<Floor> builder)
        {
            base.Configure(builder);
        }
    }
}
