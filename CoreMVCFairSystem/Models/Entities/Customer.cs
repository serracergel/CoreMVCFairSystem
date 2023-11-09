namespace CoreMVCFairSystem.Models.Entities
{
    public class Customer:BaseEntity
    {
        //1 order 1 Customer
        //1 customer n order
        public string CompanyName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        //Relational Properties
        public virtual ICollection<Order> Orders { get; set; }
    }
}
