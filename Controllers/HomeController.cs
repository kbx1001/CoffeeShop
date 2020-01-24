using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Coffee_Shop.Models;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrationPage()
        {
            return View();
        }

        public IActionResult Registered(
            string username, 
            string email, 
            string password)
        {
            return View();
        }

        //need one action to load out RegistrationPage, also need a view

        //need one action to take those user inputs, and display the user name, in a new view

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Register(string Name, string password, string email)
        {
            //make to viewBag objects to hold my two parameters
            //as long as this name hasn't been used I can name my ViewBag
            ViewBag.Name = Name;
            ViewBag.Email = email;
            ViewBag.Password = password;
            //grab my user input and store it in a variable
            // string UserInput = userInput;
            return View("~/views/home/WelcomePage.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
