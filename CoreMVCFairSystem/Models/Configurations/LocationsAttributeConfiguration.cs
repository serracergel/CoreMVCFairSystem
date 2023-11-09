using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class LocationsAttributeConfiguration:BaseConfiguration<LocationsAttribute>
    {
        public override void Configure(EntityTypeBuilder<LocationsAttribute> builder)
        {
            base.Configure(builder);
        }
    }
}
