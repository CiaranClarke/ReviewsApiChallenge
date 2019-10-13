using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsApi;

namespace ReviewsApi.Models
{
    public class AddressComponent
    {
        [JsonProperty("long_name")]
        public string long_name { get; set; }
        [JsonProperty("short_name")]
        public string short_name { get; set; }
        [JsonProperty("types")]
        public IList<string> types { get; set; }
    }

    public class Review
    {
        [JsonProperty("author_name")]
        public string author_name { get; set; }
        [JsonProperty("author_url")]
        public string author_url { get; set; }
        [JsonProperty("language")]
        public string language { get; set; }
        [JsonProperty("profile_photo_url")]
        public string profile_photo_url { get; set; }
        [JsonProperty("rating")]
        public int rating { get; set; }
        [JsonProperty("relative_time_description")]
        public string relative_time_description { get; set; }
        [JsonProperty("text")]
        public string text { get; set; }
        [JsonProperty("time")]
        public int time { get; set; }
    }

    public class Result
    {
        [JsonProperty("address_components")]
        public IList<AddressComponent> address_components { get; set; }
        [JsonProperty("adr_address")]
        public string adr_address { get; set; }
        [JsonProperty("formatted_address")]
        public string formatted_address { get; set; }
        [JsonProperty("formatted_phone_number")]
        public string formatted_phone_number { get; set; }
        [JsonProperty("geometry")]
        public Geometry geometry { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("international_phone_number")]
        public string international_phone_number { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("place_id")]
        public string place_id { get; set; }
        [JsonProperty("rating")]
        public double rating { get; set; }
        [JsonProperty("reference")]
        public string reference { get; set; }
        [JsonProperty("reviews")]
        public IList<Review> reviews { get; set; }
        [JsonProperty("types")]
        public IList<string> types { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("utc_offset")]
        public int utc_offset { get; set; }
        [JsonProperty("vicinity")]
        public string vicinity { get; set; }
        [JsonProperty("website")]
        public string website { get; set; }
    }

    public class RootObject
    {
        public IList<object> html_attributions { get; set; }
        public Result result { get; set; }
        public string status { get; set; }
    }
}
