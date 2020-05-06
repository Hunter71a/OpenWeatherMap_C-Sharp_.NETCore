using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenWeatherMap.ViewModels.OpenWeatherMap;
using OpenWeatherMap.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace OpenWeatherMap.Controllers
{
    public class OpenWeatherMapController : Controller
    {
        // static HttpClient client = new HttpClient();
        //   private static readonly string apiKey = "e1db07dc00a073bfedbd4ef37ba27fd8";

        // GET: OpenWeatherMap
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult InputZipCode()
        {
            return View();
        }

        

        [HttpPost]
        public async Task<IActionResult> InputZipCode(vmZipCodeEntry model)
        {
            string apiKey = "e1db07dc00a073bfedbd4ef37ba27fd8";
            var openWeather = new OpenWeatherAPI(apiKey);
            string response = await openWeather.ProcessResponse(model.ZipCode);
            string zipCode = model.ZipCode;
         
     
            var test = new vmRawJson();
            test.output = response;

            return View("RawJson", test);
            
           // return View("RawJson", test);

        }




        [HttpPost]
        public async Task<ActionResult> Index(vmZipCodeEntry model)
        {
            string apiKey = "e1db07dc00a073bfedbd4ef37ba27fd8";
            var openWeather = new OpenWeatherAPI(apiKey);
            string response = await openWeather.ProcessResponse(model.ZipCode);

            // return response;


            var data = JsonConvert.DeserializeObject<OpenWeatherResults>(response);

            //return data.main.CurrentTemp.ToString();

            var viewModel = new vmBasicWeather
            {
                zip = ToInt32(model.ZipCode),
                temp = data.main.CurrentTemp,
                city = data.name,
              main = data.weather[0].main,
                description = data.weather[0].description

                };


            return View("BasicWeather", viewModel);
        }

        public ActionResult GetDetailedWeather()
        {

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> GetDetailedWeather(vmZipCodeEntry model)
        {
            string apiKey = "e1db07dc00a073bfedbd4ef37ba27fd8";
            var openWeather = new OpenWeatherAPI(apiKey);
            string response = await openWeather.ProcessResponse(model.ZipCode);

            // return response;


            var data = JsonConvert.DeserializeObject<OpenWeatherResults>(response);

            //return data.main.CurrentTemp.ToString();

            var viewModel = new vmDetailedWeather
            {
                temp = data.main.CurrentTemp,
                city = data.name,
                main = data.weather[0].main,
                description = data.weather[0].description,
                speed = data.wind.speed,
                humidity = data.main.humidity,
                temp_max = data.main.temp_max,
                temp_min = data.main.temp_min,
                pressure = data.main.pressure,
              // rainfall =data.clouds.all,
               sunrise = data.sys.sunrise,
               sunset = data.sys.sunset

                


            };


            return View("DetailedWeather", viewModel);
        }
        

        public ActionResult WeatherResults()
        {
            return View();
        }

        public static int ToInt32(string value)
        {
            if (value == null)
                return 0;
            return int.Parse(value, (IFormatProvider)CultureInfo.CurrentCulture);
        }
    }

}

