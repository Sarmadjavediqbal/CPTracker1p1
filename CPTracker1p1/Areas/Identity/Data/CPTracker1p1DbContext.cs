﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPTracker1p1.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CPTracker1p1.Data
{
    public class CPTracker1p1DbContext : IdentityDbContext<ApplicationUser>
    {
        public CPTracker1p1DbContext(DbContextOptions<CPTracker1p1DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
