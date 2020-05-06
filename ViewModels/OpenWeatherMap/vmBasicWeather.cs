using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenWeatherMap.ViewModels.OpenWeatherMap
{
    public class vmBasicWeather
    {
        [Editable(false)]
        [Display(Name = "Zip Code")]

        public int zip { get; set; }

        [Editable(false)]
        [Display(Name = "City")]
        [JsonProperty("name")]
        public string city { get; set; }

        [Editable(false)]
        [Display(Name = "Temperature")]
        [JsonProperty("temp")]
        public float temp { get; set; }
        [Editable(false)]
        [Display(Name = "Weather")]
        public string main { get; set; }
        [Editable(false)]
        [Display(Name = "Description")]
        public string description { get; set; }



    }
}
