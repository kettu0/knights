using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knights.Models
{
    public class KnightsHorsesVowWeaponsViewModel
    {
        public IEnumerable<Knight> Knights { get; set; }
        public IEnumerable<Horse> Horses { get; set; }
        public IEnumerable<Vow> Vows { get; set; }
        public IEnumerable<Weapon> Weapons { get; set; }

    }
}
