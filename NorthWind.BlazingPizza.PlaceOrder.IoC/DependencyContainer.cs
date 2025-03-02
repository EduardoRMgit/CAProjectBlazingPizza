using C1.NorthWind.BlazingPizza.PlaceOrder.Entities;
using C3.NorthWind.BlazingPizza.PlaceOrder.Core;
using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.DomainValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPlaceOrderServices(
            this IServiceCollection services)
        {
            services
                .AddPlaceOrderCoreServices()
                .AddPlaceOrderRepository()
                .AddDomainSpecificationsValidator()
                .AddPlaceOrderSpecifications();


            return services;
        }
    }
}
