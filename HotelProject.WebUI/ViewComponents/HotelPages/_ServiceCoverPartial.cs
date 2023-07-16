using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.HotelPages
{
    public class _ServiceCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
