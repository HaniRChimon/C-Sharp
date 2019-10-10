using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quoting_Dojo.Models;
using System.ComponentModel.DataAnnotations;


namespace Quoting_Dojo.Controllers {
    public class HomeController : Controller 
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index () {
            return View ();
        }
        [HttpGet("Dashboard")]
        public IActionResult Dashboard (){
            List<User> AllUsers = dbContext.Users.ToList();
            return View("Dashboard", AllUsers);
        }

        [HttpPost("Create")]
        public IActionResult Create ( User user){
            if (ModelState.IsValid)
            {
                dbContext.Add(user);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }
    }
}