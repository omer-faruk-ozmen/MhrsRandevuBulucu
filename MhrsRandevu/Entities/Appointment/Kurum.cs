namespace MhrsRandevu.Entities.Appointment
{
    public class Kurum
    {
        public int mhrsKurumId { get; set; }
        public int mhrsAnaKurumId { get; set; }
        public string kurumAdi { get; set; }
        public string kurumKisaAdi { get; set; }
        public int kurumTurId { get; set; }
        public IlIlce ilIlce { get; set; }
    }
}