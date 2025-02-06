using C3.NorthWind.BlazingPizza.GetToppings.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4.NorthWind.BlazingPizza.GetToppings.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGetToppingsServices(
            this IServiceCollection services)
        {
            services.AddGetToppingsServices()
                .AddGetToppingsRepository();
            return services;
        }
    }
}
