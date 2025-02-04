using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.BlazingPizza.GetSpecials.Repositories.cs.DataContexts;
using NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider.Options;


namespace NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddSQLiteProvider(
            this IServiceCollection services,
            Action<GetSpecialsDBOptions> configureGetSpecialsDbOptions)
        {
            GetSpecialsDBOptions Options = new();
            configureGetSpecialsDbOptions(Options);

            services.AddDbContext<GetSpecialsContext>(options =>
                options.UseSqlite(Options.ConnectionString));

            return services;
        }

        // para que sirve?
        public static IHost InitializeGetSpecialDB(this IHost app)
        {
            Console.WriteLine("Se está creando la wea?");
            using IServiceScope Scope = app.Services.CreateScope();
            var Context = Scope.ServiceProvider.GetRequiredService<GetSpecialsContext>();

            Context.Database.EnsureCreated();
            return app;
        }
    }

}
