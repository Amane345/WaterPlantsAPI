using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterPlantsAPI.Data;
using WaterPlantsAPI.Repository;

namespace WaterPlantsAPI
{
    public class Startup
    {
        readonly string CORSOpenPolicy = "OpenCORSPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            string PlantsconnectionString =
                   Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<PlantDbContext>(option =>
                 option.UseSqlServer(PlantsconnectionString));
            services.AddScoped<IPlantRepository, PlantRepository>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WaterPlantsAPI", Version = "v1" });
            });
            services.AddCors(options =>
            {
                options.AddPolicy(name: CORSOpenPolicy,
                                  builder =>
                                  {
                                      builder.WithOrigins("*").AllowAnyHeader()
                                                  .AllowAnyMethod();
                                  });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WaterPlantsAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(CORSOpenPolicy);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
