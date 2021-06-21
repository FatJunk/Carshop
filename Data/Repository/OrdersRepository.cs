using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Interfaces;
using Carshop.Models;

namespace Carshop.Data.Repository{
    public class OrdersRepository : IAllOrders
    {
        private readonly CarDbContent carDbContent;
        private readonly CarshopCart carshopCart;

        public OrdersRepository(CarDbContent carDbContent, CarshopCart carshopCart){
            this.carDbContent = carDbContent;
            this.carshopCart = carshopCart;
        }


        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            carDbContent.Order.Add(order);

            var items = carshopCart.listCarshopItems;

            foreach(var el in items){
                var orderDetail = new OrderDetail(){
                    CarID = el.car.Id,
                    orderId = order.id,
                    price = el.car.Price
                };
                carDbContent.OrderDetail.Add(orderDetail);
            }
            carDbContent.SaveChanges();
        }
    }
}