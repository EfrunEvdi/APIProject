using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WepApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelProject.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserWorkLocationController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult UsersListWithWorkLocations()
        {
            // var values = _appUserService.TUsersListWithWorkLocations();
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                UserName = y.UserName,
                Email = y.Email,
                Gender = y.Gender,
                ImageURL = y.ImageURL,
                PhoneNumber = y.PhoneNumber,
                WorkLocationID = y.WorkLocationID,
                WorkLocationName = y.WorkLocation.Name,
                Country = y.Country,
                City = y.WorkLocation.City,
            });
            return Ok(values);
        }
    }
}
