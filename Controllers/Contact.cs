using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
