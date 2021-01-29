using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FatsShop_2.Data;
using FatsShop_2.Models;

namespace FatsShop_2.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();
            if (context.Products.Any())
            {
                return;
            }
            var products = new Product[]
            {
                new Product{ProductName="Large Pot",ProductSize="Large",ProductPrice=15.00M},
                new Product{ProductName="Medium Pot",ProductSize="Medium",ProductPrice=10.00M},
                new Product{ProductName="Small Pot",ProductSize="Small",ProductPrice=5.00M},
            };
            context.Products.AddRange(products);
            context.SaveChanges();

            var carts = new Cart[]
            {
                new Cart{ProductID=1,CartProductName="Large Pot",CartQuantity=1,CartPrice=15.00M,CartProductMaterial="Metal"},
                new Cart{ProductID=2,CartProductName="Medium Pot",CartQuantity=1,CartPrice=10.00M,CartProductMaterial="Ceramic"},
            };
            context.Carts.AddRange(carts);
            context.SaveChanges();
         }
    }
}
