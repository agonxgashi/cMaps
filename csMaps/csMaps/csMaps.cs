using System.Collections.Generic;
using Newtonsoft.Json;

namespace csMaps
{
    public class csMap
    {
        [JsonProperty(PropertyName = "results")]
        public List<Result> results = new List<Result>();

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "error_message")]
        public string ErrorMessage { get; set; }
    }

    public class Result
    {
        [JsonProperty(PropertyName = "address_components")]
        public List<AddressComponents> AddressComponents = new List<AddressComponents>();

        [JsonProperty(PropertyName = "formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty(PropertyName = "geometry")]
        public Geometry geometry = new Geometry();

        [JsonProperty(PropertyName = "partial_match")]
        public bool PartialMatch { get; set; }

        [JsonProperty(PropertyName = "place_id")]
        public string PlaceId { get; set; }

        [JsonProperty(PropertyName = "types")]
        public List<string> Types = new List<string>();
        
    }

    public class AddressComponents
    {
        [JsonProperty(PropertyName = "long_name")]
        public string LongName { get; set; }
        
        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "types")]
        public List<string> Types = new List<string>();

    }



    public class Geometry
    {
        [JsonProperty(PropertyName = "bounds")]
        public Bounds Bounds { get; set; }

        [JsonProperty(PropertyName = "location")]
        public LatLng Location = new LatLng();

        [JsonProperty(PropertyName = "location_type")]
        public string LocationType { get; set; }

        [JsonProperty(PropertyName = "viewport")]
        public Bounds Viewport { get; set; }
    }

    public class Bounds
    {
        [JsonProperty(PropertyName = "northeast")]
        public LatLng Northeast { get; set; }

        [JsonProperty(PropertyName = "southwest")]
        public LatLng Southwest { get; set; }
    }

    public class LatLng
    {
        [JsonProperty(PropertyName = "lat")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public string Longitude { get; set; }
    }
}
