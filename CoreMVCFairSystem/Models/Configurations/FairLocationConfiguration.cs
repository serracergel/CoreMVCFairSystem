﻿using CoreMVCFairSystem.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCFairSystem.Models.Configurations
{
    public class FairLocationConfiguration:BaseConfiguration<FairLocation>
    {
        public override void Configure(EntityTypeBuilder<FairLocation> builder)
        {
            base.Configure(builder);
        }
    }
}
