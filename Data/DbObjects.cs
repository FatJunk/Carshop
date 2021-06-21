using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carshop.Models;
using Carshop.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Carshop.Data{
    public class DbObjects {
        public static void Initial(CarDbContent content){
        
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if(!content.Car.Any()){
                content.AddRange(
                    new Car {
                        Name = "Mercedes-Benz C-Class",
                        Description = "Среднеразмерный премиум-универсал",
                        Pic = "/img/mb-c-s206-front.jpg",
                        Price = 45000,
                        isFav = true,
                        Category = Categories["Универсал"]
                    },
                    new Car {
                        Name = "Toyota Camry",
                        Description = "Бизнес седан",
                        Pic = "/img/Camry-VX50-new.jpg",
                        Price = 24000,
                        isFav = false,
                        Category = Categories["Седан"]
                    },
                    new Car {
                        Name = "BMW M3 F80",
                        Description = "Спорт седан",
                        Pic = "/img/bmw-m3.jpg",
                        Price = 55000,
                        isFav = false,
                        Category = Categories["Седан"]
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get{
                if(category == null){
                    var list = new Category[]{
                        new Category{categoryName = "Седан", Desc = "Закрытый кузов с багажником"},
                        new Category{categoryName = "Универсал", Desc = "Вариант седана с увеличенным багажником"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}