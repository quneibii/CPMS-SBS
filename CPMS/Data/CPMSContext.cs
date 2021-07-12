using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CPMS.Models;

namespace CPMS.Data
{
    public class CPMSContext : DbContext
    {
        public CPMSContext (DbContextOptions<CPMSContext> options)
            : base(options)
        {
        }

        public DbSet<CPMS.Models.Author> Author { get; set; }

        public DbSet<CPMS.Models.Paper> Paper { get; set; }

        public DbSet<CPMS.Models.Reviewer> Reviewer { get; set; }

        public DbSet<CPMS.Models.Review> Review { get; set; }
    }
}
