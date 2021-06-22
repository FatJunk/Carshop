using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Carshop.Models{
    public class Order{

        [BindNever]
        public int id {get; set;}
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 2 символов")]
        public string name {get; set;}
        [Display(Name = "Введите Фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии не менее 7 символов")]
        public string surrName {get; set;}
        [Display(Name = "Адрес")]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина адреса не менее 12 символов")]
        public string Address {get; set;}
        [Display(Name = "Номер телефона")]
        [StringLength(11)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера не менее 10 символов")]
        public string Phone {get; set;}
        [Display(Name = "Эл.почта")]
        [DataType(DataType.EmailAddress)]
        public string Email {get; set;}
        
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime {get; set;}

        public List<OrderDetail> orderDetails {get; set;}
    }
}