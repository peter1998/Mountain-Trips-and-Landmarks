using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mountain_Trips_and_Landmarks.Data;
using Mountain_Trips_and_Landmarks.Data.Adventure;
using Mountain_Trips_and_Landmarks.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks
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
            //DbContext configuration
            services.AddDbContext<AppDbContext>(options=> options.
            UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));

            //Services configuration
            services.AddScoped<IPeakService, PeakService>();
            services.AddScoped<ILandmarksService, LandmarksService>();
            services.AddScoped<IMountainsService, MountainsService>();
            services.AddScoped<ITracksService, TracksService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sc => SelectorAdventure.GetSelectorAdventure(sc));

            services.AddSession();

            services.AddControllersWithViews();
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
            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Tracks}/{action=Index}/{id?}");
            });

            //Seed database

           AppDbInitializer.Seed(app);
        }
    }
}
