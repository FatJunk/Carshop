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
    }
}