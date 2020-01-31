using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Delivery.Presentation.DependencyResolver;
using Delivery.Repository;
using Delivery.Services.MappingProfiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Delivery.Presentation
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
            RepositoryResolvers.RepositoryResolve(services);
            services.AddAutoMapper(typeof(Startup));
            services.AddTransient<IMapper>((mapper) => new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Mapping>();
            })));
            services.AddCors();
            //services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //    {
    //        app.UseSwagger();

    //        app.UseSwaggerUI(c =>
    //        {
    //            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    //        });

    //        //if (env.IsDevelopment())
    //        //{
    //        //    app.UseDeveloperExceptionPage();
    //        //}

    //        //app.UseCors(
    //        //    options => options.WithOrigins("*").AllowAnyMethod()
    //        //);
    //        //app.UseRouting();

    //        //app.UseAuthorization();
    //        //app.UseStaticFiles();
    //        //app.UseEndpoints(endpoints =>
    //        //{
    //        //    endpoints.MapControllers();
    //        //});
    //        //ApplicationContext context = new ApplicationContext();
    //        //bool allowDropRecreatedataBase = true;
    //        //if (allowDropRecreatedataBase)
    //        //    context.Database.EnsureDeleted();
    //        //context.Database.EnsureCreated();
    //    }
    }
}
