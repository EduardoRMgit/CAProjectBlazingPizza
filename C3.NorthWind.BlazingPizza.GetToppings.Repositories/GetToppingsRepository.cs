using C1.NorthWind.BlazingPizza.GetToppings.Entities.Dtos;
using C2.NorthWind.BlazingPizza.GetToppings.BusinessObjects.Interfaces;
using C3.NorthWind.BlazingPizza.GetToppings.Repositories.DataContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.GetToppings.Repositories
{
    // NECESITA DEL CONTEXTO DE LA BASE DE DATOS
    internal class GetToppingsRepository(
        GetToppingsContext context) : IGetToppingsRepository
    {
        public async Task<IEnumerable<ToppingDto>> GetToppingsSortedByNameAscendingAsync() =>
            // al contexto, del contexto los topings
            await context.Toppings
            .OrderBy(t => t.Name)
            .Select(t => new ToppingDto(
                t.Id, t.Name, t.Price))
            .ToListAsync();
    }
}
