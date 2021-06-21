using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Carshop.Models;
using Carshop.Interfaces;
using Carshop.ViewModels;

namespace Carshop.Controllers
{
    public class HomeController : Controller
    {
        private  IAllCars _carRep;
        private readonly CarshopCart _carshopCart;

        public HomeController(IAllCars carRep){
            _carRep = carRep;
        }

        public ViewResult Index(){
            var homeCars = new HomeViewModel{
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }





        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
