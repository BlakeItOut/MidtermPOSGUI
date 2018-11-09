using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GHS.Models;

namespace GHS.Pages.ProductOrders
{
    public class EditModel : PageModel
    {
        private readonly GHS.Models.GHSContext _context;

        public EditModel(GHS.Models.GHSContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProductOrderModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductOrderModelExists(ProductOrderModel.OrderProductId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductOrderModelExists(int id)
        {
            return _context.ProductOrderModel.Any(e => e.OrderProductId == id);
        }
    }
}
