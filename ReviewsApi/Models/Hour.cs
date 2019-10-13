using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsApi
{
    public class Hour
    {
        [JsonProperty("hours_type")]
        public string HoursType { get; set; }

        [JsonProperty("is_open_now")]
        public bool IsOpenNow { get; set; }

        [JsonProperty("open")]
        public Open[] Open { get; set; }
    }
}
