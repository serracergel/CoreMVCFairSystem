using CoreMVCFairSystem.Models.Enums;
using CoreMVCFairSystem.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CoreMVCFairSystem.Models.Entities
{
    public class AppUserRole : IdentityUserRole<int>, IEntity
    {
        //junction table
        public AppUserRole()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        //Relational Properties
        public virtual AppUser User { get; set; }
        public virtual AppRole Role { get; set; }
    }
}
