using C1.NorthWind.BlazingPizza.GetToppings.Entities.Dtos;
using C2.NorthWind.BlazingPizza.GetToppings.BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.GetToppings.Core.Controller
{
    internal class GetToppingsController(IGetToppingsInputPort inputPort) : IGetToppingsController
    {
        // retorna lo que me devuelve el input port.
        public Task<IEnumerable<ToppingDto>> GetToppingsAsync() =>
            inputPort.GetToppingsAsnyc();

    }
}
