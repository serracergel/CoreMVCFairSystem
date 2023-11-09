using CoreMVCFairSystem.Models.Enums;

namespace CoreMVCFairSystem.Models.Entities
{
    public class Location:BaseEntity
    {
        
        public string LocationName { get; set; }
        public int Area { get; set; }//m2 cinsinden alani
        public decimal LeaseCost { get; set; }//Lokasyonun ucreti
        public int DistrictID { get; set; }
        //Relational Properties
        public virtual ICollection<LocationsAttribute> LocationsAttributes { get; set; }
        public virtual ICollection<Floor> Floors { get; set; }
        public virtual District District { get; set; }
        public virtual ICollection<FairLocation> FairLocations { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
