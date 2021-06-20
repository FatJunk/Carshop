using Microsoft.EntityFrameworkCore;

namespace Carshop.Models{
    public class CarDbContext : DbContext{
        public DbSet<Car> Cars {get; set;}
        public CarDbContext(DbContextOptions<CarDbContext> options)
        :base(options){

        }

    }
}