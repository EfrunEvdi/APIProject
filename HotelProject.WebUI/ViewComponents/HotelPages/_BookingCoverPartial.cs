using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.HotelPages
{
    public class _BookingCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
