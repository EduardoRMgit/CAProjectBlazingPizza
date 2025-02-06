using C1.NorthWind.BlazingPizza.GetToppings.Entities.Dtos;
using C2.NorthWind.BlazingPizza.GetToppings.BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.GetToppings.Core.Interactor
{
    internal class GetToppingsInteractor(IGetToppingsRepository repository) : IGetToppingsInputPort
    {
        public Task<IEnumerable<ToppingDto>> GetToppingsAsnyc() =>
            repository.GetToppingsSortedByNameAscendingAsync();
    }
}
