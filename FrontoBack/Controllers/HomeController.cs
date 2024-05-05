using Microsoft.AspNetCore.Mvc;

namespace FrontoBack.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
