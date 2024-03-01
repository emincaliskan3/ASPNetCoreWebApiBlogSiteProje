using Microsoft.AspNetCore.Mvc;

namespace WebApiUsing.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
