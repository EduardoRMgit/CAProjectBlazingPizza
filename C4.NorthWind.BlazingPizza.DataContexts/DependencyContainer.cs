using C3.NorthWind.BlazingPizza.GetToppings.Repositories.DataContexts;
using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.DataContexts;
using C4.NorthWind.BlazingPizza.DataContexts.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4.NorthWind.BlazingPizza.DataContexts
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBlazingPizzaDataContexts(
            this IServiceCollection services,
            Action<BlazingPizzaDBOptions> configureBlazingPizzaDBOptions)
        {
            BlazingPizzaDBOptions Options = new();
            configureBlazingPizzaDBOptions(Options);

            // se agrega un delegado para conectarnos a la db.
            Action<DbContextOptionsBuilder> OptionsAction = options => 
                options.UseSqlServer(Options.ConnectionString);

            services.AddDbContext<GetToppingsContext>(OptionsAction);
            services.AddDbContext<PlaceOrderContext>(OptionsAction);


            return services;
        }
    }
}
