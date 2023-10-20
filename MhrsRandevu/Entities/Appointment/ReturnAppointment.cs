using System.Collections.Generic;

namespace MhrsRandevu.Entities.Appointment
{
    public class ReturnAppointment
    {
        public string lang { get; set; }
        public bool success { get; set; }
        public List<Info> infos { get; set; }
        public List<object> warnings { get; set; }
        public List<Error> errors { get; set; }
        public Data data { get; set; }
    }
}