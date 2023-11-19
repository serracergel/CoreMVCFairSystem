using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x=>x.ID);
            //For Identity library process Ignored key will be ID from BaseEntity
            builder.HasMany(x=>x.UserRoles).WithOne(x=>x.User).HasForeignKey(x=>x.UserId).IsRequired();
            builder.HasMany(x => x.Orders).WithOne(x=>x.AppUser).HasForeignKey(x=>x.AppUserID);
            builder.HasOne(x => x.Profile).WithOne(x => x.User).HasForeignKey<AppUserProfile>(x=>x.ID);
            
        }

    }
}
