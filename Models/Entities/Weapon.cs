using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knights.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Knight Knight { get; set; }
        public int KnightId { get; set; }
    }
}
