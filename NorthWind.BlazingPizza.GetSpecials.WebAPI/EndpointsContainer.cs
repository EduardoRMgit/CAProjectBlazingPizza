using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces;

namespace NorthWind.BlazingPizza.GetSpecials.WebAPI
{
    public static class EndpointsContainer
    {
        public static IEndpointRouteBuilder MapGetSpecialEndpoint(
            this IEndpointRouteBuilder app)
        {
            app.MapGet("/GetSpecials/", async (IGetSpecialsControllers controller) =>
            await controller.GetSpecialAsyncs());

            return app;
        }
    }
}
