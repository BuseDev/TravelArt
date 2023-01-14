using Microsoft.AspNetCore.Mvc;

namespace TravelArt.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult LogInIndex()
        {
            return View();
        }
    }
}
