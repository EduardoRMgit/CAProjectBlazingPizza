using C2.NorthWind.BlazingPizza.GetToppings.BusinessObjects.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.GetToppings.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGetToppingsRepository(
            this IServiceCollection services)
        {
            services.AddScoped<IGetToppingsRepository, GetToppingsRepository>();

            return services;
        }
    }
}
