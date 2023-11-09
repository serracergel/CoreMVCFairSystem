namespace CoreMVCFairSystem.Models.Entities
{
    //1 town n district
    //1 district 1 town
    public class Town:BaseEntity
    {
        public string TownName { get; set; }
        public int CountryID { get; set; }
        //Relational Properties
        public virtual ICollection<District> Districts { get; set; }
        public virtual Country Country { get; set; }
    }
}
