using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Models;

namespace Carshop.Interfaces{
    public interface IAllCars{
        IEnumerable<Car> Cars {get; set;}
        IEnumerable<Car> getFavCars {get; set;}
        Car getObjectCar(int carId);
    }
}