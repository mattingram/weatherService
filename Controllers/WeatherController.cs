using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WeatherService.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        private WeatherContext _context { get; set; }

        public WeatherController(WeatherContext context)
        {
            _context = context;
        }

        // GET api/weather
        [HttpGet]
        [AddHeaderAttribute("Access-Control-Allow-Origin", "*")]
        public IEnumerable<WeatherData> Get()
        {
            return _context.Weather.ToList().OrderByDescending(w => w.Time).Take(100);
        }

        // POST api/weather
        [HttpPost]
        public void Post([FromBody]WeatherData value)
        {
            _context.Add(new WeatherData {
                Time = value.Time,
                Temp = value.Temp,
                Humid = value.Humid,
                Press = value.Press
            });
            _context.SaveChanges();
        }
    }
}
