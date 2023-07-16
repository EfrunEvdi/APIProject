using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.HotelPages
{
    public class _RoomCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
