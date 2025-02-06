using C3.NorthWind.BlazingPizza.GetToppings.Repositories.Configurations;
using C3.NorthWind.BlazingPizza.GetToppings.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.GetToppings.Repositories.DataContexts
{
    // HEREDA DE DB CONTEXT PARA TENER EL MODELO DE LA BASE DE DATOS
    internal class GetToppingsContext: DbContext
    {

        // recibe las opciones para el contexto de la base de datos
        // esas opciones, pasele a la clase base
        public GetToppingsContext(DbContextOptions<GetToppingsContext> options): base (options)
        {
            // NO LLEVES UN REGISTRO DE CAMBIOS
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        // cuando estés creando el modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // aplicacr configuraciones de este assemby, donde este definido en el topic configuration
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ToppingConfiguration).Assembly);
        }

        // estructura para que crees una tabla que se llame Toppings
        public DbSet<Topping> Toppings { get; set; }
    }
}
