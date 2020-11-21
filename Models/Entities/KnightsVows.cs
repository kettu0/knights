using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knights.Models
{
    public class KnightsVows
    {
        public int KnightId { get; set; }
        public int VowId { get; set; }

        //Relationships
        public Knight Knight { get; set; }
        public Vow Vow { get; set; }
    }
}
