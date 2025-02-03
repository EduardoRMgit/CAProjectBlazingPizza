using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Options;
using NorthWind.BlazingPizza.GetSpecials.Core.Controller;
using NorthWind.BlazingPizza.GetSpecials.Core.Interactor;
using NorthWind.BlazingPizza.GetSpecials.Core.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.Core
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGetSpecialsCoreServices(this IServiceCollection services, 
            Action<GetSpecialsOptions> configureGetSpecialsOptions)
        {
            services.AddScoped<IGetSpecialsInputPort, GetSpecialsInteractor>();
            services.AddScoped<IGetSpecialsOutputPort, GetSpecialsPresenter>();


            // definimos la clase, lo inyectamos donde lo necesitamos y luego lo inyectamos en el contenedor de inyección de dependencias
            // solo falta meterle su valor
            services.Configure(configureGetSpecialsOptions);
            services.AddScoped<IGetSpecialsControllers, GetSpecialController>();


            // necesitamos obtener el get special options por inyección de dependencias
            return services;
        }
    }
}
