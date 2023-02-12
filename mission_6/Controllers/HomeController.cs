
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission_6.Models;

namespace mission_6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieRecordCtxt _movieCtxt { get; set; }

// constructor for home controller obj
        public HomeController(ILogger<HomeController> logger, MovieRecordCtxt movCtxt) {
            _logger = logger;
            _movieCtxt = movCtxt;
        }

        public IActionResult Index() { return View(); }

        public IActionResult Privacy() { return View(); }

        [HttpGet]
        public IActionResult Movie() { return View(); }

        [HttpPost]
        public IActionResult Movie(Movie mov) {
            _movieCtxt.Add(mov);
            _movieCtxt.SaveChanges();
            return View("Confirmation", mov);
        }

        public IActionResult Podcasts() { return View(); }

        public IActionResult Bacon() { return Redirect("https://baconsale.com/"); }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
