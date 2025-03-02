using C3.NorthWind.BlazingPizza.PlaceOrder.IoC;
using C4.NorthWind.BlazingPizza.DataContexts;
using C4.NorthWind.BlazingPizza.DataContexts.Options;
using C4.NorthWind.BlazingPizza.GetToppings.IoC;

namespace NorthWind.BlazingPizza.WebAPI
{
    public static class Services
    {
        public static WebApplicationBuilder AddBlazingPizzaServices(
            this WebApplicationBuilder builder)
        {

            // Agrega servicios de Topping
            builder.Services.AddGetToppingsServices();

            // se agregan servicios de PlaceOrder

            // Agrega contexto de base de datos
            builder.Services.AddBlazingPizzaDataContexts(
                configureBlazingPizzaDBOptions =>
                    builder.Configuration.GetRequiredSection(BlazingPizzaDBOptions.SectionKey).Bind(configureBlazingPizzaDBOptions));

            builder.Services.AddPlaceOrderServices();


            return builder;
        }
    }
}
