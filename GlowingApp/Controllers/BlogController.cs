using Microsoft.AspNetCore.Mvc;
using GlowingApp.Models;



namespace GlowingApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly GlowingDbContext _db;

        public BlogController(GlowingDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Blogs.ToList());
        }
        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            _db.Blogs.Add(blog);
            _db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
