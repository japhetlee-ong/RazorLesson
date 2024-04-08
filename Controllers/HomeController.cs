using Microsoft.AspNetCore.Mvc;
using RazorLesson.Models;
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace RazorLesson.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    var model = new List<ShoppingModel>
        //    {
        //        new ShoppingModel
        //        {
        //            Amount= 5,
        //            Name = "Apples"
        //        },
        //        new ShoppingModel
        //        {
        //            Amount= 2,
        //            Name = "Shampoo"
        //        },
        //        new ShoppingModel
        //        {
        //            Amount= 1,
        //            Name = "Laptop"
        //        }
        //    };
        //    return View(model);
        //}

        public IActionResult Index()
        {
            var countries = new List<CountryModel>
            {
                new CountryModel { Id = 1, Name = "United States" },
                new CountryModel { Id = 2, Name = "Canada" },
                new CountryModel { Id = 3, Name = "United Kingdom" },

            };

            var usermodel = new UserModel
            {
                CountryList = countries,
            };
            return View(usermodel);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Create(UserModel model)
        {
            return Content($"Your firstname is {model.FirstName} and your lastname is {model.LastName} and your selected country is {model.SelectedCountry}");
        }

        [HttpPost]
        public IActionResult Save(ProductsModel model)
        {
            return Content(model.Description);
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