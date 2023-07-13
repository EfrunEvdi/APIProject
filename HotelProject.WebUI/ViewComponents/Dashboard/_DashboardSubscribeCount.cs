using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using HotelProject.WebUI.Dtos.FollowersDto;
using Newtonsoft.Json;
using System.Linq;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCount : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/efrunevdi"),
                Headers =
    {
        { "X-RapidAPI-Key", "472f5d6472msh5b1ff28add5cf26p150d4djsn92308d4186f5" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.C1 = resultInstagramFollowersDto.following;
                ViewBag.C2 = resultInstagramFollowersDto.followers;
            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=efrunevdi"),
                Headers =
    {
        { "X-RapidAPI-Key", "472f5d6472msh5b1ff28add5cf26p150d4djsn92308d4186f5" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body);
                ViewBag.C3 = resultTwitterFollowersDto.data.user_info.friends_count;
                ViewBag.C4 = resultTwitterFollowersDto.data.user_info.followers_count;
            }

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fefruncetkin%2F"),
                Headers =
    {
        { "X-RapidAPI-Key", "472f5d6472msh5b1ff28add5cf26p150d4djsn92308d4186f5" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body = await response3.Content.ReadAsStringAsync();
                ResultLinkedInFollowersDto resultLinkedInFollowersDto = JsonConvert.DeserializeObject<ResultLinkedInFollowersDto>(body);
                ViewBag.C5 = resultLinkedInFollowersDto.data.connections_count;
                ViewBag.C6 = resultLinkedInFollowersDto.data.followers_count;
            }

            return View();
        }
    }
}
