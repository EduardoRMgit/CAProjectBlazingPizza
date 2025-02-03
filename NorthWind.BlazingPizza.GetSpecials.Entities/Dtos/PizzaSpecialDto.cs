using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.Entities.Dtos
{
    public class PizzaSpecialDto(int id, string name,
                                 double basePrice, string description, string imageUrl)
    {
        public int Id => id;
        public string Name => name;
        public double BasePrice => basePrice;
        public string Description => description;
        public string ImageUrl => imageUrl;

        // no debería ser estático?
        public string GetFromattedBasePrice() => 
            basePrice.ToString();
    }
}
