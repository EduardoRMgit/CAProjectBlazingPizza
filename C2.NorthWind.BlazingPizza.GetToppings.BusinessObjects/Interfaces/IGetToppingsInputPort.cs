using C1.NorthWind.BlazingPizza.GetToppings.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2.NorthWind.BlazingPizza.GetToppings.BusinessObjects.Interfaces
{
    public interface IGetToppingsInputPort
    {
        Task<IEnumerable<ToppingDto>> GetToppingsAsnyc();
    }
}
