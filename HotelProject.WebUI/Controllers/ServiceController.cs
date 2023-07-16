using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Services()
        {
            return PartialView();
        }
    }
}
