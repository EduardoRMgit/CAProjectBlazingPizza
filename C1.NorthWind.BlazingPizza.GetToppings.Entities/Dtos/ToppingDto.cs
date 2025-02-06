using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.NorthWind.BlazingPizza.GetToppings.Entities.Dtos
{
    public class ToppingDto(int id, string name, double price)
    {
        public int Id => id;
        public string Name => name;
        public double Price => price;

        public string GetFormattedPrice() =>
            price.ToString("N2");

    }
}
