namespace CoreMVCFairSystem.Models.Entities
{
    public class FairsAttribute:BaseEntity
    {
        public int FairID { get; set; }
        public int AttributeID { get; set; }
        //Relational Properties
        public virtual Fair Fair { get; set; }
        public virtual Attribute Attribute { get; set; }
    }
}
