using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FatsShop_2.Data;
using FatsShop_2.Models;

namespace FatsShop_2.Pages.ShopCart
{
    public class CreateModel : PageModel
    {
        private readonly FatsShop_2.Data.ShopContext _context;

        public CreateModel(FatsShop_2.Data.ShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

        ViewData["ProductID"] = new SelectList(_context.Products, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Cart Cart { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
                  


            _context.Carts.Add(Cart);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
