namespace MhrsRandevu.Entities.Appointment
{
    public class Hekim
    {
        public string id { get; set; }
        public int mhrsHekimId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public Cinsiyet cinsiyet { get; set; }
    }
}