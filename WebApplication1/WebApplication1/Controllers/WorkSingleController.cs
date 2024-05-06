using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class WorkSingleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
