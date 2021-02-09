using Demo.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.DynamicInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace Demo.DynamicInjections
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
            #region DbContext Alias
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<DbContext, AppDbContext>();

            #endregion
            //services.AddServicesOfType<IScopedService>();
            //services.AddServicesAttributeOfType<ScopedServiceAttribute>();

            //Assemblies start with "Demo.DynamicInjections", "Demo.Repository", "Demo.Manager" will only be scanned.
            string[] assembliesToBeScanned = new string[] { "Demo.DynamicInjections", "Demo.Manager", "Demo.Repository" };
            services.AddServicesOfType<IScopedService>(assembliesToBeScanned);
            services.AddServicesAttributeOfType<ScopedServiceAttribute>(assembliesToBeScanned);
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Student}/{action=Index}/{id?}");
            });
        }
    }
}
