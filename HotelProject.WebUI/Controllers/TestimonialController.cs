using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class TestimonialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Testimonials()
        {
            return PartialView();
        }
    }
}
