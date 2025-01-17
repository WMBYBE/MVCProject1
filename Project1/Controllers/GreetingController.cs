﻿using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class GreetingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Greetings model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Greeting = model.GenerateGreeting();
            }

            return View(model);
        }
    }
}
