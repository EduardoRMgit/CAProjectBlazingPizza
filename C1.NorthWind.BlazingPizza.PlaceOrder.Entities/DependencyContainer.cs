using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Specifications;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.DomainValidation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.NorthWind.BlazingPizza.PlaceOrder.Entities
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPlaceOrderSpecifications(
            this IServiceCollection services)
        {
            //services.AddScoped<
            //    IDomainSpecification<PlaceOrderOrderDto>, PlaceOrderOrderDtoSpecification>();
            services.AddScoped<IDomainSpecification<PlaceOrderAddressDto>, PlaceOrderAddressDtoSpecification>();
            services.AddScoped<IDomainSpecification<PlaceOrderOrderDto>, PlaceOrderOrderDtoSpecification>();
            //services.AddScoped<IDomainSpecification<PlaceOrderOrderDto>, PlaceOrderOrderDtoNotEmptySpecification>();

            return services;
        }
    }
}
