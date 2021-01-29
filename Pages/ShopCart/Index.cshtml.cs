using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FatsShop_2.Data;
using FatsShop_2.Models;

namespace FatsShop_2.Pages.ShopCart
{
    public class IndexModel : PageModel
    {
        private readonly FatsShop_2.Data.ShopContext _context;

        public IndexModel(FatsShop_2.Data.ShopContext context)
        {
            _context = context;
        }

        public IList<Cart> Cart { get;set; }

        public async Task OnGetAsync()
        {
            Cart = await _context.Carts
                .Include(c => c.Product).ToListAsync();
        }
    }
}
