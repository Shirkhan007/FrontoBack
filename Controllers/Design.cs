﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class Design : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
