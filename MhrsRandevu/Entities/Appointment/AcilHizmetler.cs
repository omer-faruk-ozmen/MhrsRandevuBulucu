namespace MhrsRandevu.Entities.Appointment
{
    public class AcilHizmetler
    {
        public int id { get; set; }
        public int mhrsKurumId { get; set; }
        public int lacilPoliklinikTipi { get; set; }
        public AcilPoliklinikTipi acilPoliklinikTipi { get; set; }
        public bool aktif { get; set; }
        public AktifDsc aktifDsc { get; set; }
    }
}
