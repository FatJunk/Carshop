using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Interfaces;
using Carshop.Models;
using Carshop.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Carshop.Controllers{
    public class CarshopCartController : Controller {
        private  readonly IAllCars _carRep;
        private readonly CarshopCart _carshopCart;

        public CarshopCartController(IAllCars carRep, CarshopCart carshopCart){
            _carRep = carRep;
            _carshopCart = carshopCart;
        }

        public ViewResult Index(){
            var items = _carshopCart.GetCarshopCartItems();
            _carshopCart.listCarshopItems = items;

            var obj = new CarshopCartViewModel{
                carshopCart = _carshopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id){
            var item = _carRep.Cars.FirstOrDefault(i => i.Id == id);
            if(item != null){
                _carshopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}