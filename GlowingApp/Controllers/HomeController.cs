using GlowingApp.Models;
using GlowingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;



namespace GlowingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GlowingDbContext _db;

        public HomeController(ILogger<HomeController> logger, GlowingDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM vm = new()
            {
                Section1s = _db.Section1s.OrderByDescending(c => c.Id).ToList(),
                FavoriteProducts = _db.Products.Where(c => c.Isfeatured).ToList(),
                FeaturedProducts = _db.Products.Where(c => c.Isfeatured).ToList(),
                Catagories = _db.Catagories.OrderByDescending(c => c.Id).ToList(),
            };
            return View(vm);
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