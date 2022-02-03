using FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private databaseContext _blahContext { get; set; }

        public HomeController(databaseContext someName)
        {
            
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            ViewBag.Categories = _blahContext.Categories.ToList();
            return View("AddFilm");
        }

        [HttpPost]
        public IActionResult AddFilm(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = _blahContext.Categories.ToList();
                return View();
            }
            
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var entries = _blahContext.Responses
                .Include(x => x.Category)
                .ToList();//move to end
            //.wehre(x => x.field == ___
            //.OrderBy(x..
            return View(entries);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _blahContext.Categories.ToList();
            var movie = _blahContext.Responses.Single(x => x.FilmId == id);
            return View("AddFilm", movie);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse ar)
        {
            _blahContext.Update(ar);
            _blahContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _blahContext.Responses.Single(x => x.FilmId == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            _blahContext.Responses.Remove(ar);
            _blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
