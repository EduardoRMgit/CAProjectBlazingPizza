using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Core.Controller
{
    internal class PlaceOrderController(IPlaceOrderInputPort inputPort) : IPlaceOrderController
    {
        public  Task<int> PlaceOrderAsync(PlaceOrderOrderDto order) =>
            inputPort.PlaceOrderAsync(order);

    }
}
