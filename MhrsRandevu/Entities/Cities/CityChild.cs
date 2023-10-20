using System.Collections.Generic;

namespace MhrsRandevu.Entities.Cities
{
    public class CityChild
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