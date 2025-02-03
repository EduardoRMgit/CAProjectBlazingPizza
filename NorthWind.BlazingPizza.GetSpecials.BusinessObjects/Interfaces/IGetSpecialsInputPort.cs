using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces
{
    public interface IGetSpecialsInputPort
    {
        // no devuelvo nada porque lo voy a devolver con el output port
        Task GetSpecialsAsync();
    }
}
