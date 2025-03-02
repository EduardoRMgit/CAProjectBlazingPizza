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
    internal class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);

            builder.Property(a => a.AddressLine1).IsRequired().HasMaxLength(100);

            builder.Property(a => a.AddressLine2).HasMaxLength(100);

            builder.Property(a => a.City).IsRequired().HasMaxLength(50);

            builder.Property(a => a.Region).IsRequired().HasMaxLength(50);

            builder.Property(a => a.PostalCode).HasMaxLength(10);
        }
    }
}
