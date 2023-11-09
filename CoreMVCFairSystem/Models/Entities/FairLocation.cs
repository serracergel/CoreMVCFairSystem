namespace CoreMVCFairSystem.Models.Entities
{
    public class  FairLocation:BaseEntity
    {
        //junction table
        public int FairID { get; set; }
        public int LocationID { get; set; }
        //Relational Properties
        public virtual Location Location { get; set; }
        public virtual Fair Fair { get; set; }
    }
}
