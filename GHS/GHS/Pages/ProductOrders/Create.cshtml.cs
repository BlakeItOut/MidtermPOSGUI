using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GHS.Models;
using Microsoft.EntityFrameworkCore;

namespace GHS.Pages.ProductOrders
{
    public class CreateModel : PageModel
    {
        private readonly GHS.Models.GHSContext _context;

        public CreateModel(GHS.Models.GHSContext context)
        {
            _context = context;
        }

        public ProductModel ProductModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductModel = await _context.ProductModel.FirstOrDefaultAsync(m => m.ProductId == id);

            if (ProductModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        [BindProperty]
        public ProductOrderModel ProductOrderModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductOrderModel.Add(ProductOrderModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}