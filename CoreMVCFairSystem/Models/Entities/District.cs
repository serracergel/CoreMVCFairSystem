namespace CoreMVCFairSystem.Models.Entities
{
    //1 district n location
    //1 location 1 district
    public class District:BaseEntity
    {
        public string DistrictName { get; set; }
        public int TownID { get; set; }


        //Relational Properties
        public virtual ICollection<Location> Locations { get; set; }
        public virtual Town Town { get; set; }


    }
}
