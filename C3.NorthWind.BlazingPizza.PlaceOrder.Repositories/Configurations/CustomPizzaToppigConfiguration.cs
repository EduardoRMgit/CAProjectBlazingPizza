using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Configurations
{
    internal class CustomPizzaToppigConfiguration : IEntityTypeConfiguration<CustomPizzaTopping>
    {
        public void Configure(EntityTypeBuilder<CustomPizzaTopping> builder)
        {

            // como no hay llave por convención o por atributo, se tiene que hacer una llave primaria 
            // compuesta, el Id del custompizzaTopping + El topping Id
            builder.HasKey(cpt =>
                new { cpt.CustomPizzaId, cpt.ToppingId });


            // Una pizza puede tener muchos toppings
            // relación uno a mucho.
            builder.HasOne<CustomPizza>().WithMany(cp => cp.Toppings);
        }
    }
}
