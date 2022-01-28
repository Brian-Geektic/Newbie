using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Newbie.Repositories.Data;
using Newbie.Services.Interfaces;
using Newbie.Services.Services;
using Newbie.Repositories.Interfaces;
using Newbie.Repositories.Repositories;
using AutoMapper;

namespace Newbie.Web
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
            
            //加入DB connection string
            services.AddDbContext<NewbiedbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("connectNewbie"), ServerVersion.Parse("10.6.5-mariadb"));
            });

            #region 加入各介面的interfaces
            services.AddScoped<IMemberpublicRepository, MembersPublicRepositories>();
            services.AddScoped<IMembersPublicService, MembersPublicService>();

            #endregion

            #region 加入AutoMapper的profile的方法
            //逐個加入automapper的profile, 並加入服務
            var mapperconfig = new MapperConfiguration(m => m.AddProfile<MyMappingProfile>());
            IMapper mapper = mapperconfig.CreateMapper();
            services.AddSingleton(mapper);

            //把所有的profile丟進addautomapper中,並反射出來
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //尋找startup所在的assembly並反射出相同位置的所有profile
            //services.AddAutoMapper(typeof(Startup));
            #endregion
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
                    pattern: "{controller=Member}/{action=Index}/{id?}");
            });
        }
    }
}
