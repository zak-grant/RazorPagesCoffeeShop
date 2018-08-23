using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoffeeShop.Models;

namespace CoffeeShop.PagesCoffee
{
    public class CreateModel : PageModel
    {
        private readonly CoffeeShop.Models.CoffeeContext _context;

        public CreateModel(CoffeeShop.Models.CoffeeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Coffee Coffee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Coffee.Add(Coffee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}