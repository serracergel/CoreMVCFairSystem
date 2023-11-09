namespace CoreMVCFairSystem.Models.Entities
{  //junction table
    public class LocationsAttribute : BaseEntity
    {
        public int LocationID { get; set; }
        public int LocationAttributeID { get; set; }
       
        //Relational Properties
        public virtual Location Location { get; set; }
        public virtual SpecLocationAttribute LocationAttribute { get; set; }
    }
}
