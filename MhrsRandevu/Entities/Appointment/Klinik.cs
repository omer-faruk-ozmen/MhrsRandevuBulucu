using System.Collections.Generic;

namespace MhrsRandevu.Entities.Appointment
{
    public class Klinik
    {
        public int mhrsKlinikId { get; set; }
        public string mhrsKlinikAdi { get; set; }
        public string kisaAdi { get; set; }
        public int lcetvelTipi { get; set; }
        public List<object> yandalList { get; set; }
        public List<object> anadalList { get; set; }
    }
}