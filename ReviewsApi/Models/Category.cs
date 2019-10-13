using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsApi
{
    public class Category
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }
    }
}
