using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsApi
{
    [Serializable]
    public class ReviewsList
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("rating")]
        public int Rating { get; set; }
        [JsonProperty("user")]
        public object User { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("time_created")]
        public DateTime TimeCreated { get; set; }
    }

    public class Review
    {
        public IList<ReviewsList> reviews { get; set; }
        public int total { get; set; }
        public IList<string> possible_languages { get; set; }
    }
}
