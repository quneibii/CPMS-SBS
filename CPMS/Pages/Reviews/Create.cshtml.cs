using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CPMS.Data;
using CPMS.Models;

namespace CPMS.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly CPMS.Models.CPMSDbContext _context;

        public CreateModel(CPMS.Models.CPMSDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PaperId"] = new SelectList(_context.Paper, "PaperId", "PaperId");
        ViewData["ReviewerId"] = new SelectList(_context.Reviewer, "ReviewerId", "ReviewerId");
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
