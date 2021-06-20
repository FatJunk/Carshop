using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Models;


namespace Carshop.Interfaces{
    public interface ICarsCategory{
        IEnumerable<Category> AllCategories {get;}
    }
}