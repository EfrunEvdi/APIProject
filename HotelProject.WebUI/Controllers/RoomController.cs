using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Rooms()
        {
            return PartialView();
        }
    }
}
