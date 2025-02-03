using NorthWind.BlazingPizza.GetSpecials.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces
{
    public interface IGetSpecialsControllers
    {
        Task<IEnumerable<PizzaSpecialDto>> GetSpecialAsyncs();
    }
}
