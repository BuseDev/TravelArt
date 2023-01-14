using Microsoft.AspNetCore.Mvc;

namespace TravelArt.Controllers
{
    public class GezilecekYerlerController : Controller
    {
        public IActionResult GezilecekYerlerIndex()
        {
            return View();
        }
    }
}
