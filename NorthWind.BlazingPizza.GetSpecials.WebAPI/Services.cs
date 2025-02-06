using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Options;
using NorthWind.BlazingPizza.GetSpecials.IoC;
using NorthWind.BlazingPizza.GetSpecials.SQLiteEntityFProvider.Options;

namespace NorthWind.BlazingPizza.GetSpecials.WebAPI
{
    public static class Services
    {
        public static WebApplicationBuilder AddGetSpecialsServices(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddGetSpecialsServices(
                getSpecialsOptions => builder.Configuration.GetRequiredSection(GetSpecialsOptions.SectionKey).Bind(getSpecialsOptions),
                getSpecialsDBOptions => builder.Configuration.GetRequiredSection(GetSpecialsDBOptions.SectionKey).Bind(getSpecialsDBOptions));

            return builder;
        }
    }
}
