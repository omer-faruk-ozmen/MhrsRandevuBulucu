using System.Collections.Generic;

namespace MhrsRandevu.Entities.SignIn
{
    public class LoginReturned
    {
        public string lang { get; set; }
        public bool success { get; set; }
        public List<Info> infos { get; set; }
        public List<object> warnings { get; set; }
        public List<Error> errors { get; set; }
        public Data data { get; set; }
    }
}
