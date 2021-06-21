using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carshop.Models{
    public class CarshopCartItem{
        public int Id {get; set;}
        public Car car {get; set;}
        public int price {get; set;}

        public string CarshopCartId {get; set;}
    }
}