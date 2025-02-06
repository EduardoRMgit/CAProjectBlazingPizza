﻿using C3.NorthWind.BlazingPizza.GetToppings.Repositories.Configurations;
using C3.NorthWind.BlazingPizza.GetToppings.Repositories.Entities;
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
                typeof(ToppingConfiguration).Assembly);
        }


        public DbSet<Topping> Toppings { get; set; }


    }
}
