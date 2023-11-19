using CoreMVCFairSystem.Models.Configurations;
using CoreMVCFairSystem.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CoreMVCFairSystem.Models.ContextClasses
{
    public class MyContext :IdentityDbContext<AppUser,AppRole,int,IdentityUserClaim<int>,AppUserRole,IdentityUserLogin<int>,IdentityRoleClaim<int>,IdentityUserToken<int>>
    {
        public MyContext(DbContextOptions<MyContext> opt):base(opt)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppRoleConfiguration());
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppUserRoleConfiguration());
            builder.ApplyConfiguration(new AppUserProfileConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new FairConfiguration());
            builder.ApplyConfiguration(new FairLocationConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new DistrictConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new FairsAttributeConfiguration());
            builder.ApplyConfiguration(new FloorConfiguration());
            builder.ApplyConfiguration(new LocationConfiguration());
            builder.ApplyConfiguration(new LocationsAttributeConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new RoomConfiguration());
            builder.ApplyConfiguration(new SpecFairAttributeConfiguration());
            builder.ApplyConfiguration(new SpecLocationAttributeConfiguration());
            builder.ApplyConfiguration(new TownConfiguration());
        }


        public DbSet<Town> Towns { get; set; }
        public DbSet<SpecLocationAttribute> SpecLocationAttributes { get; set; }
        public DbSet<SpecFairAttribute> SpecFairAttributes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<LocationsAttribute> LocationsAttributes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<FairsAttribute> FairsAttributes { get; set; }
        public DbSet<FairLocation> FairLocations { get; set; }
        public DbSet<Fair> Fairs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }





    }
}
