using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rasai_web.Models;
using System.Diagnostics;

namespace Rasai_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly MenuContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(MenuContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Menu()
        {
            var menuItems = await _context.MenuItems.ToListAsync();
            if (menuItems.Count() == null)
            {
                ViewBag.Message = "No menu items found.";
            }
            return View(menuItems);
        }

        public IActionResult Booking()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult CreateEditMenu()
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
