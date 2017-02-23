using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace csMaps
{
    class csMaps
    {
        [JsonProperty(PropertyName = "results")]
        public List<Result> results = new List<Result>();

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }
    }

    class Result
    {
        [JsonProperty(PropertyName = "geometry")]
        public Geometry geometry = new Geometry();
    }

    class Geometry
    {
        [JsonProperty(PropertyName = "location")]
        public Location Location = new Location();
    }

    class Location
    {
        [JsonProperty(PropertyName = "lat")]
        public string lat { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public string lng { get; set; }
    }
}
