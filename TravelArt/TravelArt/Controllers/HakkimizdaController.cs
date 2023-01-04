using Microsoft.AspNetCore.Mvc;

namespace TravelArt.Controllers
{
    public class HakkimizdaController : Controller
    {
        public IActionResult HakkimizdaIndex()
        {
            return View();
        }
    }
}
