using System.Collections.Generic;

namespace MhrsRandevu.Entities.Appointment
{
    public class Data
    {
        public List<Hastane> hastane { get; set; }
        public List<object> semt { get; set; }
        public List<object> alternatif { get; set; }
        public bool semtAramasi { get; set; }
        public bool ekVar { get; set; }
        public int cetvelTipi { get; set; }
        public int acilacakSekme { get; set; }
        public object aramaSorguDtos { get; set; }
    }
}