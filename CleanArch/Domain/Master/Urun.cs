global using Domain.Common;

namespace Domain.Master
{

    public class Urun : BaseEntity<int>
    {      
        public string UAdi { get; set; }
        public string Tip { get; set; } 
        public DateTime Tarih { get; set; } 


    }
}
