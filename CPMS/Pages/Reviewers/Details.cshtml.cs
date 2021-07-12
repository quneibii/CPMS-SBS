using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CPMS.Data;
using CPMS.Models;

namespace CPMS.Pages.Reviewers
{
    public class DetailsModel : PageModel
    {
        private readonly CPMS.Models.CPMSDbContext _context;

        public DetailsModel(CPMS.Models.CPMSDbContext context)
        {
            _context = context;
        }

        public Reviewer Reviewer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reviewer = await _context.Reviewer.FirstOrDefaultAsync(m => m.ReviewerId == id);

            if (Reviewer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
