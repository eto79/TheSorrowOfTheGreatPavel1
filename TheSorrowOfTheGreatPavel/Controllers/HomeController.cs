using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheSorrowOfTheGreatPavel.Data;
using TheSorrowOfTheGreatPavel.Models;

namespace TheSorrowOfTheGreatPavel.Controllers
{
    public class HomeController : Controller
    {
        private readonly BazaContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BazaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int id) => View();

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FLStudio()
        {
            return View();
        }

        public IActionResult Ableton()
        {
            return View();
        }

        public IActionResult Reaper()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
