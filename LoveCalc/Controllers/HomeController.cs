using LoveCalc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoveCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LoveResults(string name1, string name2)
        {
            var loveApi = new LoveApi();
            var compatibility = loveApi.GetMatchPercentage(name1, name2);


            return View("LoveResults", compatibility);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}