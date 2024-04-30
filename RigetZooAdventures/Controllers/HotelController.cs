using Microsoft.AspNetCore.Mvc;

namespace RigetZooAdventures.Controllers
{
    public class HotelController : Controller
    {
        // For hotel information
        public IActionResult Facilities()
        {
            return View();
        }

        public IActionResult Rooms()
        {
            return View();
        }
    }
}
