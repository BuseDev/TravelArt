using Microsoft.AspNetCore.Mvc;

namespace TravelArt.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogIndex()
        {
            return View();
        }
    }
}
