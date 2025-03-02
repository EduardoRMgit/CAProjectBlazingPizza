using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Configurations;
using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.DataContexts
{
    internal class PlaceOrderContext: DbContext
    {
        // Al heredad DBContext, el constructor debe recibir un DBContextOptions de Place Order Context, y se lo debe pasar al base.

        public PlaceOrderContext(DbContextOptions<PlaceOrderContext> options):
            base(options)
        {
            ChangeTracker.QueryTrackingBehavior =
                QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(CustomPizzaConfiguration).Assembly);
        }

        public DbSet<CustomPizza> CustomPizzas { get; set; }
        public DbSet<Order> Orders { get; set; }   
    }
}
