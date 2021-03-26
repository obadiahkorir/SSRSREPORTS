using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.IO;
using Bold.Licensing;
using System.Text;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using BoldReports.Web;
using SampleDemoMVC.Models;

namespace SampleDemoMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment _hostingEnvironment)

        {

            string License = File.ReadAllText(System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, "BoldLicense.txt"), Encoding.UTF8);
            BoldLicenseProvider.RegisterLicense(License);

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime.Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            //services.AddDbContext<SampleDemoMVCContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("SampleDemoMVCContext")));
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddCors(o => o.AddPolicy("AllowAllOrigins", builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
            }));
            //services.AddLogging(loggingBuilder =>
            //{
            //    loggingBuilder.AddConfiguration(Configuration.GetSection("Logging"));
            //    loggingBuilder.AddConsole();
            //    loggingBuilder.AddDebug();
            //});
        }

        //This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            //Register Bold license Online
           // Bold.Licensing.BoldLicenseProvider.RegisterLicense("A7p+04LVUBgQr+7vr7+pP0m2DtZz/jd9YlbkEf/xp9s=");
            // Register Bold licenseKey Offline
            //string licenseKey = "A7p+04LVUBgQr+7vr7+pP0m2DtZz/jd9YlbkEf/xp9s=";
           //File.ReadAllText(@"BoldLicense.txt"); // Replace it with actual license key file path
          //  BoldLicenseProvider.RegisterLicense(licenseKey, isOfflineValidation: true);
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            // loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

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
