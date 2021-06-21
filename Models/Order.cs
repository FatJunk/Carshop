using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carshop.Models{
    public class Order{
        public int id {get; set;}
        public string name {get; set;}
        public string surrName {get; set;}
        public string Address {get; set;}
        public string Phone {get; set;}
        public string Email {get; set;}
        public DateTime orderTime {get; set;}

        public List<OrderDetail> orderDetails {get; set;}
    }
}