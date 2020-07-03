using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.Helpers;
using Frontend_Lahiyye_AspNetCore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frontend_Lahiyye_AspNetCore
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>(IdentityOptions =>
             {
                 IdentityOptions.Password.RequireDigit = true;
                 IdentityOptions.Password.RequireLowercase = true;
                 IdentityOptions.Password.RequireUppercase = true;
                 IdentityOptions.Password.RequireNonAlphanumeric = true;
                 IdentityOptions.Password.RequiredLength = 5;
                 IdentityOptions.User.RequireUniqueEmail = true;
                 IdentityOptions.Lockout.MaxFailedAccessAttempts = 3;
                 IdentityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                 IdentityOptions.Lockout.AllowedForNewUsers = true;

             }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders().AddErrorDescriber<CustomIdentityError>();
            services.AddMvc();
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"])
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes => {
                routes.MapRoute(
                  name: "areas",
                   template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                       );
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{Id?}"
                    );
            }

            );
        }
    }
}
