using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreWebApiBlogSiteProje.Controllers
{
    public class PostsController : Controller
    {
        private readonly DatabaseContext _context;

        public PostsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Posts.Where(p => p.IsActive).Include("Category").ToListAsync());
        }
        public async Task<IActionResult> Search(string q)
        {
            return View(await _context.Posts.Where(p => p.IsActive && p.Name.Contains(q)).Include("Category").ToListAsync());
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var model = await _context.Posts.Include(k => k.Category).FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
    }
}
