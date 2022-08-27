using GlowingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlowingApp.Areas.Dashboard.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GlowingDbContext _context;

        public CategoryController(GlowingDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Catagories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
