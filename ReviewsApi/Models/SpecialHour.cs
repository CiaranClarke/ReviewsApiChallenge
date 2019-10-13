using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsApi
{
    public class SpecialHour
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("is_overnight")]
        public bool IsOvernight { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }
    }
}
