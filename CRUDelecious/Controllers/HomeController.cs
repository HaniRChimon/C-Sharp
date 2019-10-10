using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelecious.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUDelecious.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;
        public HomeController(HomeContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> allDishes = dbContext.Dishes.ToList();
            return View("Index", allDishes);
        }
        [HttpGet("newdish")]
        public IActionResult NewDish ()
        {
            return View("NewDish");
        }
        [HttpPost("processdish")]
        public IActionResult ProcessDish (Dish newDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewDish");
            }
        }
        [HttpGet("dish/{dishId}")]
        public IActionResult ShowDish (int dishId)
        {
            Dish display = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(display);
        }
        [HttpGet("delete/{dishId}")]
        public IActionResult RemoveDish (int dishId)
        {
            Dish dishToDelete = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            dbContext.Dishes.Remove(dishToDelete);
            dbContext.SaveChanges();
            return RedirectToAction ("Index");
        }
    }
}
    
