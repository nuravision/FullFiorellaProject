using Microsoft.AspNetCore.Mvc;

namespace FullFiorellaProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
