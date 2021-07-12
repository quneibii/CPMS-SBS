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
    public class IndexModel : PageModel
    {
        private readonly CPMS.Models.CPMSDbContext _context;

        public IndexModel(CPMS.Models.CPMSDbContext context)
        {
            _context = context;
        }

        public IList<Paper> Paper { get;set; }

        public async Task OnGetAsync()
        {
            Paper = await _context.Paper
                .Include(p => p.Author).ToListAsync();
        }
    }
}
