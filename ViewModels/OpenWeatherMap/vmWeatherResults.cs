using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenWeatherMap.ViewModels.OpenWeatherMap
{
    public class vmWeatherResults
    {
        [Display(Name = "ZIP Code")]
        public string Zip { get; set; }
        [Display(Name = "Current Temperature")]
        public string CurrentTemp { get; set; }


    }
}
