namespace CoreMVCFairSystem.Models.Entities
{
    //1 fair n attribute
    //1 attribute n fair
    public class SpecFairAttribute:BaseEntity
    {
        public string Title { get; set; }//konuşmacı olucak mı vs
        public string Description { get; set; }//Konuşma içerigi ne olucak vs
        //Relational Properties
        public virtual ICollection<FairsAttribute> FairsAttributes { get; set; }
    }
}
