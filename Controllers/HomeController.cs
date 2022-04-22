using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
            return View();
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View("NewChef");
        }

        [HttpPost("addChef")]
        public IActionResult addChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
                return View("Index");
            }
        }


        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
            return View("Dishes");
        }

        [HttpGet("dishes/new")]

        public IActionResult NewDish()
        {
            ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
            // this was a problem like the lecture said it would be
            return View();
        }


        [HttpPost("dishes/addDish")]
        public IActionResult addDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
                // do i want to return to dishes with a small or capital D?
            }
            else
            {
                ViewBag.AllChefs = _context.Chefs.Include(a => a.MyDishes).ToList();
                return View("NewDish");
            }
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
    }
}