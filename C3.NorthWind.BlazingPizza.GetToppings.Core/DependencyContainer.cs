using C2.NorthWind.BlazingPizza.GetToppings.BusinessObjects.Interfaces;
using C3.NorthWind.BlazingPizza.GetToppings.Core.Controller;
using C3.NorthWind.BlazingPizza.GetToppings.Core.Interactor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.GetToppings.Core
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGetToppingsCoreServices(this 
            IServiceCollection services)
        {
            // Este es el primerito, el inputPort que es implementado por el interactor
            services
                .AddScoped<IGetToppingsInputPort, GetToppingsInteractor>()
                .AddScoped<IGetToppingsController, GetToppingsController>();
            return services;
        }
    }
}
