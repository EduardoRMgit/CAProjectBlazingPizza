using C3.NorthWind.BlazingPizza.GetToppings.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.GetToppings.Repositories.Configurations
{
    internal class ToppingConfiguration : IEntityTypeConfiguration<Topping>
    {
        public void Configure(EntityTypeBuilder<Topping> builder)
        {
            builder.Property(t => t.Price).
                HasPrecision(8, 2);

                    builder.HasData(
                    new Topping
                    {
                        Id = 1,
                        Name = "Queso extra",
                        Price = 23.50
                    },
                   new Topping
                   {
                       Id = 2,
                       Name = "Tocino de pavo",
                       Price = 28.80
                   },
                   new Topping
                   {
                       Id = 3,
                       Name = "Tocino de jabalí",
                       Price = 28.80
                   },
                   new Topping
                   {
                       Id = 4,
                       Name = "Tocino de ternera",
                       Price = 28.80
                   },
                   new Topping
                   {
                       Id = 5,
                       Name = "Té y bollos",
                       Price = 47.00
                   },
                   new Topping
                   {
                       Id = 6,
                       Name = "Bollos recién horneados",
                       Price = 43.50
                   },
                   new Topping
                   {
                       Id = 7,
                       Name = "Pimiento",
                       Price = 9.00
                   },
                   new Topping
                   {
                       Id = 8,
                       Name = "Cebolla",
                       Price = 9.00
                   },
                   new Topping
                   {
                       Id = 9,
                       Name = "Champiñones",
                       Price = 9.00
                   },
                   new Topping
                   {
                       Id = 10,
                       Name = "Pepperoni",
                       Price = 9.00
                   },
                   new Topping
                   {
                       Id = 11,
                       Name = "Salchicha de pato",
                       Price = 30.80
                   },
                   new Topping
                   {
                       Id = 12,
                       Name = "Albóndigas de venado",
                       Price = 24.50
                   },
                   new Topping
                   {
                       Id = 13,
                       Name = "Cubierta de langosta",
                       Price = 612.50
                   },
                   new Topping
                   {
                       Id = 14,
                       Name = "Caviar de esturión",
                       Price = 965.25
                   },
                   new Topping
                   {
                       Id = 15,
                       Name = "Corazones de alcachofa",
                       Price = 32.60
                   },
                   new Topping
                   {
                       Id = 16,
                       Name = "Tomates frescos",
                       Price = 19.00
                   },
                   new Topping
                   {
                       Id = 17,
                       Name = "Albahaca",
                       Price = 19.00
                   },
                   new Topping
                   {
                       Id = 18,
                       Name = "Filete",
                       Price = 80.50
                   },
                   new Topping
                   {
                       Id = 19,
                       Name = "Pimientos picantes",
                       Price = 39.80
                   },
                   new Topping
                   {
                       Id = 20,
                       Name = "Pollo búfalo",
                       Price = 48.00
                   },
                   new Topping
                   {
                       Id = 21,
                       Name = "Queso azul",
                       Price = 24.50
                   }

                );
        }
    }
}
