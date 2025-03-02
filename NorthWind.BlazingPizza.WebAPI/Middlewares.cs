using C1.NorthWind.BlazingPizza.GetToppings.Entities.Dtos;
using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using C2.NorthWind.BlazingPizza.GetToppings.BusinessObjects.Interfaces;
using C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces;

namespace NorthWind.BlazingPizza.WebAPI
{
    public static class Middlewares
    {
        // extender al constructor de endpoints
        public static IEndpointRouteBuilder UseBlazingPizzaEndPoints(
            this IEndpointRouteBuilder builder)
        {
            builder.MapGet(Endpoints.GetToppings,
                async(IGetToppingsController controller) => TypedResults.Ok(await controller.GetToppingsAsync()));

            builder.MapPost(C1.NorthWind.BlazingPizza.PlaceOrder.Entities.ValueObjects.EndPoints.PlaceOrder,
                // Tiene que recibir un place Order DTO y el controller
                async (
                    PlaceOrderOrderDto order,
                    IPlaceOrderController controller) => TypedResults.Ok(await controller.PlaceOrderAsync(order)));
            return builder;
        }
    }
}
