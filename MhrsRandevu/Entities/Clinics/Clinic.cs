using System.Collections.Generic;

namespace MhrsRandevu.Entities.Clinics
{
    public class Clinic
    {
        public int value { get; set; }
        public string text { get; set; }
        public List<object> children { get; set; }
        public int value2 { get; set; }
        public int value3 { get; set; }
        public string text2 { get; set; }
        public bool favori { get; set; }
    }
}