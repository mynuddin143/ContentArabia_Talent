using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Content.API;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SE.CAF.CC.Persistance;
using SentinelModRepo.Common;

namespace content.talent.app
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            var builder = new HostBuilder()
          .ConfigureAppConfiguration((hostContext, configApp) =>
          {
              Console.WriteLine(Directory.GetCurrentDirectory());
              configApp.SetBasePath(Directory.GetCurrentDirectory());
              configApp.AddJsonFile("appsettings.json", optional: true, true);
              configApp.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, true);
          });
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services = AddDependencyInjection(services);
            //services = AddDependencyInjection(services);
            services.AddControllers();
            services.AddScoped<MsSqlRepository>(p => new MsSqlRepository(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CAPD 36 - User Creation ", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwaggerUI(c =>
            {
                // c.RoutePrefix = "SentinelSettings";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CAPD  - Talent APP - V1");
            });
            app.UseHttpsRedirection();


            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }

        protected virtual IServiceCollection AddDependencyInjection(IServiceCollection services)
        {
            services.AddDependency<CompositionRoot>(Configuration);
            return services;
        }
    }
}
