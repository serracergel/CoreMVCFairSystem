

namespace CoreMVCFairSystem.Models.Entities
{
    //1 Location  n attribute
    //1 attribute n location    
    public class SpecLocationAttribute:BaseEntity
    {
        public string Title { get; set; }//Ozellik adi=>airport shuttle,yemek,otopark
        public string Description { get; set; }//ozellik aciklama
        public decimal? Price { get; set; }//bu ozellik ekstra ucretliyse ucreti degilse null geclebilir zaten
        //Relational Properties
        public virtual ICollection<LocationsAttribute> LocationsAttributes { get; set; }


    }
}
