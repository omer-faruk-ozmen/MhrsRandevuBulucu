namespace MhrsRandevu.Entities.SignIn
{
    public class Data
    {
        public string uuid { get; set; }
        public string jwt { get; set; }
        public string kullaniciUuid { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSoyadi { get; set; }
        public KullaniciTipi kullaniciTipi { get; set; }
        public string islemKanali { get; set; }
        public GirisTipi girisTipi { get; set; }
    }
}