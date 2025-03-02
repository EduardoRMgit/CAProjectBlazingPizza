using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos
{
    public class PlaceOrderOrderDto(
        IEnumerable<PlaceOrderPizzaDto> pizzas,
        PlaceOrderAddressDto deliveryAddress)
    {
        public IEnumerable<PlaceOrderPizzaDto> Pizzas => pizzas;
        public PlaceOrderAddressDto DeliveryAddress => deliveryAddress;
    }
}
