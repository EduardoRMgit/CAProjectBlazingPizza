using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.GetSpecials.SQLiteEFProvider.Options
{
    public class GetSpecialsDBOptions
    {
        public const string SectionKey = nameof(GetSpecialsDBOptions);
        public string ConnectionString { get; set; }
    }
}
