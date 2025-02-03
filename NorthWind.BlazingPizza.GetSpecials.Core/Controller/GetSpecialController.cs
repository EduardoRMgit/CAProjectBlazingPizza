using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces;
using NorthWind.BlazingPizza.GetSpecials.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.Core.Controller
{
    internal class GetSpecialController(
        IGetSpecialsInputPort inputPort,
        IGetSpecialsOutputPort outputPort) : IGetSpecialsControllers
    {
        public async Task<IEnumerable<PizzaSpecialDto>> GetSpecialAsyncs()
        {
            await inputPort.GetSpecialsAsync();
            return outputPort.PizzaSpecials;
        }
    }
}
