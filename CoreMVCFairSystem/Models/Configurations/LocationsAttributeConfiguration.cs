using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class LocationsAttributeConfiguration:BaseConfiguration<LocationsAttribute>
    {
        public override void Configure(EntityTypeBuilder<LocationsAttribute> builder)
        {
            base.Configure(builder);
            builder.ToTable("SiparisDetaylari");
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.LocationID,
                x.LocationAttributeID
            });
        }
    }
}
