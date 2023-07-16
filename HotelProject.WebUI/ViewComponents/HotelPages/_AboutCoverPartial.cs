using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.About
{
    public class _AboutCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
