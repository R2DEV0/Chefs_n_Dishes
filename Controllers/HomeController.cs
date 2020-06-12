using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chefs_n_Dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace Chefs_n_Dishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

// *******************************************************  GET REQUEST ********************************************************** //
        // landing page to show all Chefs //
        [HttpGet("")]
        public IActionResult Index()
        {
            Chef[] AllChefs = dbContext.Chefs.Include(d => d.CreatedDishes).ToArray();
            return View(AllChefs);
        }

        // page to show all dishes //
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            Dish[] AllDishes = dbContext.Dishes.Include(d => d.Creator).ToArray();
            return View("Dishes", AllDishes);
        }

        // add new dish page view //
        [HttpGet("addDish")]
        public IActionResult AddDish()
        {
            ViewBag.Chefs = dbContext.Chefs.ToArray();
            return View("addDish");
        }

        // add new chef page view //
        [HttpGet("addChef")]
        public IActionResult AddChef()
        {
            return View("AddChef");
        }

// *******************************************************  POST REQUEST ********************************************************* //
        // add a new chef request //
        [HttpPost("/createchef")]
        public IActionResult CreateChef(Chef FromForm)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(FromForm);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("addChef");
            }
        }

        // add a new dish request //
        [HttpPost("/createdish")]
        public IActionResult CreateDish(Dish FromForm)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(FromForm);
                dbContext.SaveChanges();
                return RedirectToAction("dishes");
            }
            else
            {
                return View("addDish");
            }
        }
    }
}
