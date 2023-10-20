using System.Collections.Generic;

namespace MhrsRandevu.Entities.Clinics
{
    public class Result
    {
        public string lang { get; set; }
        public bool success { get; set; }
        public List<Info> infos { get; set; }
        public List<object> warnings { get; set; }
        public List<object> errors { get; set; }
        public List<Clinic> data { get; set; }
    }
}
