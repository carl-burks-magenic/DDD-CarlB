using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OrderManagementService
{
        public static class OrderManagementServiceCollectionExtensions
        {
            public static IServiceCollection AddConfig(
                 this IServiceCollection services, IConfiguration config)
            {
                //TODO:
                //Add options
                //Register 
                //services.Configure<PositionOptions>(
                //    config.GetSection(PositionOptions.Position));
                //services.Configure<ColorOptions>(
                //    config.GetSection(ColorOptions.Color));

                //services.Add<>()
                return services;
            }
        }
}
