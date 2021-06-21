using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Carshop.Models{
    public class CarshopCart{
        private readonly CarDbContent carDbContent;
        public CarshopCart(CarDbContent carDbContent){
            this.carDbContent = carDbContent;
        }
        public string CarshopCartId {get; set;}
        public List<CarshopCartItem> listCarshopItems {get; set;}

        public static CarshopCart GetCart(IServiceProvider services){
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<CarDbContent>();
            string carshopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", carshopCartId);

            return new CarshopCart(context) {CarshopCartId = carshopCartId};
        }

        public void AddToCart(Car car){
            carDbContent.CarshopCartItem.Add(new CarshopCartItem {
                CarshopCartId = CarshopCartId,
                car = car,
                price = car.Price
            });
            carDbContent.SaveChanges();
        }

        public List<CarshopCartItem> GetCarshopCartItems(){
            return carDbContent.CarshopCartItem.Where(c => c.CarshopCartId == CarshopCartId).Include(s => s.car).ToList();
        }
    }
}