using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Teams()
        {
            return PartialView();
        }
    }
}
