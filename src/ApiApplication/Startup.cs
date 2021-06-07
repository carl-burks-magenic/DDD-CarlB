using Common.SeedWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;

namespace ApiApplication
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
            IAssemblyProvider ap = new HardCodedAssemblyProvider();
            LocatorTypeInfoProvider locatorTypeInfoProvider = new LocatorTypeInfoProvider(ap);
            IEnumerable<TypeInfo> typeInfos = locatorTypeInfoProvider.GetTypeInfos();
            services.AddSingleton<LocatorTypeInfoProvider>(locatorTypeInfoProvider);
            services.AddHttpContextAccessor();
            services.AddScoped<ILocator, Locator>();
            services.AddMvc().ConfigureApplicationPartManager(p => p.FeatureProviders.Add(new GenericControllerFeatureProvider(typeInfos, new DynamicControllerFilter(new GenericControllerNameGenerator()))));
            services.AddMediatR(ap.Assemblies.ToArray());
            services.AddControllers();
            services.AddSwaggerGen(options=> {
                options.CustomSchemaIds(x => x.FullName);
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "DDD Example", Version = "v1" });
            });
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI((swagger) =>
            {
                swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "DDD Bicycle Store");
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
