using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CPMS.Data;
using CPMS.Models;

namespace CPMS.Pages.Reviewers
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
            return Page();
        }

        [BindProperty]
        public Reviewer Reviewer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reviewer.Add(Reviewer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
