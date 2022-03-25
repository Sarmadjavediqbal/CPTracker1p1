using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CPTracker1p1.Models;

namespace CPTracker1p1.Data
{
    public class CPTracker1p1NewDbContext : DbContext
    {
        public CPTracker1p1NewDbContext (DbContextOptions<CPTracker1p1NewDbContext> options)
            : base(options)
        {
        }

        public DbSet<CPTracker1p1.Models.AddressBook> AddressBook { get; set; }
    }
}
