using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.Repositories.cs;

public static class DependencyContainer
{
    public static IServiceCollection AddGetSpecialsRepository(
        this IServiceCollection services)
    {
        services.AddScoped<IGetSpecialsRepository, GetSpecialsRepository>();

        return services;
    }
}
