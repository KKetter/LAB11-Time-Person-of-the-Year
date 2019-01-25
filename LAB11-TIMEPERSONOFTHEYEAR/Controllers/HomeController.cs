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
        /// <summary>
        /// method to make the View - index render to the main page on start
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            //View() is from IActionResult and looks inside the Views->Home->Index
            return View();
        }
        /// <summary>
        /// information collected from the index page and redirects the user to the results page
        /// </summary>
        /// <param name="startingYear"></param>
        /// <param name="endingYear"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(int startingYear, int endingYear)
        {
            return RedirectToAction("Results", new { startingYear, endingYear });
        }
        /// <summary>
        /// creates view on results page with the contents of List people
        /// </summary>
        /// <param name="startingYear"></param>
        /// <param name="endingYear"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Results(int startingYear, int endingYear)
        {
            List<TimePerson> people = TimePerson.GetPersons(startingYear, endingYear);
            //do what we want with the numbers
            return View(people);
        }

    }
}
