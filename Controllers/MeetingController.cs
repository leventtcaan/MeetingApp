using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(string Name, string Phone, string Email, bool Participation)
        {
            Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}, Participation: {Participation}");
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
