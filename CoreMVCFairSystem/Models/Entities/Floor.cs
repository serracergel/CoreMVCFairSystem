namespace CoreMVCFairSystem.Models.Entities
{
    public class Floor:BaseEntity
    {
        public int FloorNo { get; set; }
        public int LocationID { get; set; }

        //Relational Properties
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual Location Location { get; set; }
    }
}
