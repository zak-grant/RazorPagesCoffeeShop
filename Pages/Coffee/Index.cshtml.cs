using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoffeeShop.Models;

namespace CoffeeShop.PagesCoffee
{
    public class IndexModel : PageModel
    {
        private readonly CoffeeShop.Models.CoffeeContext _context;

        public IndexModel(CoffeeShop.Models.CoffeeContext context)
        {
            _context = context;
        }

        public IList<Coffee> Coffee { get;set; }

        public async Task OnGetAsync()
        {
            Coffee = await _context.Coffee.ToListAsync();
        }
    }
}
