﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeacherDemoBackend.Models;

namespace TeacherDemoBackend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Tietoa sovelluksesta";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Yhteystiedot";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TietoaOppimisesta()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Oppitunti1()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Oppitunti2()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Harjoituksia1()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Harjoituksia2()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Oppimateriaalit()
        {
            ViewData["Message"] = "";

            return View();
        }
    }
}
