using System;
using System.Net.Http;

namespace csMaps
{
    public class GMap
    {

        private static string apiName = "http://maps.googleapis.com/maps/api/geocode/json?address=";

        public static csMap GetLocation(string location)
        {
            string res = GetLocationJsonString(location);
            return  Newtonsoft.Json.JsonConvert.DeserializeObject<csMap>(res);
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

    }
}