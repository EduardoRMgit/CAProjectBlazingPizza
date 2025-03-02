using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos
{
    public class PlaceOrderPizzaDto(int pizzaSpecialId, 
        int size, IEnumerable<int> toppingsIds, double totalPrice)
    {
        public int PizzaSpecialId => pizzaSpecialId;
        public int Size => size;
        public IEnumerable<int> ToppingsIds => toppingsIds;
        public double TotalPrice => totalPrice;
    }
}
