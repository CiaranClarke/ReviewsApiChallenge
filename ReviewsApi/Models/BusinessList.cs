using Newtonsoft.Json;
using ReviewsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsApi
{
    [Serializable]
    public class BusinessList
    {
        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("image_url")]
        public string Image_url { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("display_phone")]
        public string Display_phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("is_closed")]
        public bool Is_closed { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("review_count")]
        public int Review_count { get; set; }

        [JsonProperty("photos")]
        public List<string> Photos { get; set; }

        [JsonProperty("hours")]
        public List<Hour> Hours { get; set; }

        [JsonProperty("is_claimed")]
        public bool Is_claimed { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("special_hours")]
        public List<SpecialHour> Special_hours { get; set; }

        [JsonProperty("transactions")]
        public List<object> Transactions { get; set; }

    }

    public class Center
    {
        [JsonProperty("longitude")]
        public double longitude { get; set; }
        [JsonProperty("latitude")]
        public double latitude { get; set; }
    }

    public class Region
    {
        [JsonProperty("center")]
        public Center center { get; set; }
    }

    public class Business
    {
        public IList<BusinessList> businesses { get; set; }
        public int total { get; set; }
        public Region region { get; set; }
    }

}