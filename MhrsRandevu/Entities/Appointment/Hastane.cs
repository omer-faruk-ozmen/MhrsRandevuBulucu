using System;

namespace MhrsRandevu.Entities.Appointment
{
    public class Hastane
    {
        public Hekim hekim { get; set; }
        public MuayeneYeri muayeneYeri { get; set; }
        public Kurum kurum { get; set; }
        public KurumBilgileri kurumBilgileri { get; set; }
        public Klinik klinik { get; set; }
        public CetvelTipi cetvelTipi { get; set; }
        public Aksiyon aksiyon { get; set; }
        public bool hekimOncelikSirasi { get; set; }
        public int bosKapasite { get; set; }
        public bool bos { get; set; }
        public bool ekVar { get; set; }
        public DateTime baslangicZamani { get; set; }
        public DateTime bitisZamani { get; set; }
        public bool favori { get; set; }
        public object randevuEnGecGun { get; set; }
        public BaslangicZamaniStr baslangicZamaniStr { get; set; }
        public BitisZamaniStr bitisZamaniStr { get; set; }
    }
}