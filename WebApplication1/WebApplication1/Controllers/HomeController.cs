using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Services> services=new List<Services>();
            services.Add(new Services()
            {
                Name = "UI/UX design",
                Description = "Ela kursdu getmisem",
                ImageUrl = "UX.jpg"

            });
            services.Add(new Services()
            {
                Name = "Social Media",
                Description = "Necesen",
                ImageUrl = "sc.jpg"


            });
            services.Add(new Services()
            {
                Name = "Marketing",
                Description = "O  zaman dogru adresde deyilsiz",
                ImageUrl = "mr.jpg"

            });
            services.Add(new Services()
            {
                Name = "Graphic",
                Description = "pis doul",
                   ImageUrl = "des.jpg"

            });
            services.Add(new Services()
            {
                Name = "Digital Marketing",
                Description = "Belede",
                ImageUrl = "dm.jpg"

            });
            services.Add(new Services()
            {
                Name = "Marketing Research",
                Description = "Hani bes",
                   ImageUrl = "mkr.jpg"

            });
            services.Add(new Services()
            {
                Name = "Business",
                Description = "Business business",
                   ImageUrl = "Bs.jpg"

            });
            services.Add(new Services()
            {
                Name = "Branding",
                Description = "Ooooooooo",
                   ImageUrl = "br.jpg"

            });
            HomeVM vm = new HomeVM()
            {
                Servicess = services,
            };
            return View(vm);
        }
    }
}
