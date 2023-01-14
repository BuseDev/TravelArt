using Microsoft.AspNetCore.Mvc;

namespace TravelArt.Controllers
{
    public class RestoranlarController : Controller
    {
        public IActionResult RestoranlarIndex()
        {
            return View();
        }
    }
}
