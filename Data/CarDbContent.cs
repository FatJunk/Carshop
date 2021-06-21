using Microsoft.EntityFrameworkCore;
using Carshop.Models;


namespace Carshop.Models{
    public class CarDbContent : DbContext{
        
        public CarDbContent(DbContextOptions<CarDbContent> options)
        :base(options){

        }
        public DbSet<Car> Car {get; set;}
        public DbSet<Category> Category {get; set;}
        public DbSet<CarshopCartItem> CarshopCartItem {get; set;}
        public DbSet<Order> Order {get; set;}
        public DbSet<OrderDetail> OrderDetail {get; set;}

    }
}