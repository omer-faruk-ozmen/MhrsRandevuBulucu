namespace MhrsRandevu.Entities.Appointment
{
    public class GetAppointment
    {
        public string aksiyonId { get; set; } = "200";
        public string cinsiyet { get; set; } = "F";
        public int mhrsHekimId { get; set; } = -1;
        public int mhrsIlId { get; set; }
        public int mhrsIlceId { get; set; }
        public int mhrsKlinikId { get; set; }
        public int mhrsKurumId { get; set; }
        public int muayeneYeriId { get; set; } = -1;
        public bool tumRandevular { get; set; }=false;
        public bool ekRandevu { get; set; } = false;
        public object randevuZamaniList { get; set; } =null;
    }
}
