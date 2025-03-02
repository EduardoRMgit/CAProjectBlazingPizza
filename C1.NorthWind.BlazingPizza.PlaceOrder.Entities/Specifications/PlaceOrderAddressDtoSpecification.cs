using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Resources;
using NorthWind.DomainValidation.Implementations;
using NorthWind.DomainValidation.PropertySpecificationTreeExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Specifications
{
    internal class PlaceOrderAddressDtoSpecification: DomainSpecificationBase<PlaceOrderAddressDto>
    {
        public PlaceOrderAddressDtoSpecification()
        {
            Property(p => p.Name)
                .IsRequired(PlaceOrderMessagess.NameIsRequired)
                .HasMinLength(3, PlaceOrderMessagess.NameHasMinLength)
                .HasMaxLength(45, PlaceOrderMessagess.NameHasMaxLength);

            Property(p => p.AddressLine1)
                .IsRequired(PlaceOrderMessagess.AdressLine1IsRequired);

            Property(p => p.PostalCode)
                .HasMaxLength(10, PlaceOrderMessagess.PostalCodeHasMaxLength);




        }
    }
}
