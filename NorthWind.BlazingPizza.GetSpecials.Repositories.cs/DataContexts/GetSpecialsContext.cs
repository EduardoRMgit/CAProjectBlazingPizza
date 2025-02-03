using Microsoft.EntityFrameworkCore;
using NorthWind.BlazingPizza.GetSpecials.Repositories.cs.Configurations;
using NorthWind.BlazingPizza.GetSpecials.Repositories.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.Repositories.cs.DataContexts
{
    internal class GetSpecialsContext : DbContext

        // Db context implementa el patrón repositorio, para que implemento un repositorio si voy a utilizar entity framework que ya implemente repositorio.
        // y el patrón unit of work. Save Changes async.

        // entity framework tiene un conjunto de registro de datos, voy a verificar si alguno de esos objetos se modificó.

        // update. No hay que perder el tiempo entity framework de llevar un seguimiento de los cambios.
    {
        public GetSpecialsContext(DbContextOptions<GetSpecialsContext> options) : base(options)
        {
            // que no lleve un tracking porque no hay cambios
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(PizzaSpecialConfiguration).Assembly);
        }

        public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
    }
}
