namespace CoreMVCFairSystem.Models.Entities
{
    public class Fair:BaseEntity
    {
        //1 fair     n location
        //1 location n fair
        public string FairName { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }//Katilim ucreti

        public string ElectricitySystem { get; set; }//bunu enum yapip ariza durumunda veya degil eklemek,(eger gercek bir proje olsaydi orn o elektrik sisteminin iviri ziviri yok hava basıncı akimi vs takip edilsin orn basinc prop'una encapsulation ile eger 3'un altindaysa elektrik sistemi statusunu arizaya cek uyari gonder vs yapardik=>Hocaya sor )
        public DateTime StartDate { get; set; }//Fuarin baslangic tarihi
        public DateTime EndDate { get; set; }//bitis tarihi
        public int CategoryID { get; set; }
        public int NumberOfParticipants { get; set; }//fuarin katilimci sayisi
        public int OrderID { get; set; }
        public int CompanyID { get; set; }
        //Relational Properties
        public virtual ICollection<FairLocation> FairLocations { get; set; }
        public virtual Category Category { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<FairsAttribute> FairsAttributes { get; set; }
    }
}
