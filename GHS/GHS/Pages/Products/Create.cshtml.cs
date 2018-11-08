using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GHS.Models;

namespace GHS.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly GHS.Models.GHSContext _context;

        public CreateModel(GHS.Models.GHSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProductModel ProductModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductModel.Add(ProductModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}