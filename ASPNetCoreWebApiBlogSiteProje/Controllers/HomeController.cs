using ASPNetCoreWebApiBlogSiteProje.Models;
using Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNetCoreWebApiBlogSiteProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel()
            {


                Categories = _context.Categories.Where(p => p.IsActive && p.IsHome).ToList(),
                Posts = _context.Posts.Where(p => p.IsActive && p.IsHome).ToList()



            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
