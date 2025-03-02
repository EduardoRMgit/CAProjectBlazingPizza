using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Entities
{
    internal class CustomPizza
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PizzaSpecialId { get; set; }
        public int Size { get; set; }
        public List<CustomPizzaTopping> Toppings { get; set; }
        public double TotalPrice { get; set; }

    }
}
