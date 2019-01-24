using LAB11_TIMEPERSONOFTHEYEAR.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB11_TIMEPERSONOFTHEYEAR.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int startingYear, int endingYear)
        {
            return RedirectToAction("Results", new { startingYear, endingYear });
        }
        [HttpGet]
        public IActionResult Results(int startingYear, int endingYear)
        {
            //do what we want with the numbers
            return View(TimePerson.GetPersons(startingYear, endingYear));
        }

    }
}
