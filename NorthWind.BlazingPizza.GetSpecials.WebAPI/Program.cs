using NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider.Options;
using NorthWind.BlazingPizza.GetSpecials.IoC;
using NorthWind.BlazingPizza.GetSpecials.WebAPI;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Options;
using NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGetSpecialsServices(
    options => builder.Configuration.GetSection(GetSpecialsOptions.SectionKey).Bind(options),
    dbOptions => builder.Configuration.GetSection(GetSpecialsDBOptions.SectionKey).Bind(dbOptions)
);

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

app.InitializeGetSpecialDB();

// Habilitar CORS
app.UseCors();

// Mapear Endpoints usando el Contenedor de Endpoints
app.MapGetSpecialEndpoint();

app.UseHttpsRedirection();
app.Run();
