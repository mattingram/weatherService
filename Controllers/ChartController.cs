using System;
using Microsoft.AspNetCore.Mvc;

namespace WeatherService.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
