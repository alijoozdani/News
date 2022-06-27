using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using News.DataLayer.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using News.Core.Services.Interfaces;
using News.Convertor;
using News.Core.Services;

namespace News.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            #region DataBase Context

            services.AddDbContext<NewsContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("NewsConnection"));
            }
            );

            #endregion

            #region Authentication

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = "/Login";
                    option.LogoutPath = "/Logout";
                    option.ExpireTimeSpan = TimeSpan.FromDays(10);
                });

            #endregion

            #region IOC
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IViewRenderService, RenderViewToString>();
            services.AddTransient<IGroupService, GroupService>();
            services.AddTransient<IPermissionService, PermissionService>();
            services.AddTransient<IBlogService, BlogService>();
            services.AddTransient<IBlogCommentService, BlogCommentService>();
            services.AddTransient<IAboutUsService, AboutUsService>();
            services.AddTransient<IContactUsService, ContactUsSerivece>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region HandlerError
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/home/HandlerError");

            }
            app.UseStatusCodePagesWithReExecute("/Home/HandleError/{0}");
            #endregion

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
