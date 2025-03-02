using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces
{
    public interface IPlaceOrderRepository
    {
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto order);
    }
}
