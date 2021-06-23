using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carshop.Models{
    public class OrderDetail{
        public int id {get; set;}
        public int orderId {get; set;}
        public int carId {get; set;}
        public uint price {get; set;}
        public virtual Car Car {get; set;}
        public virtual Orderz Orderz {get; set;}
    }
}