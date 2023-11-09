using System.Security.Principal;

namespace CoreMVCFairSystem.Models.Entities
{
    //1 category n fair
    //1 fair     1 category
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual ICollection<Fair> Fairs { get; set; }
    }
}
