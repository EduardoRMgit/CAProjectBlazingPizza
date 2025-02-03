using Microsoft.EntityFrameworkCore;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces;
using NorthWind.BlazingPizza.GetSpecials.Entities.Dtos;
using NorthWind.BlazingPizza.GetSpecials.Repositories.cs.DataContexts;
using NorthWind.BlazingPizza.GetSpecials.Repositories.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.Repositories.cs;

internal class GetSpecialsRepository(GetSpecialsContext context) :
    IGetSpecialsRepository
{
    public async Task<IEnumerable<PizzaSpecialDto>> GetSpecialsSortedByDescendingPriceAsync() =>
        await context.PizzaSpecials.OrderByDescending(s => s.BasePrice).Select(
            s => new PizzaSpecialDto(
                s.Id, s.Name, s.BasePrice, s.Description, s.ImageUrl)).ToListAsync();
}
