using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonthlyBillsWebAPI.Models2;
//using MonthlyBillsWebAPI.Models2.DataManager;
//using MonthlyBillsWebAPI.Models2.DTO;
using MonthlyBillsWebAPI.Models2.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MonthlyBillsWebAPI
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
            services.AddControllers();
            services.AddDbContext<MonthlyBillsWebAppTR_dbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:AzureDB"]));
            //services.AddScoped<IDataRepository<MonthlyBills, MonthlyBillsDto>, MonthlyBillsDataManager>();
            //services.AddScoped<IDataRepository<WeeklyBills, WeeklyBillsDto>, WeeklyBillsDataManager>();
            ////services.AddScoped<IDataRepository<Publisher, PublisherDto>, PublisherDataManager>();

            //services.AddMvc()
            //    .AddJsonOptions(
            //        options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //    ).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            //services.AddSingleton<IConfiguration>(Configuration);
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
