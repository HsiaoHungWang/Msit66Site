using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Msit66Site.Models;

namespace Msit66Site.Controllers
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

		public IActionResult About()
		{
			return View();
		}

        public IActionResult JsonDemo()
        {
            return View();
        }
		public IActionResult First()
		{
			return View();
		}

		public IActionResult Address()
		{
			return View();
		}

		public IActionResult Show()
		{
			return View();
		}

		public IActionResult Member()
		{
			return View();
		}


		public IActionResult Privacy()
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
