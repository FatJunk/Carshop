using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Interfaces;
using Carshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Carshop.Data{
    public class CarRepository : IAllCars
    {
        private readonly CarDbContent carDbContent;
        public CarRepository(CarDbContent carDbContent){
            this.carDbContent = carDbContent;
        }
        public IEnumerable<Car> Cars => carDbContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => carDbContent.Car.Where(p => p.isFav).Include(c => c.Category);

        public Car getObjectCar(int carId) => carDbContent.Car.FirstOrDefault(p => p.Id == carId);
        
    }
}