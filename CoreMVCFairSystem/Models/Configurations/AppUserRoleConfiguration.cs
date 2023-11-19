﻿using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class AppUserRoleConfiguration:BaseConfiguration<AppUserRole>
    {
        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            base.Configure(builder);
            builder.Ignore(x=>x.ID);
            builder.HasKey(x => new
            {
                x.RoleId,
                x.UserId
            });
        }
    }
}
