using C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Repositories
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddPlaceOrderRepository(
            this IServiceCollection services)
        {

            services.AddScoped<IPlaceOrderRepository, PlaceOrderRepository>();

            return services;
        }
    }
}
