using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CPMS.Data;
using CPMS.Models;

namespace CPMS.Pages.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly CPMS.Models.CPMSDbContext _context;

        public DetailsModel(CPMS.Models.CPMSDbContext context)
        {
            _context = context;
        }

        public Paper Paper { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Paper = await _context.Paper
                .Include(p => p.Author).FirstOrDefaultAsync(m => m.PaperId == id);

            if (Paper == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
