using CoreMVCFairSystem.Models.Enums;
using System.Windows;

namespace CoreMVCFairSystem.Models.Entities
{
    public class Room:BaseEntity
    {
        public string RoomNo { get; set; }
        public string Description { get; set; }//Oda'nin m2'si vs bilgilerini yazicaz
        public int FloorID { get; set; }//null gecilemez dedim cunku bir odanin illaki bulundugu bir kat vardir
        

        //Relational Properties
        public virtual Floor Floor { get; set; }

    }
}
