using C1.NorthWind.BlazingPizza.PlaceOrder.Entities;
using C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces;
using C3.NorthWind.BlazingPizza.PlaceOrder.Core.Controller;
using C3.NorthWind.BlazingPizza.PlaceOrder.Core.Interactor;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.DomainValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Core
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPlaceOrderCoreServices(
            this IServiceCollection services)
        {
            services
                .AddScoped<IPlaceOrderInputPort, PlaceOrderInteractor>()
                .AddScoped<IPlaceOrderController, PlaceOrderController>();

            return services;
        }
    }
}
