using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Carshop.Interfaces;
using Carshop.Models;

namespace Carshop.Controllers{
    public class OrderController : Controller {
        private readonly IAllOrders allOrders;
        private readonly CarshopCart carshopCart;

        public OrderController(IAllOrders allOrders, CarshopCart carshopCart){
            this.allOrders = allOrders;
            this.carshopCart = carshopCart;
        }

        public IActionResult Checkout(){
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order){

            carshopCart.listCarshopItems = carshopCart.GetCarshopCartItems();

            if(carshopCart.listCarshopItems.Count == 0){
                ModelState.AddModelError("","В корзине должны быть добавленны товары");
            }

            if(ModelState.IsValid){
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete(){
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}