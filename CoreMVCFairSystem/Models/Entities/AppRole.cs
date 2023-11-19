using CoreMVCFairSystem.Models.Enums;
using CoreMVCFairSystem.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CoreMVCFairSystem.Models.Entities
{
    //1 role n user
    //1 user n role
    public class AppRole : IdentityRole<int>, IEntity
    {
        
        public AppRole()
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
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
