using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carshop.Models{
    public class Car{
        public int Id {get; set;}
        public string Name {get; set;}
        public Company Company {get; set;}
        public string Description {get; set;}
        public decimal Price {get; set;}

    }

    public class Company{
        public int Id {get; set;}
        public string CompanyName {get; set;}
        public List<Company> Companies {get; set;}
        public Company(){
            Companies = new List<Company>();
        }
    }
}