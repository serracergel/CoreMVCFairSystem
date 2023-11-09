namespace CoreMVCFairSystem.Models.Entities
{
    //1 country n town
    //1 town    1 country
    public class Country:BaseEntity
    {
        public string CountryName { get; set; }
        //Relational Properties
        public virtual ICollection<Town> Towns { get; set; }
    }
}
