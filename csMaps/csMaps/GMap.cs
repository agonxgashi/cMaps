using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace csMaps
{
    public class GMap
    {

        private static string apiName = "http://maps.googleapis.com/maps/api/geocode/json?address=";

        public static csMap GetLocation(string location)
        {
            string res = GetLocationJsonString(location);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<csMap>(res);
        }

        public static string GetLocationJsonString(string location)
        {
            try
            {
                string res = String.Empty;
                string reqStr = apiName + (String.IsNullOrEmpty(location) ? "" : location);
                using (HttpClient client = new HttpClient())
                    res = client.GetStringAsync(reqStr).Result;

                return res;
            }
            catch (Exception)
            {
                return null;
            }

        }


        public static double? DistanceBetweenPlacesInKilometers(LatLng location1, LatLng location2)
        {

            double lat1;
            double lat2;
            double lng1;
            double lng2;

            bool rLat1 = double.TryParse(location1?.Latitude,out lat1);
            bool rLat2 = double.TryParse(location2?.Latitude, out lat2);
            bool rLng1 = double.TryParse(location1?.Longitude, out lng1);
            bool rLng2 = double.TryParse(location2?.Longitude, out lng2);

            if (!rLat1 || !rLat2 || !rLng1 || !rLng2)
                return null;

            double dlon = MapsCalc.Radians(lng2 - lng1);
            double dlat = MapsCalc.Radians(lat2 - lat1);

            double a = (Math.Sin(dlat / 2) * Math.Sin(dlat / 2)) 
                        + Math.Cos(MapsCalc.Radians(lat1)) * Math.Cos(MapsCalc.Radians(lat2)) 
                        * (Math.Sin(dlon / 2) 
                        * Math.Sin(dlon / 2));

            double angle = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return Math.Round(angle * MapsCalc.RADIUS, 2)  ;
        }


    }
}