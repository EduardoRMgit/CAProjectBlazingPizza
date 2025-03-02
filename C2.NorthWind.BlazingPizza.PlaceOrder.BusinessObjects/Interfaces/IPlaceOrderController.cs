using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces
{
    public interface IPlaceOrderController
    {
        // REQUERIMOS UNA TAREA QUE DEVUELVA UN ENTERO
        // para retornarlo necesitaremos los datos de la ordenen donde tengamos los datos de la orden.
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto order);
    }
}
