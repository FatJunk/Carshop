using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Models;

namespace Carshop.ViewModels{
    public class HomeViewModel{
        public IEnumerable<Car> favCars {get; set;}
    }
}