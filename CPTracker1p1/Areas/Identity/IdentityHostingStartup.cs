using System;
using CPTracker1p1.Areas.Identity.Data;
using CPTracker1p1.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CPTracker1p1.Areas.Identity.IdentityHostingStartup))]
namespace CPTracker1p1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CPTracker1p1DbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CPTracker1p1DbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => 
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                })
                    .AddEntityFrameworkStores<CPTracker1p1DbContext>();
            });
        }
    }
}