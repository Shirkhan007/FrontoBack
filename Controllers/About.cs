using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
