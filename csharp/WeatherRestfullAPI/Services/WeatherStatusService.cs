using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using WeatherRestfullAPI.Services.Interfaces;

namespace WeatherRestfullAPI
{
    public class WeatherStatusService : IWeatherService
    {
        public static int latitude {get; set;}
        public static int longitude {get; set;}
        public HttpResponseMessage RetrieveRequest()
        {
            string url = @"https://api.openweathermap.org/data/2.5/onecall/timemachine?lat=2000&lon=2000}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
        }
        
    }
}
