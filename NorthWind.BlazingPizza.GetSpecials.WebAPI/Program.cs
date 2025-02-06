using NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider.Options;
using NorthWind.BlazingPizza.GetSpecials.IoC;
using NorthWind.BlazingPizza.GetSpecials.WebAPI;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Options;
using NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider;

var builder = WebApplication.CreateBuilder(args);

builder.AddGetSpecialsServices();

// quieren que se consuma por un criente blazor o js.
// Configurar CORS (igual que en NorthWind.Sales)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(config =>
    {
        config.AllowAnyMethod();
        config.AllowAnyOrigin();
        config.AllowAnyHeader();
    });
});
var app = builder.Build();

// Habilitar CORS

//// Mapear Endpoints usando el Contenedor de Endpoints
//app.MapGetSpecialEndpoint();

// middleware.
app.UseHttpsRedirection();
app.UseGetSpecialsEndpoint();
app.InitializeGetSpecialDB();
app.UseCors();
app.Run();
