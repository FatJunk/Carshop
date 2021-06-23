using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Carshop.Interfaces;
using Carshop.ViewModels;
using Carshop.Models;

namespace Carshop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarsController (IAllCars iAllCars, ICarsCategory iCarsCat){
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category){

            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category)){
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else{
                if(string.Equals("universal", category, StringComparison.OrdinalIgnoreCase)){
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Универсал"));
                    currCategory = "Универсал";
                    
                }
                else if (string.Equals("sedan", category, StringComparison.OrdinalIgnoreCase)){
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Седан"));
                    currCategory = "Седан";

                }
                else if (string.Equals("minivan", category, StringComparison.OrdinalIgnoreCase)){
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Минивэн"));
                    currCategory = "Минивэн";

                }
                else if (string.Equals("cupe", category, StringComparison.OrdinalIgnoreCase)){
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Купе"));
                    currCategory = "Купе";

                }


                
            }

            
            var carObj = new CarsListViewModel{
                    allCars = cars,
                    currCategory = currCategory
                };

            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);
        }
    }
}