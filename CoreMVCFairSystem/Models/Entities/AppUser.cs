using CoreMVCFairSystem.Models.Enums;
using CoreMVCFairSystem.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CoreMVCFairSystem.Models.Entities
{
    //1 user  n order
    //1 order 1 user
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
        {
            CreatedDate=DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<AppUserRole> UserRoles { get; set; }
        public virtual AppUserProfile Profile { get; set; }

    }
}
