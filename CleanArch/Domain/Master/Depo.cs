global using Domain.Common;

namespace Domain.Master
{

      
    public class Depo : BaseEntity<int>
    {
        public string DAdi { get; set; }         
        public string DAdres { get; set; }      
        public DateTime DTarih { get; set; } 
      
    }
}