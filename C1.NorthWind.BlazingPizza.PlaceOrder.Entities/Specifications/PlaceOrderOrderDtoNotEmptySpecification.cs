using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using NorthWind.DomainValidation.Implementations;
using NorthWind.DomainValidation.PropertySpecificationTreeExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Specifications
{
    internal class PlaceOrderOrderDtoNotEmptySpecification: DomainSpecificationBase<PlaceOrderOrderDto>
    {
        public PlaceOrderOrderDtoNotEmptySpecification()
        {
            Property(p => p.Pizzas)
                .NotEmpty("Debe haber pizzas");
        }
    }
}
