using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesProduct.Models
{
    public class Product
    {
        public int ID { get; set; }

        //site://khalidabuhakmeh.com/simplify-displayname-calls-in-razor
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Display(Name = "Quantidade")]
        public int Amount { get; set; }
    }
}
