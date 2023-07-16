using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.HotelPages
{
    public class _TeamCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
