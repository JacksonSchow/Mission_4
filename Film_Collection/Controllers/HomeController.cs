using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Film_Collection.Models;

namespace Film_Collection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Setting up the context object
        private FilmCollectionContext ContextObject { get; set; }

        public HomeController(ILogger<HomeController> logger, FilmCollectionContext name)
        {
            _logger = logger;
            ContextObject = name;
        }

        // Homepage
        public IActionResult Index()
        {
            return View();
        }

        // Podcast page
        public IActionResult Podcast()
        {
            return View();
        }

        // GET method for the film form
        [HttpGet]
        public IActionResult MoviesForm()
        {
            return View();
        }

        // POST method for the film form. Checks to see if the model is valid, if so it returns a confirmation view and saves the data to the database. If inputs are not valid, it reloads that page with error messages
        [HttpPost]
        public IActionResult MoviesForm(MoviesModel mm)
        {
            if (ModelState.IsValid)
            {
                ContextObject.Add(mm);
                ContextObject.SaveChanges();
                return View("Confirmation", mm);
            }
            else
            {
                return View();
            }
        }
    }
}
