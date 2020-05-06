using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;

namespace OpenWeatherMap.Models
{

    public class OpenWeatherAPI
    {

        private string _apiKey;
        private HttpClient _client;
        public OpenWeatherAPI(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient();

        }

        ~OpenWeatherAPI()
        {
            _client.Dispose();
        }


        public async Task<string> ProcessResponse(string zipCode)
        {

            string uri = GetUri(zipCode, "imperial");
           //  var response = await _client.GetStringAsync(uri);
             var response = await _client.GetAsync(uri);

         // (response.IsSuccessStatusCode)
       
                return await response.Content.ReadAsStringAsync();
     


          //  return response;

      


         //   return zipCode;

        }


        private string GetUri(string zipCode, string unitType)
        {
            
            var builder = new StringBuilder();
            builder.Append("http://api.openweathermap.org/data/2.5/weather");

            builder.Append("?");
            builder.Append("zip=");
            builder.Append(zipCode);

            builder.Append("&");
            builder.Append("units=");
            builder.Append(unitType);

            builder.Append("&");
            builder.Append("APPID=");
            builder.Append("e1db07dc00a073bfedbd4ef37ba27fd8");

            return builder.ToString();
        }
    }
}
