using C1.NorthWind.BlazingPizza.GetToppings.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2.NorthWind.BlazingPizza.GetToppings.BusinessObjects.Interfaces
{
    public  interface IGetToppingsController
    {
        // solo dame los toppings.
        Task<IEnumerable<ToppingDto>> GetToppingsAsync();
    }
}
