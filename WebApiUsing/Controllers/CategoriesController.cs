using Microsoft.AspNetCore.Mvc;

namespace WebApiUsing.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
