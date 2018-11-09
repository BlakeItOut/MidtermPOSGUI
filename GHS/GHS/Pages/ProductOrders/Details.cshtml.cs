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
    public class DetailsModel : PageModel
    {
        private readonly GHS.Models.GHSContext _context;

        public DetailsModel(GHS.Models.GHSContext context)
        {
            _context = context;
        }

        public ProductOrderModel ProductOrderModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductOrderModel = await _context.ProductOrderModel.FirstOrDefaultAsync(m => m.OrderProductId == id);

            if (ProductOrderModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
