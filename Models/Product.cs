using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FatsShop_2.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Product")]
        public string ProductName { get; set; }
        [Display(Name = "Size")]
        public string ProductSize { get; set; }
        [Display(Name = "Price")]
        public decimal ProductPrice { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}
