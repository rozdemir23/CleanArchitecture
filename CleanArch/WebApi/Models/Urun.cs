namespace WebApi.Models
{
    public class Urun
    {
        public int ID { get; set; }
        public string UAdi { get; set; }
        public string Tip { get; set; }
        public DateTime Tarih { get; set; }

        public Urun(int iD, string uAdi, string tip, DateTime tarih)
        {
            this.ID = iD;
            this.UAdi = uAdi;
            this.Tip = tip;
            this.Tarih = tarih;
        }

        public Urun()
        {
        }
    }
}
