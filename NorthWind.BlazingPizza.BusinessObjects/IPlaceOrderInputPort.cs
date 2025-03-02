using NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.BusinessObjects
{
    public interface IPlaceOrderInputPort
    {
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto o)
    }
}
