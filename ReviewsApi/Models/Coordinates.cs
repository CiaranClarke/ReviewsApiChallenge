using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsApi
{
    public interface ICoordinates
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }

    public class Coordinates : ICoordinates
    {
        public Coordinates()
        {
            this.Latitude = double.NaN;
            this.Longitude = double.NaN;
        }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }
}
