using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Logging;
using Movies.Models;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        List<Movie> movieFilledList = new List<Movie>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public IActionResult MovieRegistration()
        {
            return View(new Movie());
        }

        public IActionResult DisplayPage(Movie movie)
        {
            //create actor list and director list and put them into the object
            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return View("MovieRegistration", movie);
            }
        }

        public IActionResult SaveMovieToList(Movie movie)
        {
            string movieListJSON = HttpContext.Session.GetString("MovieListSession") ?? "EmptySession";
            if (movieListJSON != "EmptySession")
            {
                movieFilledList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
            }
            movieFilledList.Add(movie);

            movieListJSON = JsonSerializer.Serialize(movieFilledList);

            HttpContext.Session.SetString("MovieListSession", movieListJSON);

            return View("ListMovies", movieFilledList);
        }

        public IActionResult ListMovies()
        {
            string movieListJSON = HttpContext.Session.GetString("MovieListSession") ?? "EmptySession";
            if (movieListJSON != "EmptySession")
            {
                movieFilledList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
            }
            return View(movieFilledList);
        }
    }
}
