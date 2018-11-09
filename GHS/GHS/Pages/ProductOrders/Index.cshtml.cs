using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GHS.Models;

namespace GHS.Pages.ProductOrders
{
    public class IndexModel : PageModel
    {
        private readonly GHS.Models.GHSContext _context;

        public IndexModel(GHS.Models.GHSContext context)
        {
            _context = context;
        }

        public IList<ProductOrderModel> ProductOrderModel { get;set; }

        public async Task OnGetAsync()
        {
            ProductOrderModel = await _context.ProductOrderModel.ToListAsync();
        }
    }
}
