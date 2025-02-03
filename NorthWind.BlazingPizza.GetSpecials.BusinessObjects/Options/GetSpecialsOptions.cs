using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.BusinessObjects.Options
{
    public sealed class GetSpecialsOptions
    {
        public const string SectionKey = nameof(GetSpecialsOptions);

        // para el options, definimos
        public string ImageUrlBase { get; set; }
    }
}
