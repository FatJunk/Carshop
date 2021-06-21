using Carshop.Interfaces;
using Carshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carshop.Mocks{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get{
                return new List<Car>{
                    new Car {
                        Name = "Mercedes-Benz C-Class",
                        Description = "Среднеразмерный премиум-универсал",
                        Pic = "/img/mb-c-s206-front.jpg",
                        Price = 45000,
                        isFav = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        Name = "Toyota Camry",
                        Description = "Бизнес седан",
                        Pic = "/img/Camry-VX50-new.jpg",
                        Price = 24000,
                        isFav = false,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "BMW M3 F80",
                        Description = "Спорт седан",
                        Pic = "/img/bmw-m3.jpg",
                        Price = 55000,
                        isFav = false,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}