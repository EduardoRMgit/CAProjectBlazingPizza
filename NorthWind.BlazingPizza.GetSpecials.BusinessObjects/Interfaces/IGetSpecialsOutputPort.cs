using NorthWind.BlazingPizza.GetSpecials.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces
{
    public interface IGetSpecialsOutputPort
    {
        IEnumerable<PizzaSpecialDto> PizzaSpecials { get; }

        // el controlador me va a dar un pizzaSpecials
        // el interactor me va a devolver los nombres de los archivos de imagen, el output por se va a dar el url de donde se encuentran las imagenes.
        Task HandleResultAsync(IEnumerable<PizzaSpecialDto> pizzaSpecials);
    }
}
