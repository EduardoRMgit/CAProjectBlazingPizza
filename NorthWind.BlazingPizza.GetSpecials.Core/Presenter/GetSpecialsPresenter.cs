using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Interfaces;
using NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Options;
using NorthWind.BlazingPizza.GetSpecials.Entities.Dtos;


namespace NorthWind.BlazingPizza.GetSpecials.Core.Presenter
{
    internal class GetSpecialsPresenter(IOptions<GetSpecialsOptions> options) : IGetSpecialsOutputPort
    {
        public IEnumerable<PizzaSpecialDto> PizzaSpecials { get; private set; }

        public Task HandleResultAsync(IEnumerable<PizzaSpecialDto> pizzaSpecials)
        {
            //value es getspecialOptions
            string BaseUri = options.Value.ImageUrlBase.EndsWith("/")? options.Value.ImageUrlBase : options.Value.ImageUrlBase + "/";

            PizzaSpecials = pizzaSpecials.Select(s => new PizzaSpecialDto(
                s.Id, s.Name, s.BasePrice, s.Description, $"{BaseUri}{s.ImageUrl}"));

            return Task.CompletedTask;
        } 
    }
}
