using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace OpenWeatherMap.ViewModels.OpenWeatherMap
{
    public class vmZipCodeEntry
    {

        [Required]
        [MaxLength(10, ErrorMessage="Zip code can't be more than 10 characters")]
        [MinLength(5, ErrorMessage="Zip must be at least 5 characters in length.")]
        [Display(Name = "ZIP Code: ")]      
        public string ZipCode { get; set; }
    }
}
