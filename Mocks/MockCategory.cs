using Carshop.Interfaces;
using Carshop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Carshop.Mocks{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories{
            get{
                return new List<Category>{
                    new Category{categoryName = "Седан", Desc = "Закрытый кузов с багажником"},
                    new Category{categoryName = "Универсал", Desc = "Вариант седана с увеличенным багажником"}

                };
            }
        }
    }
}