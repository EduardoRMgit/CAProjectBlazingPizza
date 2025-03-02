using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Configurations
{
    internal class CustomPizzaConfiguration : IEntityTypeConfiguration<CustomPizza>
    {
        public void Configure(EntityTypeBuilder<CustomPizza> builder)
        {
            builder.Property(p => p.TotalPrice).HasPrecision(8, 2);
        }
    }
}
