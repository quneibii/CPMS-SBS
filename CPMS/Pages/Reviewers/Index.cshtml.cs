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
    public class IndexModel : PageModel
    {
        private readonly CPMS.Models.CPMSDbContext _context;

        public IndexModel(CPMS.Models.CPMSDbContext context)
        {
            _context = context;
        }

        public IList<Reviewer> Reviewer { get;set; }

        public async Task OnGetAsync()
        {
            Reviewer = await _context.Reviewer.ToListAsync();
        }
    }
}
