using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knights.Models.ViewModels
{
    public class KnightsHorsesViewModel
    {
        public IEnumerable<Horse> Horses { get; set; }
        public IEnumerable<Knight> Knights { get; set; }
    }
}
