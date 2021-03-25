using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using oneworldcert.Areas.Identity.Data;
using oneworldcert.Data;

[assembly: HostingStartup(typeof(oneworldcert.Areas.Identity.IdentityHostingStartup))]
namespace oneworldcert.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<oneworldcertContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("oneworldcertContextConnection")));

            
            });
        }
    }
}