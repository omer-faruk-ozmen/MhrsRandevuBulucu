using System.Collections.Generic;

namespace MhrsRandevu.Entities.Hospitals
{
    public class ReturnHospital
    {
        public string lang { get; set; }
        public bool success { get; set; }
        public List<Info> infos { get; set; }
        public List<object> warnings { get; set; }
        public List<object> errors { get; set; }
        public List<Hospital> data { get; set; }
    }


}
