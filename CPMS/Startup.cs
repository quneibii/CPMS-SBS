using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPMS.Data;
using CPMS.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CPMSDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("CPMS")));

            // cookie policy and authentication
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.ConsentCookie.IsEssential = true;  //login cookie is marked essential
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookieOptions => {
                cookieOptions.Cookie.Name = "UserLoginCookie";
                cookieOptions.LoginPath = "/";
            });


            // require authorization for table use
            services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizeFolder("/Authors");
                options.Conventions.AuthorizeFolder("/Papers");
                options.Conventions.AuthorizeFolder("/Reviews");
                options.Conventions.AuthorizeFolder("/Reviewers");
                options.Conventions.AuthorizePage("/Reports");
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
