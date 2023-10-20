using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MhrsRandevu.Entities.GetCities
{
    public class City
    {
        public int value { get; set; }
        public string text { get; set; }
        public List<CityChild> children { get; set; }
        public int value2 { get; set; }
        public int value3 { get; set; }
        public string text2 { get; set; }
        public bool favori { get; set; }
    }


}
