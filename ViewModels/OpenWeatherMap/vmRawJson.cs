using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenWeatherMap.ViewModels.OpenWeatherMap
{
    public class vmRawJson
    {
        
        [DataType(DataType.MultilineText)]
        [Display(Name = "Raw Weather Data")]
        public string output { get; set; }
    }
}
