using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knights.Models.ViewModels
{
    public class KnightsVowsViewModel
    {
        public IEnumerable<Horse> Horses { get; set; }
        public IEnumerable<Vow> Vows { get; set; }
    }
}
