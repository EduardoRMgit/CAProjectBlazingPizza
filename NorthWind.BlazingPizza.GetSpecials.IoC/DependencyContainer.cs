using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Options;
using NorthWind.BlazingPizza.GetSpecials.Core;
using NorthWind.BlazingPizza.GetSpecials.Repositories.cs;
using NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider;
using NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGetSpecialsServices(
            this IServiceCollection services,
            Action<GetSpecialsOptions> configureGetSpecialsOptions,
            Action<GetSpecialsDBOptions> configureGetSpecialsDbOptions)
        {
            services.AddGetSpecialsCoreServices(configureGetSpecialsOptions)
                .AddGetSpecialsRepository()
                .AddSQLiteProvider(configureGetSpecialsDbOptions);

            return services;
        }
    }

}
