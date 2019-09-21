using System;
using LinkShareApp.Areas.Identity.Data;
using LinkShareApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LinkShareApp.Areas.Identity.IdentityHostingStartup))]
namespace LinkShareApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityContextContext>(options =>
                    options.UseSqlServer(
                       context.Configuration.GetConnectionString("IdentityContextConnection")));
                    

                services.AddDefaultIdentity<LinkShareAppUser>()
                    .AddEntityFrameworkStores<IdentityContextContext>();
            });
        }
    }
}