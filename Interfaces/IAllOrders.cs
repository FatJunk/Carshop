using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Models;

namespace Carshop.Interfaces{
   public interface IAllOrders{
        void createOrder(Order order);
    }
}