using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenWeatherMap.ViewModels.OpenWeatherMap
{
    public class vmDetailedWeather
    {
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

        [Editable(false)]
        [Display(Name = "Wind Speed")]
        public float speed { get; set; }

        [Editable(false)]
        [Display(Name = "Pressure in hectopascals")]
        public int pressure { get; set; }


        [Editable(false)]
        [Display(Name = "Humidity")]
        public int humidity { get; set; }
        [Editable(false)]
        [Display(Name = "Minimum Temperature")]
        public float temp_min { get; set; }
        [Editable(false)]
        [Display(Name = "Highest Temperature")]
        public float temp_max { get; set; }

        //[Editable(false)]
        //[Display(Name = "Rainfall per hour")]
        //public float rainfall { get; set; }

        [Editable(false)]
        [Display(Name = "Sunrise in StarTrek Units")]
        public int sunrise { get; set; }

        [Editable(false)]
        [Display(Name = "Sunset in StarTrek Units")]
        public int sunset { get; set; }


    }
}
