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
    public class DetailsModel : PageModel
    {
        private readonly FatsShop_2.Data.ShopContext _context;

        public DetailsModel(FatsShop_2.Data.ShopContext context)
        {
            _context = context;
        }

        public Cart Cart { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cart = await _context.Carts
                .Include(c => c.Product).FirstOrDefaultAsync(m => m.CartID == id);

            if (Cart == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
