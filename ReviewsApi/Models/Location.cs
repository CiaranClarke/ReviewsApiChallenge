using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsApi
{
    public class Location
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("display_address")]
        public List<string> DisplayAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }
}
