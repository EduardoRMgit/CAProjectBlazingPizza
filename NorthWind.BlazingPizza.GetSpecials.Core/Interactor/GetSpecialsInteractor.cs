using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.Core.Interactor
{
    // implementaciones internas.
    internal class GetSpecialsInteractor(IGetSpecialsRepository repository,
                                         IGetSpecialsOutputPort outputPort) : IGetSpecialsInputPort
    {
        public async Task GetSpecialsAsync()
        {
            // lo único que tengo que hacer es obtenerlas del repositorio y mandarselas al output port
            var Result = await repository.GetSpecialsSortedByDescendingPriceAsync();
            await outputPort.HandleResultAsync(Result);
        }
    }
}
