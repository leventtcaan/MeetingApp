using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewData["Greeting"] = hour < 12 ? "Good Morning" : "Good Afternoon";
            ViewData["UserName"] = "Levent Can";

            var meetinInfo = new MeetingInfo
            {
                Id = 1,
                Location = "İzmir",
                Date = new DateTime(2026, 4, 24, 01, 17, 0),
                NumberOfPeople = 10
            };
            return View(meetinInfo);
        }
    }
}