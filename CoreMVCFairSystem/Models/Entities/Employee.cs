namespace CoreMVCFairSystem.Models.Entities
{
    //1 employee  1 location
    //1 location  n employee
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }//CV
        public int? LocationID { get; set; }
        //Relational Properties
        public virtual Location Location { get; set; }


    }
}
