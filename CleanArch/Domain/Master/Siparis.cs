global using Domain.Common;

namespace Domain.Master
{

    public class Siparis : BaseEntity<int>
    {
        public string UAdi { get; set; } 
        public int SAdet { get; set; } 
        public int Birim_Fiyati { get; set; } 
        public string Tedarikci { get; set; } 
        public string Giris_Yap_Depo { get; set; } 
        public DateTime Tarih { get; set; } 



    }
}
