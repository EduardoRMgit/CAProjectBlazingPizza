using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces;

namespace NorthWind.BlazingPizza.GetSpecials.WebAPI
{
    public static class Middlewares
    {
        public static IEndpointRouteBuilder UseGetSpecialsEndpoint(
            this IEndpointRouteBuilder builder)
        {
            builder.MapGet("/getspecials/", async (IGetSpecialsControllers controller) =>
                TypedResults.Ok(await controller.GetSpecialAsyncs()));
            return builder;
        }
    }
}
