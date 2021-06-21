using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Interfaces;
using Carshop.Models;

namespace Carshop.Data{
    public class CategoryRepository : ICarsCategory
    {
        private readonly CarDbContent carDbContent;
        public CategoryRepository(CarDbContent carDbContent){
            this.carDbContent = carDbContent;
        }
        public IEnumerable<Category> AllCategories => carDbContent.Category;
    }
}