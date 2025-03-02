using C3.NorthWind.BlazingPizza.GetToppings.Repositories.Configurations;
using C3.NorthWind.BlazingPizza.GetToppings.Repositories.Entities;
using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Configurations;
using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Entities;
using Microsoft.EntityFrameworkCore;


namespace C4.NorthWind.BlazingPizza.DataContexts.DbContexts
{
    // todo => hacer que jale XD

    // vas a hacer la migración: tools > nuggetConsole > Add-Migration
    // solo para tiempo de diseño
    internal class BlazingPizzaContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=BlazingPizzaDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(ToppingConfiguration).Assembly)
                .ApplyConfigurationsFromAssembly(
                typeof(CustomPizzaConfiguration).Assembly);
        }

        public DbSet<Topping> Toppings { get; set; }
        public DbSet<CustomPizza> CustomPizzas { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}
