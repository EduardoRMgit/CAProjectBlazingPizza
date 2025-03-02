using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces
{
    public interface IPlaceOrderInputPort
    {
        // que hace esto? lo mismo que el controlador, 
        // Una tarea que devuelva un entero que reciba el orden
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto order);
    }
}
