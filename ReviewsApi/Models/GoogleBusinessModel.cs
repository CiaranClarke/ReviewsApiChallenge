using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ReviewsApi
{
    [Serializable]
    public class LocationGoogle
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lng")]
        public double lng { get; set; }
    }

    public class Northeast
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lng")]
        public double lng { get; set; }
    }

    public class Southwest
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lat")]
        public double lng { get; set; }
    }

    public class Viewport
    {
        [JsonProperty("northeast")]
        public Northeast northeast { get; set; }
        [JsonProperty("southwest")]
        public Southwest southwest { get; set; }
    }

    public class Geometry
    {
        [JsonProperty("location")]
        public LocationGoogle location { get; set; }
        [JsonProperty("viewport")]
        public Viewport viewport { get; set; }
    }

    public class Photo
    {
        [JsonProperty("height")]
        public int height { get; set; }
        [JsonProperty("html_attributions")]
        public IList<string> html_attributions { get; set; }
        [JsonProperty("photo_reference")]
        public string photo_reference { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
    }

    public class OpeningHours
    {
        [JsonProperty("open_now")]
        public bool open_now { get; set; }
    }

    public class PlusCode
    {
        [JsonProperty("compound_code")]
        public string compound_code { get; set; }
        [JsonProperty("global_code")]
        public string global_code { get; set; }
    }

    public class Results
    {
        [JsonProperty("geometry")]
        public Geometry geometry { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("photos")]
        public IList<Photo> photos { get; set; }
        [JsonProperty("place_id")]
        public string place_id { get; set; }
        [JsonProperty("reference")]
        public string reference { get; set; }
        [JsonProperty("scope")]
        public string scope { get; set; }
        [JsonProperty("types")]
        public IList<string> types { get; set; }
        [JsonProperty("vicinity")]
        public string vicinity { get; set; }
        [JsonProperty("opening_hours")]
        public OpeningHours opening_hours { get; set; }
        [JsonProperty("plus_code")]
        public PlusCode plus_code { get; set; }
        [JsonProperty("rating")]
        public double rating { get; set; }
        [JsonProperty("user_ratings_total")]
        public int user_ratings_total { get; set; }
        [JsonProperty("price_level")]
        public int price_level { get; set; }
    }

    public class PlacesApiResponse
    {
        public IList<object> html_attributions { get; set; }
        public string next_page_token { get; set; }
        public IList<Results> result { get; set; }
        public string status { get; set; }
    }
}