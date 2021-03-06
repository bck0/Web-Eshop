using Faltynek.Eshop.Web.Models.Database;
using Faltynek.Eshop.Web.Models.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faltynek.Eshop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();
                
            using(var scope = host.Services.CreateScope())
            {
                if (scope.ServiceProvider.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<EshopDbContext>();
                    DatabaseInit dbInnit = new DatabaseInit();
                    dbInnit.Initialize(dbContext);

                    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
                    Task task = dbInnit.EnsureRoleCreated(roleManager);
                    task.Wait();
                    task.Dispose();

                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                    task = dbInnit.EnsureAdminCreated(userManager);
                    task.Wait();
                    task.Dispose();
                    task = dbInnit.EnsureManagerCreated(userManager);
                    task.Wait();
                    task.Dispose();

                }
            }    
                
                
                
                
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
