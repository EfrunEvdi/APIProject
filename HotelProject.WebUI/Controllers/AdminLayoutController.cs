using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminLayoutController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> _AdminLayout()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserImage = user.ImageURL;
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult PreloaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavheaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
