using DragonDuMekong.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DragonDuMekong.Controllers
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
            var owner = new User("Temp");
            var gameCreator = new GameLobby(owner); 
            return View(gameCreator);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Rules()
        {
            return View();
        }

        public IActionResult GuestJoining()
        {

            var guest = new User("Temp2");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}