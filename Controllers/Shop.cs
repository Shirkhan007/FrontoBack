﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
