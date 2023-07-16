using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Abouts()
        {
            return PartialView();
        }
    }
}
