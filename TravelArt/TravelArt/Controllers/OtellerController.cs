using Microsoft.AspNetCore.Mvc;

namespace TravelArt.Controllers
{
    public class OtellerController : Controller
    {
        public IActionResult OtellerIndex()
        {
            return View();
        }
    }
}
