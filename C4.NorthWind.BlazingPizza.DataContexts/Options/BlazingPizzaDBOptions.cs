using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4.NorthWind.BlazingPizza.DataContexts.Options
{
    public class BlazingPizzaDBOptions
    {
        public const string SectionKey = nameof(BlazingPizzaDBOptions);
        public string ConnectionString { get; set; }
    }
}
