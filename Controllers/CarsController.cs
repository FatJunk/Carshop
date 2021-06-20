using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Carshop.Interfaces;

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
    }
}