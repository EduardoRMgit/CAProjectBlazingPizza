using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public List<CustomPizza> Pizzas { get; set; }
        public Address DeliveryAddress { get; set; }
    }
}
