using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces;
using NorthWind.DomainValidation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Core.Interactor
{
    internal class PlaceOrderInteractor(
        IPlaceOrderRepository repository,
        IDomainSpecificationValidator<PlaceOrderOrderDto> validator) : IPlaceOrderInputPort
    {
        public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order)
        {

            var ValidationResult = await validator.ValidateAsync(order);
            if (!ValidationResult.IsValid)
            {
                string Errors = string.Join(" ", ValidationResult.Errors
                    .Select(e => $"{e.PropertyName}: {e.ErrorMessage}"));
                throw new Exception(Errors);
            }

            return await repository.PlaceOrderAsync(order);

        }

    }
}
