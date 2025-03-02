using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Resources;
using NorthWind.DomainValidation.Implementations;
using NorthWind.DomainValidation.Interfaces;
using NorthWind.DomainValidation.PropertySpecificationTreeExtensions;
using NorthWind.DomainValidation.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Specifications
{
    internal class PlaceOrderOrderDtoSpecification: DomainSpecificationBase<PlaceOrderOrderDto>
    {

        IDomainSpecificationValidator<PlaceOrderAddressDto> Validator;

        public PlaceOrderOrderDtoSpecification(IDomainSpecificationValidator<PlaceOrderAddressDto> validator)
        {
            Validator = validator;
            Property(p => p.Pizzas)
                .NotEmpty("No pizzas en la lista");
        }

        protected override async Task<List<SpecificationError>> ValidateSpecificationAsync(PlaceOrderOrderDto entity)
        {
            var ValidationResult = await Validator.ValidateAsync(entity.DeliveryAddress);
            List<SpecificationError> ValidationResultError = ValidationResult.Errors.ToList();
            var ErrorsValidate = await base.ValidateSpecificationAsync(entity);
            ValidationResultError.AddRange(ErrorsValidate);

            return ValidationResultError;
        }


    }
}
