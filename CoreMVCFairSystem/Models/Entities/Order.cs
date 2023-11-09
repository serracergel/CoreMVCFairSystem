using CoreMVCFairSystem.Models.Enums;

namespace CoreMVCFairSystem.Models.Entities
{
    //gercekten belirli buglara girip calismama durumu varidr site coker vs tam olsuturulacigi zmaan internet gidervs createddate her turlu zaten vardir o verinin giris tarihidr yine de created date'in tekrar guncellenmesi gerekir ama sirket de bunu bilmek idteyebilir createddate olmasina ragmen order date de vardir zaten ek plarak neden eklend,gi ifade edilir inst veri griis tarihi olsa da rograma bu siparis ne zamn girlidi emir bilgisayara gştti sms a asil orderdate'i toplanti zamaninda kararlasitirililken belirlenir kendi kendine 
    public class Order:BaseEntity
    {
       //1 order n fair
       //1 fair 1 order
        public DateTime OrderDate { get; set; }
        //In addittion to CreatedDate(property of BaseEntity), OrderDate has been added for precautionary and comprehensive information purposes.
        public DateTime Deadline { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentStatus Payment { get; set; }
        public int CustomerID { get; set; }
        //Relational Properties
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Fair> Fairs { get; set; }
    }
}
