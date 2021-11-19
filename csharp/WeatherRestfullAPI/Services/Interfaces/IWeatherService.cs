﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherRestfullAPI.Services.Interfaces
{
    public interface IWeatherService
    {
        JObject RetrieveOpenWeatherStatus();
        HttpResponseMessage RetrieveRequest();
    }
}
