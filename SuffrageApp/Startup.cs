using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Core.Services;
using Core.Interfaces.Services;
using Infrastructure.Data;
using Core.Interfaces.IRepositories;
using Core.Mapping;
using Infrastructure.Data.Repositories;

namespace SuffrageApp
{
    public class Startup
    {
        public Startup(IConfiguration config) => this.Configuration = config;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc()
                .AddRazorRuntimeCompilation()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            services.AddAutoMapper(typeof(PollProfile));

            services.AddDbContext<AppDbContext>(o =>
                    {
                        o.UseSqlServer(Configuration.GetConnectionString("SuffrageAppDb"));
                    });

            services
                .AddTransient<IPollRepository, PollRepository>()
                .AddTransient<IPollService, PollService>()
                .AddTransient<IAnswerService, AnswerService>()
                .AddTransient<IAnswerRepository, AnswerRepository>()
                .AddTransient<IOptionRepository, OptionRepository>();
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
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
