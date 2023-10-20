using System.Collections.Generic;

namespace MhrsRandevu.Entities.Appointment
{
    public class KurumBilgileri
    {
        public int mhrsKurumId { get; set; }
        public string halkDilindekiAdi { get; set; }
        public object telefonNumarasi { get; set; }
        public string eposta { get; set; }
        public string adres { get; set; }
        public double enlem { get; set; }
        public double boylam { get; set; }
        public int mhrsIlId { get; set; }
        public int mhrsIlceId { get; set; }
        public string ilAdi { get; set; }
        public string ilceAdi { get; set; }
        public string kurumAdi { get; set; }
        public object mesafe { get; set; }
        public object mesafeKm { get; set; }
        public int kurumTurId { get; set; }
        public object anaKurumAdi { get; set; }
        public object anaKurumKisaAdi { get; set; }
        public List<AcilHizmetler> acilHizmetler { get; set; }
    }
}