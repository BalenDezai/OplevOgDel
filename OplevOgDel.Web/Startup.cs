using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OplevOgDel.Web.Models.Configuration;
using OplevOgDel.Web.Services;

namespace OplevOgDel.Web
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
            services.AddControllersWithViews();
            
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.Cookie.SameSite = SameSiteMode.Lax;
                options.Cookie.Name = "OplevOgDel";
                options.LoginPath = "/User/Login";
                options.LogoutPath = "/User/Logout";
                options.AccessDeniedPath = "/";
            });

            services.Configure<CookiePolicyOptions>(options => 
            {
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
                options.HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.None;
                options.Secure = CookieSecurePolicy.Always;
            });

            services.Configure<ApiUrls>(Configuration.GetSection(ApiUrls.ApiUrl));
            services.AddHttpContextAccessor();
            services.AddHttpClient<OplevOgDelService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
