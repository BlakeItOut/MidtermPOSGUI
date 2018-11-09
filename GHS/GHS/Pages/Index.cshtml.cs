using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GHS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GHS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GHS.Models.GHSContext _context;

        public IndexModel(GHS.Models.GHSContext context)
        {
            _context = context;
        }

        public IList<ProductModel> ProductModel { get; set; }

        public async Task OnGetAsync()
        {
            ProductModel = await _context.ProductModel.ToListAsync();
        }
    }
}
