namespace CoreMVCFairSystem.Models.Entities
{
    public class AppUserProfile:BaseEntity
    {
        //1 profile 1 user
        //1 user    1 profile=>1 to 1 relation
        public string CompanyName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        //Relational Properties
        public virtual AppUser User { get; set; }
    }
}
