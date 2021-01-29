using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FatsShop_2.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int ProductID { get; set; }
        [Display(Name = "Price")]
        public decimal? CartPrice { get; set; }
        [Display(Name = "Quantity")]
        public int? CartQuantity { get; set; }
        [Display(Name = "Product")]
        public string CartProductName { get; set; }
        [Display(Name = "Material")]
        public string CartProductMaterial { get; set; }

        public Product Product { get; set; }
    }
}
