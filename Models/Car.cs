using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carshop.Models{
    public class Car{
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public string Pic {get; set;}
        public ushort Price {get; set;}
        public bool isFav {get; set;}
        public int categoryId {get; set;}
        public virtual Category Category {get; set;}

    }

}