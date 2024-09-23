using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class GreetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
